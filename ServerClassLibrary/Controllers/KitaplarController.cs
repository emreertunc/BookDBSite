using AutoMapper;
using ServerClassLibrary.Helpers;
using OrtakClassLibrary.DTOs;
using OrtakClassLibrary.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitapSitesi.Server;
//using Fluent.Infrastructure.FluentModel;

namespace ServerClassLibrary.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KitaplarController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFileStorageService fileStorageService;
        private readonly IMapper mapper;
        private string containerName = "kitaplar";

        public KitaplarController(ApplicationDbContext context,
            IFileStorageService fileStorageService,
            IMapper mapper)
        {
            this.context = context;
            this.fileStorageService = fileStorageService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IndexPageDTO>> Get()
        {
            var limit = 400;

            var listelenecekKitaplar = await context.Kitaplar
                .Where(x => x.KitapListele).Take(limit)
                .OrderByDescending(x => x.YayinTarihi)
                .ToListAsync();

            var todaysDate = DateTime.Today;

            var upcomingReleases = await context.Kitaplar
                .Where(x => x.YayinTarihi > todaysDate)
                .OrderBy(x => x.YayinTarihi).Take(limit)
                .ToListAsync();

            var response = new IndexPageDTO();
            response.Kitaplistele = listelenecekKitaplar;

            return response;

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DetailsKitapDTO>> Get(int id)
        {
            var kitap = await context.Kitaplar.Where(x => x.Id == id)
                .Include(x => x.KitaplarKitapturler).ThenInclude(x => x.Kitaptur)
                .Include(x => x.KitapYazarlari).ThenInclude(x => x.Kisi)
                .FirstOrDefaultAsync();

            if (kitap == null) { return NotFound(); }

            kitap.KitapYazarlari = kitap.KitapYazarlari.OrderBy(x => x.Order).ToList();

            var model = new DetailsKitapDTO();
            model.Kitap = kitap;
            model.Kitapturler = kitap.KitaplarKitapturler.Select(x => x.Kitaptur).ToList();
            model.Yazar = kitap.KitapYazarlari.Select(x =>
                new Kisi
                {
                    Isim = x.Kisi.Isim,
                    Resim = x.Kisi.Resim,
                    Character = x.Character,
                    Id = x.KisiId

                }).ToList();

            return model;
        }

        [HttpPost("filter")]
        public async Task<ActionResult<List<Kitap>>> Filter(FilterKitaplarDTO filterKitaplarDTO)
        {
            var kitaplarQueryable = context.Kitaplar.AsQueryable();

            if (!string.IsNullOrWhiteSpace(filterKitaplarDTO.Baslik))
            {
                kitaplarQueryable = kitaplarQueryable
                    .Where(x => x.Baslik.Contains(filterKitaplarDTO.Baslik));
            }

            if (filterKitaplarDTO.KitapListele)
            {
                kitaplarQueryable = kitaplarQueryable.Where(x => x.KitapListele);
            }


            if (filterKitaplarDTO.KitapturId != 0)
            {
                kitaplarQueryable = kitaplarQueryable
                    .Where(x => x.KitaplarKitapturler.Select(y => y.KitapturId)
                    .Contains(filterKitaplarDTO.KitapturId));
            }

            await HttpContext.InsertPaginationParametersInResponse(kitaplarQueryable,
                filterKitaplarDTO.RecordsPerPage);

            var kitaplar = await kitaplarQueryable.Paginate(filterKitaplarDTO.Pagination).ToListAsync();

            return kitaplar;
        }



        [HttpGet("update/{id}")]
        public async Task<ActionResult<KitapUpdateDTO>> PutGet(int id)
        {
            var kitapActionResult = await Get(id);
            if (kitapActionResult.Result is NotFoundResult) { return NotFound(); }

            var kitapDetailDTO = kitapActionResult.Value;
            var selectedKitapturlerIds = kitapDetailDTO.Kitapturler.Select(x => x.Id).ToList();
            var notSelectedKitapturler = await context.Kitapturler
                .Where(x => !selectedKitapturlerIds.Contains(x.Id))
                .ToListAsync();

            var model = new KitapUpdateDTO();
            model.Kitap = kitapDetailDTO.Kitap;
            model.SelectedKitapturler = kitapDetailDTO.Kitapturler;
            model.NotSelectedKitapturler = notSelectedKitapturler;
            model.Yazar = kitapDetailDTO.Yazar;
            return model;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Kitap kitap)
        {
            if (!string.IsNullOrWhiteSpace(kitap.KitapKapak))
            {
                var kitapkapak = Convert.FromBase64String(kitap.KitapKapak);
                kitap.KitapKapak = await fileStorageService.SaveFile(kitapkapak, "jpg", containerName);
            }

            if (kitap.KitapYazarlari != null)
            {
                for (int i = 0; i < kitap.KitapYazarlari.Count; i++)
                {
                    kitap.KitapYazarlari[i].Order = i + 1;
                }
            }

            context.Add(kitap);
            await context.SaveChangesAsync();
            return kitap.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Kitap kitap)
        {
            var kitapDB = await context.Kitaplar.FirstOrDefaultAsync(x => x.Id == kitap.Id);

            if (kitapDB == null) { return NotFound(); }

            kitapDB = mapper.Map(kitap, kitapDB);

            if (!string.IsNullOrWhiteSpace(kitap.KitapKapak))
            {
                var kitapKapak = Convert.FromBase64String(kitap.KitapKapak);
                kitapDB.KitapKapak = await fileStorageService.EditFile(kitapKapak,
                    "jpg", containerName, kitapDB.KitapKapak);
            }

            await context.Database.ExecuteSqlInterpolatedAsync($"delete from KitapYazarlari where KitapId = {kitap.Id}; delete from KitaplarKitapturler where KitapId = {kitap.Id}");

            if (kitap.KitapYazarlari != null)
            {
                for (int i = 0; i < kitap.KitapYazarlari.Count; i++)
                {
                    kitap.KitapYazarlari[i].Order = i + 1;
                }
            }

            kitapDB.KitapYazarlari = kitap.KitapYazarlari;
            kitapDB.KitaplarKitapturler = kitap.KitaplarKitapturler;

            await context.SaveChangesAsync();
            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var kitap = await context.Kitaplar.FirstOrDefaultAsync(x => x.Id == id);
            if (kitap == null)
            {
                return NotFound();
            }

            context.Remove(kitap);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
