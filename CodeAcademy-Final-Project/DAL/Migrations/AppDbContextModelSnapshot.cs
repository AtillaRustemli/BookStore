﻿
using System;
using CodeAcademy_Final_Project.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeAcademy_Final_Project.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ABook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Narrator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PopularityCount")
                        .HasColumnType("bigint");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("PromotionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Released")
                        .HasColumnType("datetime2");

                    b.Property<long?>("SellCount")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("WishListId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BTypeId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("PromotionId");

                    b.HasIndex("WishListId");

                    b.ToTable("ABooks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BTypeId = 3,
                            Description = "This is book's description and there is nothing but description so good luck)",
                            ImgUrl = "book-example4.jpg",
                            LanguageId = 1,
                            Name = "Talk to the Heart",
                            Narrator = "Atilla",
                            PopularityCount = 0L,
                            Price = 11.0,
                            PromotionId = 1,

                            Released = new DateTime(2024, 2, 7, 22, 33, 7, 258, DateTimeKind.Local).AddTicks(8095),

                            Released = new DateTime(2024, 1, 7, 23, 32, 6, 552, DateTimeKind.Local).AddTicks(2241),

                            SellCount = 0L
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ABookChapter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ABookId")
                        .HasColumnType("int");

                    b.Property<string>("ABookUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ABookId");

                    b.ToTable("ABookChapter");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ABookId = 1,
                            ABookUrl = "Chapter1-audiobook.m4a"
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("SocialMediaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SocialMediaId")
                        .IsUnique();

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mir Celal",
                            SocialMediaId = 1
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ABookId")
                        .HasColumnType("int");

                    b.Property<int>("BTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EBookId")
                        .HasColumnType("int");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("PageCount")
                        .HasColumnType("int");

                    b.Property<long?>("PopularityCount")
                        .HasColumnType("bigint");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("PromotionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Released")
                        .HasColumnType("datetime2");

                    b.Property<long?>("SellCount")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.Property<int?>("WishListId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ABookId")
                        .IsUnique()
                        .HasFilter("[ABookId] IS NOT NULL");

                    b.HasIndex("BTypeId");

                    b.HasIndex("EBookId")
                        .IsUnique()
                        .HasFilter("[EBookId] IS NOT NULL");

                    b.HasIndex("LanguageId");

                    b.HasIndex("PromotionId");

                    b.HasIndex("WishListId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ABookId = 1,
                            BTypeId = 1,
                            Description = "This is book's description and there is nothing but description so good luck)",
                            EBookId = 1,
                            Height = 5.4000000000000004,
                            ImgUrl = "book-example4.jpg",
                            LanguageId = 1,
                            Length = 20.300000000000001,
                            Name = "Talk to the Heart",
                            PageCount = 304,
                            PopularityCount = 0L,
                            Price = 11.0,
                            PromotionId = 1,

                            Released = new DateTime(2024, 2, 7, 22, 33, 7, 258, DateTimeKind.Local).AddTicks(9081),

                            Released = new DateTime(2024, 1, 7, 23, 32, 6, 552, DateTimeKind.Local).AddTicks(3020),

                            SellCount = 0L,
                            Width = 15.1
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.BType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Book"
                        },
                        new
                        {
                            Id = 2,
                            Name = "eBook"
                        },
                        new
                        {
                            Id = 3,
                            Name = "aBook"
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Fiction"
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.EBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ABookId")
                        .HasColumnType("int");

                    b.Property<int>("BTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EBookUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<long?>("PopularityCount")
                        .HasColumnType("bigint");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("PromotionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Released")
                        .HasColumnType("datetime2");

                    b.Property<long?>("SellCount")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("WishListId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ABookId")
                        .IsUnique()
                        .HasFilter("[ABookId] IS NOT NULL");

                    b.HasIndex("BTypeId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("PromotionId");

                    b.HasIndex("WishListId");

                    b.ToTable("EBooks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ABookId = 1,
                            BTypeId = 2,
                            Description = "This is book's description and there is nothing but description so good luck)",
                            EBookUrl = "ardino.pdf",
                            ImgUrl = "book-example4.jpg",
                            LanguageId = 1,
                            Name = "Talk to the Heart",
                            PopularityCount = 0L,
                            Price = 11.0,
                            PromotionId = 1,

                            Released = new DateTime(2024, 2, 7, 22, 33, 7, 258, DateTimeKind.Local).AddTicks(9952),

                            Released = new DateTime(2024, 1, 7, 23, 32, 6, 552, DateTimeKind.Local).AddTicks(3673),

                            SellCount = 0L
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "Fanatsy"
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Azerbaijany"
                        },
                        new
                        {
                            Id = 2,
                            Name = "English"
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Promotion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DetailImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Promotions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Look at our fantasting promotion.This is amasing!!!",
                            DetailImageUrl = "promotion-detail1.jpg",

                            EndTime = new DateTime(2024, 2, 7, 22, 33, 7, 259, DateTimeKind.Local).AddTicks(476),

                            EndTime = new DateTime(2024, 1, 7, 23, 32, 6, 552, DateTimeKind.Local).AddTicks(4219),

                            ImgUrl = "promotion-image1.jpg",
                            Name = "New Year Discount",
                            Title = "Amasing new year discount"
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ReletionTables.ABookAuthor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ABookId")
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ABookId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("GenreId");

                    b.ToTable("ABookAuthor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ABookId = 1,
                            AuthorId = 1
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ReletionTables.ABookCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ABookId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ABookId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ABookBCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ABookId = 1,
                            CategoryId = 1
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ReletionTables.ABookGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ABookId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ABookId");

                    b.HasIndex("GenreId");

                    b.ToTable("ABookGenre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ABookId = 1,
                            GenreId = 1
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ReletionTables.BookAuthor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("BookAuthor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            BookId = 1
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ReletionTables.BookCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CategoryId");

                    b.ToTable("BookCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            CategoryId = 1
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ReletionTables.BookGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("GenreId");

                    b.ToTable("BookGenre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            GenreId = 1
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ReletionTables.EBookAuthor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("EBookId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("EBookId");

                    b.ToTable("EBookAuthor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            EBookId = 1
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ReletionTables.EBookCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("EBookId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EBookId");

                    b.ToTable("EBookBaseCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            EBookId = 1
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ReletionTables.EBookGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("EBookId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EBookId");

                    b.HasIndex("GenreId");

                    b.ToTable("EBookGenre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EBookId = 1,
                            GenreId = 1
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.SettingKeyValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SettingKeyValue");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Key = "Number",
                            Value = "+612 9045 4394"
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.SocialMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pinterest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Twitter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SocialMedias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Facebook = "https://www.facebook.com/",
                            Pinterest = "https://www.pinterest.com/",
                            Twitter = "https://twitter.com/"
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.WishList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AppUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsMain")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsPrivate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("WishLists");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {

                            Id = "e8bba3b5-ab94-4dd6-bd93-85d02cbcde86",
                            ConcurrencyStamp = "30438e5d-2fcc-45be-971d-be48faced5f8",

                            Id = "b5baa6d3-0d99-40a7-bd92-c5d497b66119",
                            ConcurrencyStamp = "b4c7c7d5-eb78-448b-ba70-e5839750a0b0",

                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {

                            Id = "931ac004-2d84-43be-b84e-122853f6cf4a",
                            ConcurrencyStamp = "56497b4f-e5ff-42b4-a8db-0024656e05f6",

                            Id = "78345004-8a73-43b6-b46a-68434dde6d08",
                            ConcurrencyStamp = "6ed4d670-7c47-4797-a81a-607e7c215c61",

                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {

                            Id = "1b2caf5e-e162-4cd8-9779-71b540879b2d",
                            ConcurrencyStamp = "1445d481-4eb9-424d-b50e-fc88649b40de",

                            Id = "692625ce-a64e-4b7f-94d0-0ab714047f87",
                            ConcurrencyStamp = "e78f2076-e67d-4e0d-925b-a65ecf88c155",

                            Name = "Member",
                            NormalizedName = "MEMBER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AppUser");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ABook", b =>
                {
                    b.HasOne("CodeAcademy_Final_Project.Models.BType", "BType")
                        .WithMany()
                        .HasForeignKey("BTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy_Final_Project.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy_Final_Project.Models.Promotion", "Promotion")
                        .WithMany()
                        .HasForeignKey("PromotionId");

                    b.HasOne("CodeAcademy_Final_Project.Models.WishList", "WishList")
                        .WithMany("ABooks")
                        .HasForeignKey("WishListId");

                    b.Navigation("BType");

                    b.Navigation("Language");

                    b.Navigation("Promotion");

                    b.Navigation("WishList");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ABookChapter", b =>
                {
                    b.HasOne("CodeAcademy_Final_Project.Models.ABook", "ABook")
                        .WithMany("ABookChapters")
                        .HasForeignKey("ABookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ABook");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Author", b =>
                {
                    b.HasOne("CodeAcademy_Final_Project.Models.SocialMedia", "SocialMedia")
                        .WithOne("Author")
                        .HasForeignKey("CodeAcademy_Final_Project.Models.Author", "SocialMediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SocialMedia");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Book", b =>
                {
                    b.HasOne("CodeAcademy_Final_Project.Models.ABook", "ABook")
                        .WithOne("Book")
                        .HasForeignKey("CodeAcademy_Final_Project.Models.Book", "ABookId");

                    b.HasOne("CodeAcademy_Final_Project.Models.BType", "BType")
                        .WithMany("Books")
                        .HasForeignKey("BTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy_Final_Project.Models.EBook", "EBook")
                        .WithOne("Book")
                        .HasForeignKey("CodeAcademy_Final_Project.Models.Book", "EBookId");

                    b.HasOne("CodeAcademy_Final_Project.Models.Language", "Language")
                        .WithMany("Books")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy_Final_Project.Models.Promotion", "Promotion")
                        .WithMany("Books")
                        .HasForeignKey("PromotionId");

                    b.HasOne("CodeAcademy_Final_Project.Models.WishList", "WishList")
                        .WithMany("Books")
                        .HasForeignKey("WishListId");

                    b.Navigation("ABook");

                    b.Navigation("BType");

                    b.Navigation("EBook");

                    b.Navigation("Language");

                    b.Navigation("Promotion");

                    b.Navigation("WishList");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.EBook", b =>
                {
                    b.HasOne("CodeAcademy_Final_Project.Models.ABook", "ABook")
                        .WithOne("EBook")
                        .HasForeignKey("CodeAcademy_Final_Project.Models.EBook", "ABookId");

                    b.HasOne("CodeAcademy_Final_Project.Models.BType", "BType")
                        .WithMany()
                        .HasForeignKey("BTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy_Final_Project.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy_Final_Project.Models.Promotion", "Promotion")
                        .WithMany()
                        .HasForeignKey("PromotionId");

                    b.HasOne("CodeAcademy_Final_Project.Models.WishList", "WishList")
                        .WithMany("EBooks")
                        .HasForeignKey("WishListId");

                    b.Navigation("ABook");

                    b.Navigation("BType");

                    b.Navigation("Language");

                    b.Navigation("Promotion");

                    b.Navigation("WishList");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Genre", b =>
                {
                    b.HasOne("CodeAcademy_Final_Project.Models.Category", "Category")
                        .WithMany("Genres")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ReletionTables.ABookAuthor", b =>
                {
                    b.HasOne("CodeAcademy_Final_Project.Models.ABook", "ABook")
                        .WithMany("ABookAuthor")
                        .HasForeignKey("ABookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy_Final_Project.Models.Author", "Author")
                        .WithMany("ABookAuthor")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy_Final_Project.Models.Genre", null)
                        .WithMany("ABookAuthor")
                        .HasForeignKey("GenreId");

                    b.Navigation("ABook");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ReletionTables.ABookCategory", b =>
                {
                    b.HasOne("CodeAcademy_Final_Project.Models.ABook", "ABook")
                        .WithMany("ABookCategory")
                        .HasForeignKey("ABookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy_Final_Project.Models.Category", "Category")
                        .WithMany("ABookCategory")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ABook");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ReletionTables.ABookGenre", b =>
                {
                    b.HasOne("CodeAcademy_Final_Project.Models.ABook", "ABook")
                        .WithMany("ABookGenre")
                        .HasForeignKey("ABookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy_Final_Project.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ABook");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ReletionTables.BookAuthor", b =>
                {
                    b.HasOne("CodeAcademy_Final_Project.Models.Author", "Author")
                        .WithMany("BookBaseAuthor")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy_Final_Project.Models.Book", "Book")
                        .WithMany("BookAuthor")
                        .HasForeignKey("BookId");

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ReletionTables.BookCategory", b =>
                {
                    b.HasOne("CodeAcademy_Final_Project.Models.Book", "Book")
                        .WithMany("BookCategory")
                        .HasForeignKey("BookId");

                    b.HasOne("CodeAcademy_Final_Project.Models.Category", "Category")
                        .WithMany("BookBaseCategory")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ReletionTables.BookGenre", b =>
                {
                    b.HasOne("CodeAcademy_Final_Project.Models.Book", "Book")
                        .WithMany("BookGenre")
                        .HasForeignKey("BookId");

                    b.HasOne("CodeAcademy_Final_Project.Models.Genre", "Genre")
                        .WithMany("BookBaseGenre")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ReletionTables.EBookAuthor", b =>
                {
                    b.HasOne("CodeAcademy_Final_Project.Models.Author", "Author")
                        .WithMany("EBookAuthor")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy_Final_Project.Models.EBook", "EBook")
                        .WithMany("EBookAuthor")
                        .HasForeignKey("EBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("EBook");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ReletionTables.EBookCategory", b =>
                {
                    b.HasOne("CodeAcademy_Final_Project.Models.Category", "Category")
                        .WithMany("EBookCategory")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy_Final_Project.Models.EBook", "EBook")
                        .WithMany("EBookCategory")
                        .HasForeignKey("EBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("EBook");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ReletionTables.EBookGenre", b =>
                {
                    b.HasOne("CodeAcademy_Final_Project.Models.EBook", "EBook")
                        .WithMany("EBookGenre")
                        .HasForeignKey("EBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy_Final_Project.Models.Genre", "Genre")
                        .WithMany("EBookGenre")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EBook");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.WishList", b =>
                {
                    b.HasOne("CodeAcademy_Final_Project.Models.AppUser", "AppUser")
                        .WithMany("WishLists")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.ABook", b =>
                {
                    b.Navigation("ABookAuthor");

                    b.Navigation("ABookCategory");

                    b.Navigation("ABookChapters");

                    b.Navigation("ABookGenre");

                    b.Navigation("Book")
                        .IsRequired();

                    b.Navigation("EBook")
                        .IsRequired();
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Author", b =>
                {
                    b.Navigation("ABookAuthor");

                    b.Navigation("BookBaseAuthor");

                    b.Navigation("EBookAuthor");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Book", b =>
                {
                    b.Navigation("BookAuthor");

                    b.Navigation("BookCategory");

                    b.Navigation("BookGenre");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.BType", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Category", b =>
                {
                    b.Navigation("ABookCategory");

                    b.Navigation("BookBaseCategory");

                    b.Navigation("EBookCategory");

                    b.Navigation("Genres");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.EBook", b =>
                {
                    b.Navigation("Book")
                        .IsRequired();

                    b.Navigation("EBookAuthor");

                    b.Navigation("EBookCategory");

                    b.Navigation("EBookGenre");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Genre", b =>
                {
                    b.Navigation("ABookAuthor");

                    b.Navigation("BookBaseGenre");

                    b.Navigation("EBookGenre");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Language", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Promotion", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.SocialMedia", b =>
                {
                    b.Navigation("Author")
                        .IsRequired();
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.WishList", b =>
                {
                    b.Navigation("ABooks");

                    b.Navigation("Books");

                    b.Navigation("EBooks");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.AppUser", b =>
                {
                    b.Navigation("WishLists");
                });
#pragma warning restore 612, 618
        }
    }
}
