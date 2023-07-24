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
    [Migration("20230728112709_AddUserTableToDb")]
    partial class AddUserTableToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ECM_ExcellentAPI.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ECM_ExcellentAPI.Model.CategoryType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("CatTypeDesc2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CatTypeDesc3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CatTypeDesc4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CatTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryTypes");
                });

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

            modelBuilder.Entity("ECM_ExcellentAPI.Model.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Supplier_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier_Business_Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier_City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier_Company_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier_Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier_D")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier_Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier_Home_Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier_JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier_Moblie_Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier_Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier_Pan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier_Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier_State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier_Webpage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier_ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("ECM_ExcellentAPI.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ECM_ExcellentAPI.Model.Category", b =>
                {
                    b.HasOne("ECM_ExcellentAPI.Model.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("ECM_ExcellentAPI.Model.CategoryType", b =>
                {
                    b.HasOne("ECM_ExcellentAPI.Model.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ECM_ExcellentAPI.Model.Supplier", b =>
                {
                    b.HasOne("ECM_ExcellentAPI.Model.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });
#pragma warning restore 612, 618
        }
    }
}
