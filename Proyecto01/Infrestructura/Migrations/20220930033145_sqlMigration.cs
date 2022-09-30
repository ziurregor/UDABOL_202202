using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrestructura.Migrations
{
    public partial class sqlMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    RolId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.RolId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Usuario = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Edad = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    RolId = table.Column<int>(nullable: true),
                    MensajesMensajeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_Rol_RolId",
                        column: x => x.RolId,
                        principalTable: "Rol",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mensajes",
                columns: table => new
                {
                    MensajeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UseridIdUserId = table.Column<int>(nullable: true),
                    Mensaje = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensajes", x => x.MensajeId);
                    table.ForeignKey(
                        name: "FK_Mensajes_User_UseridIdUserId",
                        column: x => x.UseridIdUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mensajes_UseridIdUserId",
                table: "Mensajes",
                column: "UseridIdUserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_MensajesMensajeId",
                table: "User",
                column: "MensajesMensajeId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RolId",
                table: "User",
                column: "RolId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Mensajes_MensajesMensajeId",
                table: "User",
                column: "MensajesMensajeId",
                principalTable: "Mensajes",
                principalColumn: "MensajeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mensajes_User_UseridIdUserId",
                table: "Mensajes");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Mensajes");

            migrationBuilder.DropTable(
                name: "Rol");
        }
    }
}
