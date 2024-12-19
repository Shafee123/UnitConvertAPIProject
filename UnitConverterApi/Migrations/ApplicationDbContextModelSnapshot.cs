﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UnitConverterApi.Models;

#nullable disable

namespace UnitConverterApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UnitConverterApi.Models.ConversionHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ConversionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FromUnitId")
                        .HasColumnType("int");

                    b.Property<double>("FromValue")
                        .HasColumnType("float");

                    b.Property<int>("ToUnitId")
                        .HasColumnType("int");

                    b.Property<double>("ToValue")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("ConversionHistories");
                });

            modelBuilder.Entity("UnitConverterApi.Models.ConversionRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FromUnitId")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("ToUnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ConversionRates");
                });

            modelBuilder.Entity("UnitConverterApi.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnitCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnitCategoryId");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("UnitConverterApi.Models.UnitCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UnitCategories");
                });

            modelBuilder.Entity("UnitConverterApi.Models.Unit", b =>
                {
                    b.HasOne("UnitConverterApi.Models.UnitCategory", "UnitCategory")
                        .WithMany("Units")
                        .HasForeignKey("UnitCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UnitCategory");
                });

            modelBuilder.Entity("UnitConverterApi.Models.UnitCategory", b =>
                {
                    b.Navigation("Units");
                });
#pragma warning restore 612, 618
        }
    }
}