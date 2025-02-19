﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApplication2.Models;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20211215164028_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("WebApplication2.Models.Product", b =>
                {
                    b.Property<string>("barcode")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("weight")
                        .HasColumnType("text");

                    b.HasKey("barcode");

                    b.ToTable("products");
                });

            modelBuilder.Entity("WebApplication2.Models.ProductSeries", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ProductId")
                        .HasColumnType("text");

                    b.Property<int?>("SellerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("buyTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<float?>("cost")
                        .HasColumnType("real");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<float?>("price")
                        .HasColumnType("real");

                    b.Property<int>("quantity")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SellerId");

                    b.ToTable("productSeries");
                });

            modelBuilder.Entity("WebApplication2.Models.Sale", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("SaleId")
                        .HasColumnType("integer");

                    b.Property<int>("price")
                        .HasColumnType("integer");

                    b.Property<int>("quntity")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("SaleId");

                    b.ToTable("sales");
                });

            modelBuilder.Entity("WebApplication2.Models.Seller", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("address")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("sellers");
                });

            modelBuilder.Entity("WebApplication2.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .HasColumnType("text");

                    b.Property<int>("role")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("WebApplication2.Models.ProductSeries", b =>
                {
                    b.HasOne("WebApplication2.Models.Product", "product")
                        .WithMany("productSeries")
                        .HasForeignKey("ProductId");

                    b.HasOne("WebApplication2.Models.Seller", "seller")
                        .WithMany("productSeries")
                        .HasForeignKey("SellerId");

                    b.Navigation("product");

                    b.Navigation("seller");
                });

            modelBuilder.Entity("WebApplication2.Models.Sale", b =>
                {
                    b.HasOne("WebApplication2.Models.ProductSeries", "productSeries")
                        .WithMany("sales")
                        .HasForeignKey("SaleId");

                    b.Navigation("productSeries");
                });

            modelBuilder.Entity("WebApplication2.Models.Product", b =>
                {
                    b.Navigation("productSeries");
                });

            modelBuilder.Entity("WebApplication2.Models.ProductSeries", b =>
                {
                    b.Navigation("sales");
                });

            modelBuilder.Entity("WebApplication2.Models.Seller", b =>
                {
                    b.Navigation("productSeries");
                });
#pragma warning restore 612, 618
        }
    }
}
