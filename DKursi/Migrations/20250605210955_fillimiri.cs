using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DKursi.Migrations
{
    /// <inheritdoc />
    public partial class fillimiri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategorite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorite", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tavolina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tavolina", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produktet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cmimi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SasiaNeStok = table.Column<int>(type: "int", nullable: false),
                    KategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produktet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produktet_Kategorite_KategoriaId",
                        column: x => x.KategoriaId,
                        principalTable: "Kategorite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Faturat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TavolinaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faturat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faturat_Tavolina_TavolinaId",
                        column: x => x.TavolinaId,
                        principalTable: "Tavolina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FaturaProduktet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaturaId = table.Column<int>(type: "int", nullable: false),
                    ProduktiId = table.Column<int>(type: "int", nullable: false),
                    Sasia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaturaProduktet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FaturaProduktet_Faturat_FaturaId",
                        column: x => x.FaturaId,
                        principalTable: "Faturat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FaturaProduktet_Produktet_ProduktiId",
                        column: x => x.ProduktiId,
                        principalTable: "Produktet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FaturaProduktet_FaturaId",
                table: "FaturaProduktet",
                column: "FaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_FaturaProduktet_ProduktiId",
                table: "FaturaProduktet",
                column: "ProduktiId");

            migrationBuilder.CreateIndex(
                name: "IX_Faturat_TavolinaId",
                table: "Faturat",
                column: "TavolinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produktet_KategoriaId",
                table: "Produktet",
                column: "KategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FaturaProduktet");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "Faturat");

            migrationBuilder.DropTable(
                name: "Produktet");

            migrationBuilder.DropTable(
                name: "Tavolina");

            migrationBuilder.DropTable(
                name: "Kategorite");
        }
    }
}
