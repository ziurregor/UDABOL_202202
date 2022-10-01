using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EntityPosgardo.Migrations
{
    public partial class post : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cargo = table.Column<string>(type: "text", nullable: true),
                    estado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.RolesId);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    UsuariosId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: true),
                    Detalle = table.Column<string>(type: "text", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    estado = table.Column<bool>(type: "boolean", nullable: false),
                    RolesId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.UsuariosId);
                    table.ForeignKey(
                        name: "FK_usuario_Cargo_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Cargo",
                        principalColumn: "RolesId");
                });

            migrationBuilder.CreateTable(
                name: "Mensaje",
                columns: table => new
                {
                    MensajeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MensajesXml = table.Column<string>(type: "text", nullable: true),
                    estado = table.Column<bool>(type: "boolean", nullable: false),
                    UsuariosId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensaje", x => x.MensajeId);
                    table.ForeignKey(
                        name: "FK_Mensaje_usuario_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "usuario",
                        principalColumn: "UsuariosId");
                });

            migrationBuilder.InsertData(
                table: "Cargo",
                columns: new[] { "RolesId", "Cargo", "estado" },
                values: new object[,]
                {
                    { 1, "admin", false },
                    { 2, "Prueba", false },
                    { 3, "escritor", false },
                    { 4, "lector", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mensaje_UsuariosId",
                table: "Mensaje",
                column: "UsuariosId");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_RolesId",
                table: "usuario",
                column: "RolesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mensaje");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "Cargo");
        }
    }
}
