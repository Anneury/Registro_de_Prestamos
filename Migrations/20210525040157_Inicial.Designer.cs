﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Registro_de_Prestamos.DAL;

namespace Registro_de_Prestamos.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210525040157_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("Registro_de_Prestamos.Model.Personas", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Balance")
                        .HasColumnType("REAL");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PersonaId");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Registro_de_Prestamos.Model.Prestamos", b =>
                {
                    b.Property<int>("PrestamoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Balance")
                        .HasColumnType("REAL");

                    b.Property<string>("Concepto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<float>("Monto")
                        .HasColumnType("REAL");

                    b.Property<int>("PersonaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PrestamoId");

                    b.ToTable("Prestamos");
                });
#pragma warning restore 612, 618
        }
    }
}