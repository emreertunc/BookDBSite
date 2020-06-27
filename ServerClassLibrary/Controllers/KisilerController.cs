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

namespace ServerClassLibrary.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KisilerController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFileStorageService fileStorageService;
        private readonly IMapper mapper;

        public KisilerController(ApplicationDbContext context,
            IFileStorageService fileStorageService,
            IMapper mapper)
        {
            this.context = context;
            this.fileStorageService = fileStorageService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Kisi>>> Get([FromQuery] PaginationDTO paginationDTO)
        {
            var queryable = context.Kisiler.AsQueryable();
            await HttpContext.InsertPaginationParametersInResponse(queryable, paginationDTO.RecordsPerPage);
            return await queryable.Paginate(paginationDTO).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Kisi>> Get(int id)
        {
            var kisi = await context.Kisiler.FirstOrDefaultAsync(x => x.Id == id);
            if (kisi == null) { return NotFound(); }
            return kisi;
        }

        [HttpGet("search/{searchText}")]
        public async Task<ActionResult<List<Kisi>>> FilterByName(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText)) { return new List<Kisi>(); }
            return await context.Kisiler.Where(x => x.Isim.Contains(searchText))
                .Take(5)
                .ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Kisi kisi)
        {
            if (!string.IsNullOrWhiteSpace(kisi.Resim))
            {
                var kisiPicture = Convert.FromBase64String(kisi.Resim);
                kisi.Resim = await fileStorageService.SaveFile(kisiPicture, "jpg", "kisiler");
            }

            context.Add(kisi);
            await context.SaveChangesAsync();
            return kisi.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Kisi kisi)
        {
            var kisiDB = await context.Kisiler.FirstOrDefaultAsync(x => x.Id == kisi.Id);

            if (kisiDB == null) { return NotFound(); }

            kisiDB = mapper.Map(kisi, kisiDB);

            if (!string.IsNullOrWhiteSpace(kisi.Resim))
            {
                var kisiPicture = Convert.FromBase64String(kisi.Resim);
                kisiDB.Resim = await fileStorageService.EditFile(kisiPicture,
                    "jpg", "kisiler", kisiDB.Resim);
            }

            await context.SaveChangesAsync();
            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var kisi = await context.Kisiler.FirstOrDefaultAsync(x => x.Id == id);
            if (kisi == null)
            {
                return NotFound();
            }

            context.Remove(kisi);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
