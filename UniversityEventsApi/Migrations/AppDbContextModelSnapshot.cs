﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UniversityEventsApi.Data;

#nullable disable

namespace UniversityEventsApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("UniversityEventsApi.Models.Campus", b =>
                {
                    b.Property<int>("CampusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CampusId"));

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.HasKey("CampusId");

                    b.ToTable("Campus");
                });

            modelBuilder.Entity("UniversityEventsApi.Models.Docente", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<string>("CodigoDocente")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DocenteId")
                        .HasColumnType("integer");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Docentes");
                });

            modelBuilder.Entity("UniversityEventsApi.Models.Ubicacion", b =>
                {
                    b.Property<int>("UbicacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UbicacionId"));

                    b.Property<string>("Espacio")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UbicacionId");

                    b.ToTable("Ubicaciones");
                });
#pragma warning restore 612, 618
        }
    }
}
