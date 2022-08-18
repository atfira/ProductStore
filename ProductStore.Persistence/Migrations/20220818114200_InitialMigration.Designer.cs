﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductStore.Persistence;

#nullable disable

namespace ProductStore.Persistence.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20220818114200_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.7.22376.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductStore.Domain.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = new Guid("efbce6fb-3a20-487a-8983-10de14206ad7"),
                            Name = "Detectors and Sensors"
                        });
                });

            modelBuilder.Entity("ProductStore.Domain.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Desciption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0b832726-8ed7-46ef-8fbc-39c5904d7f5d"),
                            CategoryId = new Guid("efbce6fb-3a20-487a-8983-10de14206ad7"),
                            Desciption = "At the first signs of leaks, freezes, or excess humidity, the Wi-Fi Water Leak & Freeze Detector can alert your smartphone.\r\nNotification includes mobile & audible alerts – messages can alert you or your family/friends wherever you are, while audible alerts sound when you are at home.\r\nConnects to standard Home Wi-Fi directly – no need for an extra hub.\r\nTemperature & humidity sensing – Detect low temperatures that can lead to frozen pipes, and humidity that could damage valuables.",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51xitGzq7pL.__AC_SX300_SY300_QL70_FMwebp_.jpg",
                            Name = "Resideo RCHW3610WF1001/N Wi-Fi Water Leak Detector"
                        });
                });

            modelBuilder.Entity("ProductStore.Domain.Product", b =>
                {
                    b.HasOne("ProductStore.Domain.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ProductStore.Domain.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
