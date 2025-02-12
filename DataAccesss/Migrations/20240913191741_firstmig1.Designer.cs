﻿// <auto-generated />
using System;
using DataAccesss.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccesss.Migrations
{
    [DbContext(typeof(HavaDurumuDbContext))]
    [Migration("20240913191741_firstmig1")]
    partial class firstmig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.SehirHavaDurumu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Derece")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gun")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HavaDurumuAciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SehirAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SorguZamani")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SehirHavaDurumlari_TBL");
                });
#pragma warning restore 612, 618
        }
    }
}
