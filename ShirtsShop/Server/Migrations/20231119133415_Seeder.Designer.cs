﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShirtsShop.Server.Data;

namespace ShirtsShop.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231119133415_Seeder")]
    partial class Seeder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShirtsShop.Shared.Shirt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SizeId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SizeId");

                    b.ToTable("Shirts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Black",
                            SizeId = 2,
                            Text = "Long"
                        },
                        new
                        {
                            Id = 2,
                            Color = "White",
                            SizeId = 4,
                            Text = "Live"
                        });
                });

            modelBuilder.Entity("ShirtsShop.Shared.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "XS"
                        },
                        new
                        {
                            Id = 2,
                            Name = "S"
                        },
                        new
                        {
                            Id = 3,
                            Name = "XM"
                        },
                        new
                        {
                            Id = 4,
                            Name = "M"
                        },
                        new
                        {
                            Id = 5,
                            Name = "L"
                        },
                        new
                        {
                            Id = 6,
                            Name = "XL"
                        },
                        new
                        {
                            Id = 7,
                            Name = "XXL"
                        },
                        new
                        {
                            Id = 8,
                            Name = "XXXL"
                        },
                        new
                        {
                            Id = 9,
                            Name = "XXXXL"
                        });
                });

            modelBuilder.Entity("ShirtsShop.Shared.Shirt", b =>
                {
                    b.HasOne("ShirtsShop.Shared.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Size");
                });
#pragma warning restore 612, 618
        }
    }
}