﻿// <auto-generated />
using System;
using KitapSitesi.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KitapSitesi.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrtakClassLibrary.Entities.Kisi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biyografi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DogumTarihi")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Isim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kisiler");
                });

            modelBuilder.Entity("OrtakClassLibrary.Entities.Kitap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KitapKapak")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("KitapListele")
                        .HasColumnType("bit");

                    b.Property<string>("Ozet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TanitimVideo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("YayinTarihi")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Kitaplar");
                });

            modelBuilder.Entity("OrtakClassLibrary.Entities.KitapYazarlari", b =>
                {
                    b.Property<int>("KitapId")
                        .HasColumnType("int");

                    b.Property<int>("KisiId")
                        .HasColumnType("int");

                    b.Property<string>("Character")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("KitapId", "KisiId");

                    b.HasIndex("KisiId");

                    b.ToTable("KitapYazarlari");
                });

            modelBuilder.Entity("OrtakClassLibrary.Entities.KitaplarKitapturler", b =>
                {
                    b.Property<int>("KitapId")
                        .HasColumnType("int");

                    b.Property<int>("KitapturId")
                        .HasColumnType("int");

                    b.HasKey("KitapId", "KitapturId");

                    b.HasIndex("KitapturId");

                    b.ToTable("KitaplarKitapturler");
                });

            modelBuilder.Entity("OrtakClassLibrary.Entities.Kitaptur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kitapturler");
                });

            modelBuilder.Entity("OrtakClassLibrary.Entities.KitapYazarlari", b =>
                {
                    b.HasOne("OrtakClassLibrary.Entities.Kisi", "Kisi")
                        .WithMany("KitapYazarlari")
                        .HasForeignKey("KisiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrtakClassLibrary.Entities.Kitap", "Kitap")
                        .WithMany("KitapYazarlari")
                        .HasForeignKey("KitapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrtakClassLibrary.Entities.KitaplarKitapturler", b =>
                {
                    b.HasOne("OrtakClassLibrary.Entities.Kitap", "Kitap")
                        .WithMany("KitaplarKitapturler")
                        .HasForeignKey("KitapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrtakClassLibrary.Entities.Kitaptur", "Kitaptur")
                        .WithMany("KitaplarKitapturler")
                        .HasForeignKey("KitapturId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
