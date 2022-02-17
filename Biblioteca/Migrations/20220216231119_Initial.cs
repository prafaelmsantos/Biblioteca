using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Livro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Autor = table.Column<string>(type: "varchar(100)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Livro_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Ação" });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Crime" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "Autor", "CategoriaId", "DataEntrada", "Preco", "Quantidade", "Titulo" },
                values: new object[] { 1, "Peter Parker", 1, new DateTime(2022, 2, 16, 23, 11, 19, 98, DateTimeKind.Local).AddTicks(8148), 25.0, 4, "Spider Man" });

            migrationBuilder.CreateIndex(
                name: "IX_Livro_CategoriaId",
                table: "Livro",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livro");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
