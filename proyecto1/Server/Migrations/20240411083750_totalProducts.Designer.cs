﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proyecto1.Server.Data;

#nullable disable

namespace proyecto1.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240411083750_totalProducts")]
    partial class totalProducts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("proyecto1.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Square Cubes",
                            Url = "square-cubes"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Triangular Cubes",
                            Url = "triangular-cubes"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Special cubes",
                            Url = "special-cubes"
                        });
                });

            modelBuilder.Entity("proyecto1.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "The Rubik's Cube is a three-dimensional mechanical puzzle created by Hungarian sculptor and architecture professor Ernő Rubik in 1974.",
                            Image = "./media/cubo1.png",
                            Price = 9.99m,
                            Title = "Classic Rubik's Cube"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "The Pyraminx is a mechanical puzzle shaped like a tetrahedron similar to a Rubik's cube. It was invented by Uwe Meffert in 1970.",
                            Image = "./media/cubo2.jpg",
                            Price = 7.99m,
                            Title = "Pyraminx"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "The Skewb is a three-dimensional mechanical puzzle like a Rubik's cube, made up of pieces that can rotate and change position.",
                            Image = "./media/cubo3.jpg",
                            Price = 9.99m,
                            Title = "Skewb"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Description = "The Megaminx, or \"Magic Dodecahedron\", was invented by several people simultaneously and produced by different manufacturing companies with slightly different designs.\r\nThe Megaminx has the shape of a dodecahedron, it has 12 central pieces, one on each face; 20 corners and 30 edges.",
                            Image = "./media/cubo4.jpg",
                            Price = 20.99m,
                            Title = "Megaminx"
                        });
                });

            modelBuilder.Entity("proyecto1.Shared.Product", b =>
                {
                    b.HasOne("proyecto1.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}