﻿// <auto-generated />
using System;
using ECM_ExcellentAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECM_ExcellentAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230724200306_AddCompanyTableToDb")]
    partial class AddCompanyTableToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ECM_ExcellentAPI.Model.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CBank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CBankAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CBankBranch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CBusinessPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CC1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CC2")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CC3")
                        .HasColumnType("int");

                    b.Property<string>("CC4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CGST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CIFSC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CState")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });
#pragma warning restore 612, 618
        }
    }
}