﻿// <auto-generated />
using BlazorApp1.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220715062047_ProductSeeding")]
    partial class ProductSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorApp1.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "kmzkmzkmzkzmkzmkzmkz",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/5e/Domestic_Cat_Face_Shot.jpg",
                            Price = 9.99m,
                            Title = "Hithicker's Guide to GALAZZY"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Ready play sefnefnef",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4f/Felis_silvestris_catus_lying_on_rice_straw.jpg",
                            Price = 7.99m,
                            Title = "Bucin KKKKmz"
                        },
                        new
                        {
                            Id = 3,
                            Description = "HJHHjasjdajs",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/bb/Kittyply_edit1.jpg",
                            Price = 19.99m,
                            Title = "Konto konto Neonn KssssI"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
