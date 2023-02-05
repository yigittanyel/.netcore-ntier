using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FishingApp.DataAccess.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Birims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrupAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PersonelKodu = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Eposta = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BirimId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kullanicis_Birims_BirimId",
                        column: x => x.BirimId,
                        principalTable: "Birims",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GrupKullanici",
                columns: table => new
                {
                    GrupsId = table.Column<int>(type: "int", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupKullanici", x => new { x.GrupsId, x.KullaniciId });
                    table.ForeignKey(
                        name: "FK_GrupKullanici_Grups_GrupsId",
                        column: x => x.GrupsId,
                        principalTable: "Grups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrupKullanici_Kullanicis_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sablons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SablonAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    İcerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: true),
                    GrupId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sablons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sablons_Grups_GrupId",
                        column: x => x.GrupId,
                        principalTable: "Grups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sablons_Kullanicis_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Kampanyas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KampanyaDurumu = table.Column<bool>(type: "bit", nullable: false),
                    SablonId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kampanyas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kampanyas_Sablons_SablonId",
                        column: x => x.SablonId,
                        principalTable: "Sablons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KampanyaSonucs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KampanyaSonucDurum = table.Column<bool>(type: "bit", nullable: false),
                    Tikladi = table.Column<bool>(type: "bit", nullable: false),
                    VeriGirdi = table.Column<bool>(type: "bit", nullable: false),
                    KampanyaId = table.Column<int>(type: "int", nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KampanyaSonucs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KampanyaSonucs_Kampanyas_KampanyaId",
                        column: x => x.KampanyaId,
                        principalTable: "Kampanyas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KampanyaSonucs_Kullanicis_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_GrupKullanici_KullaniciId",
                table: "GrupKullanici",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Kampanyas_SablonId",
                table: "Kampanyas",
                column: "SablonId");

            migrationBuilder.CreateIndex(
                name: "IX_KampanyaSonucs_KampanyaId",
                table: "KampanyaSonucs",
                column: "KampanyaId");

            migrationBuilder.CreateIndex(
                name: "IX_KampanyaSonucs_KullaniciId",
                table: "KampanyaSonucs",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicis_BirimId",
                table: "Kullanicis",
                column: "BirimId");

            migrationBuilder.CreateIndex(
                name: "IX_Sablons_GrupId",
                table: "Sablons",
                column: "GrupId");

            migrationBuilder.CreateIndex(
                name: "IX_Sablons_KullaniciId",
                table: "Sablons",
                column: "KullaniciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GrupKullanici");

            migrationBuilder.DropTable(
                name: "KampanyaSonucs");

            migrationBuilder.DropTable(
                name: "Kampanyas");

            migrationBuilder.DropTable(
                name: "Sablons");

            migrationBuilder.DropTable(
                name: "Grups");

            migrationBuilder.DropTable(
                name: "Kullanicis");

            migrationBuilder.DropTable(
                name: "Birims");
        }
    }
}
