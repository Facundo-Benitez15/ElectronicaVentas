﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VentasElectronica.Data;

#nullable disable

namespace ElectronicaVentas.Migrations
{
    [DbContext(typeof(ElectronicaDbContext))]
    [Migration("20230501215559_DetalleCliente")]
    partial class DetalleCliente
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("ElectronicaVentas.Models.Cliente", b =>
                {
                    b.Property<int>("clienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("dni")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("clienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ElectronicaVentas.Models.Producto", b =>
                {
                    b.Property<int>("productoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("precio")
                        .HasColumnType("INTEGER");

                    b.HasKey("productoId");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("VentasElectronica.Models.DetalleCliente", b =>
                {
                    b.Property<int>("DetalleClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("clienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("fecha_nacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DetalleClienteId");

                    b.ToTable("DetalleCliente");
                });
#pragma warning restore 612, 618
        }
    }
}
