﻿// <auto-generated />
using System;
using DemoLocation2000.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoLocation2000.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230216195345_AjoutProprietaires")]
    partial class AjoutProprietaires
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DemoLocation2000.Models.Marque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Marques");
                });

            modelBuilder.Entity("DemoLocation2000.Models.Proprietaire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Proprietaires");
                });

            modelBuilder.Entity("DemoLocation2000.Models.Voiture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Annee")
                        .HasColumnType("int");

                    b.Property<int?>("MarqueId")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProprietaireId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MarqueId");

                    b.HasIndex("ProprietaireId");

                    b.ToTable("Voitures");
                });

            modelBuilder.Entity("DemoLocation2000.Models.Voiture", b =>
                {
                    b.HasOne("DemoLocation2000.Models.Marque", "MarqueVoiture")
                        .WithMany()
                        .HasForeignKey("MarqueId");

                    b.HasOne("DemoLocation2000.Models.Proprietaire", null)
                        .WithMany("Autos")
                        .HasForeignKey("ProprietaireId");

                    b.Navigation("MarqueVoiture");
                });

            modelBuilder.Entity("DemoLocation2000.Models.Proprietaire", b =>
                {
                    b.Navigation("Autos");
                });
#pragma warning restore 612, 618
        }
    }
}
