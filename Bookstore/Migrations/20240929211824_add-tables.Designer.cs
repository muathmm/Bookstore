﻿// <auto-generated />
using Bookstore.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bookstore.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20240929211824_add-tables")]
    partial class addtables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bookstore.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Author = "Harper Lee",
                            Genre = "Fiction",
                            Price = 15.99m,
                            Title = "To Kill a Mockingbird"
                        },
                        new
                        {
                            BookId = 2,
                            Author = "George Orwell",
                            Genre = "Dystopian",
                            Price = 12.99m,
                            Title = "1984"
                        },
                        new
                        {
                            BookId = 3,
                            Author = "F. Scott Fitzgerald",
                            Genre = "Classic",
                            Price = 10.99m,
                            Title = "The Great Gatsby"
                        },
                        new
                        {
                            BookId = 4,
                            Author = "J.R.R. Tolkien",
                            Genre = "Fantasy",
                            Price = 25.99m,
                            Title = "The Hobbit"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
