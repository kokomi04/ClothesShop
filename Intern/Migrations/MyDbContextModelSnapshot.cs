﻿// <auto-generated />
using System;
using Intern.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Intern.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Intern.Entities.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("AccountBorn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AccountCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AccountDetailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountPassWord")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("AccountStatusId")
                        .HasColumnType("int");

                    b.Property<string>("AccountUserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AccountId");

                    b.HasIndex("AccountStatusId");

                    b.HasIndex("RoleId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Intern.Entities.AccountBag", b =>
                {
                    b.Property<int>("AccountBagId")
                        .HasColumnType("int");

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("AccountBagId");

                    b.HasIndex("AccountId");

                    b.HasIndex("ProductId");

                    b.ToTable("AccountBags");
                });

            modelBuilder.Entity("Intern.Entities.AccountShipContact", b =>
                {
                    b.Property<int>("AccountShipContactId")
                        .HasColumnType("int");

                    b.Property<string>("AccountDetailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("AccountPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccountShipContactStatusId")
                        .HasColumnType("int");

                    b.Property<string>("DistrictId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProvinceId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WardCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountShipContactId");

                    b.HasIndex("AccountId");

                    b.HasIndex("AccountShipContactStatusId");

                    b.ToTable("AccountShipContacts");
                });

            modelBuilder.Entity("Intern.Entities.AccountShipContactStatus", b =>
                {
                    b.Property<int>("AccountShipContactStatusId")
                        .HasColumnType("int");

                    b.Property<string>("AccountShipContactStatusCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("AccountShipContactStatusDetail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("AccountShipContactStatusId");

                    b.ToTable("AccountShipContactStatus");
                });

            modelBuilder.Entity("Intern.Entities.AccountStatus", b =>
                {
                    b.Property<int>("AccountStatusId")
                        .HasColumnType("int");

                    b.Property<string>("AccountStatusCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("AccountStatusDetail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("AccountStatusId");

                    b.ToTable("AccountStatus");
                });

            modelBuilder.Entity("Intern.Entities.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .HasColumnType("int");

                    b.Property<int?>("AccountShipContactId")
                        .HasColumnType("int");

                    b.Property<string>("BillCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BillStatusId")
                        .HasColumnType("int");

                    b.Property<int>("BuyMethodId")
                        .HasColumnType("int");

                    b.Property<string>("BuyerNotification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CloseDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdEmployee")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ProductReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReceivedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ShipMethodId")
                        .HasColumnType("int");

                    b.Property<int?>("ShipPrice")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ShipToBuyerDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BillId");

                    b.HasIndex("AccountShipContactId")
                        .IsUnique()
                        .HasFilter("[AccountShipContactId] IS NOT NULL");

                    b.HasIndex("BillStatusId");

                    b.HasIndex("BuyMethodId");

                    b.HasIndex("IdEmployee");

                    b.HasIndex("ShipMethodId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Intern.Entities.BillDetail", b =>
                {
                    b.Property<int>("BillDetailId")
                        .HasColumnType("int");

                    b.Property<int>("BillId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("BillDetailId");

                    b.HasIndex("BillId");

                    b.HasIndex("ProductId");

                    b.ToTable("BillDetails");
                });

            modelBuilder.Entity("Intern.Entities.BillSales", b =>
                {
                    b.Property<int>("BillSalesId")
                        .HasColumnType("int");

                    b.Property<int>("BillId")
                        .HasColumnType("int");

                    b.Property<int>("SalesId")
                        .HasColumnType("int");

                    b.HasKey("BillSalesId");

                    b.HasIndex("BillId");

                    b.HasIndex("SalesId");

                    b.ToTable("BillSales");
                });

            modelBuilder.Entity("Intern.Entities.BillStatus", b =>
                {
                    b.Property<int>("BillStatusId")
                        .HasColumnType("int");

                    b.Property<string>("BillStatusCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("BillStatusDetail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("BillStatusId");

                    b.ToTable("BillStatus");
                });

            modelBuilder.Entity("Intern.Entities.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("BrandCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("BrandDetail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Intern.Entities.BuyMethod", b =>
                {
                    b.Property<int>("BuyMethodId")
                        .HasColumnType("int");

                    b.Property<string>("BuyMethodCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("BuyMethodName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("BuyMethodId");

                    b.ToTable("BuyMethods");
                });

            modelBuilder.Entity("Intern.Entities.CategoryType", b =>
                {
                    b.Property<int>("CategoryTypeId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryTypeCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CategoryTypeDetail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoryTypeId");

                    b.ToTable("CategoryTypes");
                });

            modelBuilder.Entity("Intern.Entities.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<string>("ColorCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ColorDetail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ColorId");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Intern.Entities.Producer", b =>
                {
                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<string>("ProducerCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ProducerDetail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ProducerId");

                    b.ToTable("Producers");
                });

            modelBuilder.Entity("Intern.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryTypeId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<string>("ProductDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductStatusId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ShellPrice")
                        .HasColumnType("int");

                    b.Property<int>("SizeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryTypeId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ProducerId");

                    b.HasIndex("ProductStatusId");

                    b.HasIndex("SizeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Intern.Entities.ProductImgs", b =>
                {
                    b.Property<int>("ProductImgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductImgId"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<byte[]>("ProductImg")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("ProductImgId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImgs");
                });

            modelBuilder.Entity("Intern.Entities.ProductStatus", b =>
                {
                    b.Property<int>("ProductStatusId")
                        .HasColumnType("int");

                    b.Property<string>("ProductStatusCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ProductStatusDetail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ProductStatusId");

                    b.ToTable("ProductStatus");
                });

            modelBuilder.Entity("Intern.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("RoleCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("RoleDetail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Intern.Entities.Sales", b =>
                {
                    b.Property<int>("SalesId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OpenDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SaleInt")
                        .HasColumnType("int");

                    b.Property<string>("SalesCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalesName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SalesPersen")
                        .HasColumnType("int");

                    b.Property<int>("SalesStatusId")
                        .HasColumnType("int");

                    b.Property<int>("SalesTypeId")
                        .HasColumnType("int");

                    b.HasKey("SalesId");

                    b.HasIndex("SalesStatusId");

                    b.HasIndex("SalesTypeId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Intern.Entities.SalesStatus", b =>
                {
                    b.Property<int>("SalesStatusId")
                        .HasColumnType("int");

                    b.Property<string>("SalesStatusCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("SalesStatusDetail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SalesStatusId");

                    b.ToTable("SalesStatus");
                });

            modelBuilder.Entity("Intern.Entities.SalesType", b =>
                {
                    b.Property<int>("SalesTypeId")
                        .HasColumnType("int");

                    b.Property<string>("SalesTypeCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("SalesTypeDetail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SalesTypeId");

                    b.ToTable("SalesTypes");
                });

            modelBuilder.Entity("Intern.Entities.ShipMethod", b =>
                {
                    b.Property<int>("ShipMethodId")
                        .HasColumnType("int");

                    b.Property<string>("ShipMethodCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ShipMethodName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ShipPrice")
                        .HasColumnType("int");

                    b.HasKey("ShipMethodId");

                    b.ToTable("ShipMethods");
                });

            modelBuilder.Entity("Intern.Entities.Size", b =>
                {
                    b.Property<int>("SizeId")
                        .HasColumnType("int");

                    b.Property<string>("SizeCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SizeDetail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SizeId");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("Intern.Entities.VoteStar", b =>
                {
                    b.Property<int>("VoteStarId")
                        .HasColumnType("int");

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("StarVoted")
                        .HasColumnType("int");

                    b.HasKey("VoteStarId");

                    b.HasIndex("AccountId");

                    b.HasIndex("ProductId");

                    b.ToTable("VoteStars");
                });

            modelBuilder.Entity("Intern.Entities.Account", b =>
                {
                    b.HasOne("Intern.Entities.AccountStatus", "AccountStatus")
                        .WithMany("Accounts")
                        .HasForeignKey("AccountStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intern.Entities.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountStatus");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Intern.Entities.AccountBag", b =>
                {
                    b.HasOne("Intern.Entities.Account", "Account")
                        .WithMany("AccountBags")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intern.Entities.Product", "Product")
                        .WithMany("AccountBags")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Intern.Entities.AccountShipContact", b =>
                {
                    b.HasOne("Intern.Entities.Account", "Account")
                        .WithMany("AccountShipContacts")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intern.Entities.AccountShipContactStatus", "AccountShipContactStatus")
                        .WithMany("AccountShipContacts")
                        .HasForeignKey("AccountShipContactStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("AccountShipContactStatus");
                });

            modelBuilder.Entity("Intern.Entities.Bill", b =>
                {
                    b.HasOne("Intern.Entities.AccountShipContact", "AccountShipContact")
                        .WithOne("Bill")
                        .HasForeignKey("Intern.Entities.Bill", "AccountShipContactId");

                    b.HasOne("Intern.Entities.BillStatus", "BillStatus")
                        .WithMany("Bills")
                        .HasForeignKey("BillStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intern.Entities.BuyMethod", "BuyMethod")
                        .WithMany("Bills")
                        .HasForeignKey("BuyMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intern.Entities.Account", "Employee")
                        .WithMany("Bills")
                        .HasForeignKey("IdEmployee");

                    b.HasOne("Intern.Entities.ShipMethod", "ShipMethod")
                        .WithMany("Bills")
                        .HasForeignKey("ShipMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountShipContact");

                    b.Navigation("BillStatus");

                    b.Navigation("BuyMethod");

                    b.Navigation("Employee");

                    b.Navigation("ShipMethod");
                });

            modelBuilder.Entity("Intern.Entities.BillDetail", b =>
                {
                    b.HasOne("Intern.Entities.Bill", "Bill")
                        .WithMany("BillDetail")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intern.Entities.Product", "Product")
                        .WithMany("BillDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Intern.Entities.BillSales", b =>
                {
                    b.HasOne("Intern.Entities.Bill", "Bill")
                        .WithMany("BillSales")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intern.Entities.Sales", "Sales")
                        .WithMany("BillSales")
                        .HasForeignKey("SalesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("Intern.Entities.Product", b =>
                {
                    b.HasOne("Intern.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intern.Entities.CategoryType", "CategoryType")
                        .WithMany("Products")
                        .HasForeignKey("CategoryTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intern.Entities.Color", "Color")
                        .WithMany("Products")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intern.Entities.Producer", "Producer")
                        .WithMany("Products")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intern.Entities.ProductStatus", "ProductStatus")
                        .WithMany("Products")
                        .HasForeignKey("ProductStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intern.Entities.Size", "Size")
                        .WithMany("Products")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("CategoryType");

                    b.Navigation("Color");

                    b.Navigation("Producer");

                    b.Navigation("ProductStatus");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("Intern.Entities.ProductImgs", b =>
                {
                    b.HasOne("Intern.Entities.Product", "Product")
                        .WithMany("ProductImgs")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Intern.Entities.Sales", b =>
                {
                    b.HasOne("Intern.Entities.SalesStatus", "SalesStatus")
                        .WithMany("Sales")
                        .HasForeignKey("SalesStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intern.Entities.SalesType", "SalesType")
                        .WithMany("Sales")
                        .HasForeignKey("SalesTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SalesStatus");

                    b.Navigation("SalesType");
                });

            modelBuilder.Entity("Intern.Entities.VoteStar", b =>
                {
                    b.HasOne("Intern.Entities.Account", "Account")
                        .WithMany("VoteStars")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intern.Entities.Product", "Product")
                        .WithMany("VoteStars")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Intern.Entities.Account", b =>
                {
                    b.Navigation("AccountBags");

                    b.Navigation("AccountShipContacts");

                    b.Navigation("Bills");

                    b.Navigation("VoteStars");
                });

            modelBuilder.Entity("Intern.Entities.AccountShipContact", b =>
                {
                    b.Navigation("Bill")
                        .IsRequired();
                });

            modelBuilder.Entity("Intern.Entities.AccountShipContactStatus", b =>
                {
                    b.Navigation("AccountShipContacts");
                });

            modelBuilder.Entity("Intern.Entities.AccountStatus", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("Intern.Entities.Bill", b =>
                {
                    b.Navigation("BillDetail");

                    b.Navigation("BillSales");
                });

            modelBuilder.Entity("Intern.Entities.BillStatus", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("Intern.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Intern.Entities.BuyMethod", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("Intern.Entities.CategoryType", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Intern.Entities.Color", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Intern.Entities.Producer", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Intern.Entities.Product", b =>
                {
                    b.Navigation("AccountBags");

                    b.Navigation("BillDetails");

                    b.Navigation("ProductImgs");

                    b.Navigation("VoteStars");
                });

            modelBuilder.Entity("Intern.Entities.ProductStatus", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Intern.Entities.Role", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("Intern.Entities.Sales", b =>
                {
                    b.Navigation("BillSales");
                });

            modelBuilder.Entity("Intern.Entities.SalesStatus", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("Intern.Entities.SalesType", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("Intern.Entities.ShipMethod", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("Intern.Entities.Size", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
