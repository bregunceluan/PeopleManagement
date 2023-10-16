using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PeopleManagement.API.Migrations
{
    /// <inheritdoc />
    public partial class InsertingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "cargo",
                columns: new[] { "Id", "descricao", "name" },
                values: new object[,]
                {
                    { 1L, "Engenheiro de Inovação", "Engenharia" },
                    { 2L, "Coordenador Equipes", "Coordenador" }
                });

            migrationBuilder.InsertData(
                table: "equipe",
                columns: new[] { "Id", "coordenadorId", "descricao", "gestorId", "name" },
                values: new object[,]
                {
                    { 1L, 0, "Setor Inovação", 0, "Atenas" },
                    { 2L, 0, "Coordenador Equipes", 0, "Coordenador" }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "Id", "cargoid", "desligamento", "admissao", "empresa", "equipeid", "name", "setorid" },
                values: new object[,]
                {
                    { 1L, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 14, 20, 56, 15, 247, DateTimeKind.Local).AddTicks(5937), "RM Mais Projetos", 1, "Luan Bregunce", 1 },
                    { 2L, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 14, 20, 56, 15, 247, DateTimeKind.Local).AddTicks(5950), "RM Mais Projetos", 1, "Carlos Eduardo", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cargo",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "cargo",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "equipe",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "equipe",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
