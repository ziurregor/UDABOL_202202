﻿// <auto-generated />
using Infrestructura;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrestructura.Migrations
{
    [DbContext(typeof(ChatPOSTGREContext))]
    [Migration("20220927234713_postgresqlMigration")]
    partial class postgresqlMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Modelo.Mensajes", b =>
                {
                    b.Property<int>("MensajeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("MensajeId");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MensajeId"));

                    b.Property<string>("Mensaje")
                        .HasColumnType("text");

                    b.Property<int>("UseridId")
                        .HasColumnType("integer");

                    b.HasKey("MensajeId");

                    b.ToTable("Mensaje");
                });

            modelBuilder.Entity("Modelo.Roles", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("RolId");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RolId"));

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.HasKey("RolId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Modelo.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("UserId");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("Usuario")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
