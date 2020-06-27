//using Fluent.Infrastructure.FluentModel;
using KitapSitesi.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrtakClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerClassLibrary.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KitapturlerController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public KitapturlerController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Kitaptur>>> Get()
        {
            return await context.Kitapturler.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Kitaptur>> Get(int id)
        {
            var kitaptur = await context.Kitapturler.FirstOrDefaultAsync(x => x.Id == id);
            if (kitaptur == null) { return NotFound(); }
            return kitaptur;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Kitaptur kitaptur)
        {
            context.Add(kitaptur);
            await context.SaveChangesAsync();
            return kitaptur.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Kitaptur kitaptur)
        {
            context.Attach(kitaptur).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var kitaptur = await context.Kitapturler.FirstOrDefaultAsync(x => x.Id == id);
            if (kitaptur == null)
            {
                return NotFound();
            }

            context.Remove(kitaptur);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
