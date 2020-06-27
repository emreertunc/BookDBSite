using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KitapSitesi.Server.Migrations
{
    public partial class InitialDB3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kisiler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(nullable: true),
                    Biyografi = table.Column<string>(nullable: true),
                    Resim = table.Column<string>(nullable: true),
                    DogumTarihi = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisiler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(nullable: false),
                    Ozet = table.Column<string>(nullable: true),
                    KitapListele = table.Column<bool>(nullable: false),
                    TanitimVideo = table.Column<string>(nullable: true),
                    YayinTarihi = table.Column<DateTime>(nullable: false),
                    KitapKapak = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kitapturler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitapturler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KitapYazarlari",
                columns: table => new
                {
                    KisiId = table.Column<int>(nullable: false),
                    KitapId = table.Column<int>(nullable: false),
                    Character = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapYazarlari", x => new { x.KitapId, x.KisiId });
                    table.ForeignKey(
                        name: "FK_KitapYazarlari_Kisiler_KisiId",
                        column: x => x.KisiId,
                        principalTable: "Kisiler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitapYazarlari_Kitaplar_KitapId",
                        column: x => x.KitapId,
                        principalTable: "Kitaplar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KitaplarKitapturler",
                columns: table => new
                {
                    KitapId = table.Column<int>(nullable: false),
                    KitapturId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitaplarKitapturler", x => new { x.KitapId, x.KitapturId });
                    table.ForeignKey(
                        name: "FK_KitaplarKitapturler_Kitaplar_KitapId",
                        column: x => x.KitapId,
                        principalTable: "Kitaplar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitaplarKitapturler_Kitapturler_KitapturId",
                        column: x => x.KitapturId,
                        principalTable: "Kitapturler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KitaplarKitapturler_KitapturId",
                table: "KitaplarKitapturler",
                column: "KitapturId");

            migrationBuilder.CreateIndex(
                name: "IX_KitapYazarlari_KisiId",
                table: "KitapYazarlari",
                column: "KisiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KitaplarKitapturler");

            migrationBuilder.DropTable(
                name: "KitapYazarlari");

            migrationBuilder.DropTable(
                name: "Kitapturler");

            migrationBuilder.DropTable(
                name: "Kisiler");

            migrationBuilder.DropTable(
                name: "Kitaplar");
        }
    }
}
