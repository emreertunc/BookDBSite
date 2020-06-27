using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OrtakClassLibrary.Entities;
using OrtakClassLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitapSitesi.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KitapYazarlari>().HasKey(x => new { x.KitapId, x.KisiId });
            modelBuilder.Entity<KitaplarKitapturler>().HasKey(x => new { x.KitapId, x.KitapturId });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Kitaptur> Kitapturler { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Kisi> Kisiler { get; set; }
        public DbSet<KitapYazarlari> KitapYazarlari { get; set; }
        public DbSet<KitaplarKitapturler> KitaplarKitapturler { get; set; }
    }
}
