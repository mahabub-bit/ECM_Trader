﻿// <auto-generated />
using System;
using ECM_ExcellentAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECM_ExcellentAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("ECM_ExcellentAPI.Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerAccNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerBank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerBankBranch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerBankDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerDetails1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerDetails2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerDetails3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerDetails4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerFax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerGSTIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerHomeNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerJobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerLandLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerMobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerZip")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ECM_ExcellentAPI.Model.CustomerAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("ShipCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipCol1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipCol2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipCol3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipHNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipStreet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipZip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomersAddress");
                });

            modelBuilder.Entity("ECM_ExcellentAPI.Model.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerAddressId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OrderCloseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderDesc1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderDesc2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderDesc3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShipAddressId")
                        .HasColumnType("int");

                    b.Property<decimal>("ShipAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ShipDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Taxes")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CustomerAddressId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ECM_ExcellentAPI.Model.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("CGst")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OrderDeatailStatusId")
                        .HasColumnType("int");

                    b.Property<string>("OrderDetailDesc1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderDetailDesc2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderDetailDesc3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("OrderItemAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<decimal>("SGst")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TaxableValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("OrderId");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrdersDetail");
                });

            modelBuilder.Entity("ECM_ExcellentAPI.Model.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("ECM_ExcellentAPI.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryTypeId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<double>("CostPrice")
                        .HasColumnType("float");

                    b.Property<bool>("Discontinued")
                        .HasColumnType("bit");

                    b.Property<double>("Gst")
                        .HasColumnType("float");

                    b.Property<string>("GstSlab")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MRPPrice")
                        .HasColumnType("float");

                    b.Property<string>("PAddColumn1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PAddColumn2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PAddColumn3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PAddColumn4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PAddColumn5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PAddColumn6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PackageSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QtyPerUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RetailerPrice")
                        .HasColumnType("float");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CategoryTypeId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ECM_ExcellentAPI.Model.Product_Rate_History", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryTypeId")
                        .HasColumnType("int");

                    b.Property<double>("Daily_Product_Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PRH_AddColunm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PRH_AddColunm2")
                        .HasColumnType("int");

                    b.Property<decimal>("PRH_AddColunm3")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PRH_AddColunm4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CategoryTypeId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductRates");
                });

            modelBuilder.Entity("ECM_ExcellentAPI.Model.PurchaseOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddPurchaseColumn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddPurchaseColumn2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddPurchaseColumn3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClosedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ClosedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpectedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PO_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("PO_Invoice")
                        .HasColumnType("int");

                    b.Property<string>("PO_Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PO_TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentType")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ShippingFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<float>("Taxes")
                        .HasColumnType("real");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SupplierId");

                    b.HasIndex("UserId");

                    b.ToTable("PurchaseOrders");
                });

            modelBuilder.Entity("ECM_ExcellentAPI.Model.PurchaseOrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("CGst")
                        .HasColumnType("real");

                    b.Property<string>("PodAddInfo1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PodAddInfo2")
                        .HasColumnType("int");

                    b.Property<DateTime>("PodAddInfo3")
                        .HasColumnType("datetime2");

                    b.Property<float>("PodAddInfo4")
                        .HasColumnType("real");

                    b.Property<string>("PodAddInfo5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PodAddInfo6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PodAddInfo7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PodAddInfo8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PodDiscount")
                        .HasColumnType("real");

                    b.Property<float>("PodItemAmount")
                        .HasColumnType("real");

                    b.Property<DateTime>("PodMfgDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PodQty")
                        .HasColumnType("int");

                    b.Property<float>("PodTaxableValue")
                        .HasColumnType("real");

                    b.Property<float>("PodTotalPrice")
                        .HasColumnType("real");

                    b.Property<float>("PodUnitPrice")
                        .HasColumnType("real");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseId")
                        .HasColumnType("int");

                    b.Property<string>("PurchaseInvoiceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PurchaseOrderId")
                        .HasColumnType("int");

                    b.Property<float>("SGst")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("PurchaseOrderId");

                    b.ToTable("PurchaseOrdersDetail");
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

            modelBuilder.Entity("ECM_ExcellentAPI.Model.CustomerAddress", b =>
                {
                    b.HasOne("ECM_ExcellentAPI.Model.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ECM_ExcellentAPI.Model.Order", b =>
                {
                    b.HasOne("ECM_ExcellentAPI.Model.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECM_ExcellentAPI.Model.CustomerAddress", "CustomerAddress")
                        .WithMany()
                        .HasForeignKey("CustomerAddressId");

                    b.HasOne("ECM_ExcellentAPI.Model.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECM_ExcellentAPI.Model.OrderStatus", "OrderStatus")
                        .WithMany()
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECM_ExcellentAPI.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Customer");

                    b.Navigation("CustomerAddress");

                    b.Navigation("OrderStatus");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ECM_ExcellentAPI.Model.OrderDetail", b =>
                {
                    b.HasOne("ECM_ExcellentAPI.Model.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECM_ExcellentAPI.Model.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECM_ExcellentAPI.Model.OrderStatus", "OrderStatus")
                        .WithMany()
                        .HasForeignKey("OrderStatusId");

                    b.HasOne("ECM_ExcellentAPI.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Order");

                    b.Navigation("OrderStatus");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ECM_ExcellentAPI.Model.Product", b =>
                {
                    b.HasOne("ECM_ExcellentAPI.Model.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECM_ExcellentAPI.Model.CategoryType", "CategoryType")
                        .WithMany()
                        .HasForeignKey("CategoryTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECM_ExcellentAPI.Model.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECM_ExcellentAPI.Model.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("CategoryType");

                    b.Navigation("Company");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("ECM_ExcellentAPI.Model.Product_Rate_History", b =>
                {
                    b.HasOne("ECM_ExcellentAPI.Model.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECM_ExcellentAPI.Model.CategoryType", "CategoryType")
                        .WithMany()
                        .HasForeignKey("CategoryTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECM_ExcellentAPI.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("CategoryType");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ECM_ExcellentAPI.Model.PurchaseOrder", b =>
                {
                    b.HasOne("ECM_ExcellentAPI.Model.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECM_ExcellentAPI.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECM_ExcellentAPI.Model.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECM_ExcellentAPI.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Product");

                    b.Navigation("Supplier");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ECM_ExcellentAPI.Model.PurchaseOrderDetail", b =>
                {
                    b.HasOne("ECM_ExcellentAPI.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECM_ExcellentAPI.Model.PurchaseOrder", "PurchaseOrder")
                        .WithMany()
                        .HasForeignKey("PurchaseOrderId");

                    b.Navigation("Product");

                    b.Navigation("PurchaseOrder");
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
