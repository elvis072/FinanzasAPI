﻿// <auto-generated />
using System;
using FinanzasAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinanzasAPI.Migrations
{
    [DbContext(typeof(FinanzasDB))]
    partial class FinanzasDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinanzasAPI.Models.HistorialCrediticio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<string>("ConceptoDeuda")
                        .IsRequired();

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("RncEmpresa")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<float>("TotalAdeudado");

                    b.HasKey("Id");

                    b.ToTable("HistorialCrediticio");
                });

            modelBuilder.Entity("FinanzasAPI.Models.Inflacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Fecha");

                    b.Property<float>("Indice");

                    b.HasKey("Id");

                    b.ToTable("Inflacion");
                });

            modelBuilder.Entity("FinanzasAPI.Models.SaludFinanciera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<string>("Comentario");

                    b.Property<bool>("Indicador");

                    b.Property<float>("TotalAdeudado");

                    b.HasKey("Id");

                    b.ToTable("SaludFinanciera");
                });

            modelBuilder.Entity("FinanzasAPI.Models.TasaCambio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cambio");

                    b.Property<string>("CodigoMoneda")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<DateTime?>("Fecha");

                    b.HasKey("Id");

                    b.ToTable("TasaCambio");
                });
#pragma warning restore 612, 618
        }
    }
}
