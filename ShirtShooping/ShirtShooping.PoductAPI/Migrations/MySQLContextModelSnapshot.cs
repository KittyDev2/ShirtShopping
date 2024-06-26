﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShirtShooping.PoductAPI.Model.Context;

#nullable disable

namespace ShirtShooping.PoductAPI.Migrations
{
    [DbContext(typeof(MySQLContext))]
    partial class MySQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ShirtShooping.PoductAPI.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("product");

                    b.HasData(
                        new
                        {
                            Id = 2L,
                            CategoryName = "Football T-Shirt",
                            Description = "Camisa São Paulo Oficial - XG",
                            ImageUrl = "https://github.com/KittyDev2/ShirtShopping/blob/master/ShoppingImages/S%C3%A3o-Paulo-FC.jpg?raw=true",
                            Name = "Camisa São Paulo",
                            Price = 120.9m
                        },
                        new
                        {
                            Id = 3L,
                            CategoryName = "Football T-Shirt",
                            Description = "Camisa Corinthians Oficial - XG",
                            ImageUrl = "https://github.com/KittyDev2/ShirtShopping/blob/master/ShoppingImages/Corinthians-FC.jpg?raw=true",
                            Name = "Camisa Corinthians",
                            Price = 120.9m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryName = "Football T-Shirt",
                            Description = "Camisa Santos Oficial - XG",
                            ImageUrl = "https://github.com/KittyDev2/ShirtShopping/blob/master/ShoppingImages/Santos-FC.jpeg?raw=true",
                            Name = "Camisa Santos",
                            Price = 120.9m
                        },
                        new
                        {
                            Id = 5L,
                            CategoryName = "Football T-Shirt",
                            Description = "Camisa Flamengo Oficial - XG",
                            ImageUrl = "https://github.com/KittyDev2/ShirtShopping/blob/master/ShoppingImages/Flamengo-FC.jpg?raw=true",
                            Name = "Camisa Flamengo",
                            Price = 120.9m
                        },
                        new
                        {
                            Id = 6L,
                            CategoryName = "Football T-Shirt",
                            Description = "Camisa Cruzeiro Oficial - XG",
                            ImageUrl = "https://github.com/KittyDev2/ShirtShopping/blob/master/ShoppingImages/Cruzeiro-FC.jpg?raw=true",
                            Name = "Camisa Cruzeiro",
                            Price = 120.9m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
