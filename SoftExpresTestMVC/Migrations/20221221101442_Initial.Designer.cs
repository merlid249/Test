﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoftExpresTestMVC.Data;

#nullable disable

namespace SoftExpresTestMVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221221101442_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SoftExpresTestMVC.Models.Fature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Barkod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Cmimi")
                        .HasColumnType("float");

                    b.Property<DateTime?>("DatasKdences")
                        .HasColumnType("datetime2");

                    b.Property<string>("Emertimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("KaTvsh")
                        .HasColumnType("bit");

                    b.Property<string>("Lloji")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Njesia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fatures");
                });
#pragma warning restore 612, 618
        }
    }
}
