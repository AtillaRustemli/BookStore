﻿// <auto-generated />
using System;
using CodeAcademy_Final_Project.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeAcademy_Final_Project.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231223175426_addedSettingKeyValueTable")]
    partial class addedSettingKeyValueTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mir Celal"
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.AuthorBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
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

                    b.ToTable("AuthorBook");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            BookId = 1
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Book", b =>
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

                    b.Property<long?>("PopularityCount")
                        .HasColumnType("bigint");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("PromotionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Released")
                        .HasColumnType("datetime2");

                    b.Property<long?>("SellCount")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("PromotionId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "This is book's description and there is nothing but description so good luck)",
                            ImgUrl = "book-example4.jpg",
                            LanguageId = 1,
                            Name = "Talk to the Heart",
                            Price = 1.0,
                            PromotionId = 1,
                            Released = new DateTime(2023, 12, 23, 21, 54, 25, 549, DateTimeKind.Local).AddTicks(1944)
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.BookBType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BTypeId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BTypeId");

                    b.HasIndex("BookId");

                    b.ToTable("BookBType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BTypeId = 1,
                            BookId = 1
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.BookGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BookId")
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
                            Name = "BestSeller"
                        });
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Genre", b =>
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

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = 1,
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
                            ImgUrl = "promotion-image1.jpg",
                            Name = "New Year Discount",
                            Title = "Amasing new year discount"
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

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.AuthorBook", b =>
                {
                    b.HasOne("CodeAcademy_Final_Project.Models.Author", "Author")
                        .WithMany("AuthorBook")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy_Final_Project.Models.Book", "Book")
                        .WithMany("AuthorBook")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Book", b =>
                {
                    b.HasOne("CodeAcademy_Final_Project.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy_Final_Project.Models.Language", "Language")
                        .WithMany("Books")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy_Final_Project.Models.Promotion", "Promotion")
                        .WithMany("Books")
                        .HasForeignKey("PromotionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Language");

                    b.Navigation("Promotion");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.BookBType", b =>
                {
                    b.HasOne("CodeAcademy_Final_Project.Models.BType", "BType")
                        .WithMany("BookType")
                        .HasForeignKey("BTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy_Final_Project.Models.Book", "Book")
                        .WithMany("BookType")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BType");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.BookGenre", b =>
                {
                    b.HasOne("CodeAcademy_Final_Project.Models.Book", "Book")
                        .WithMany("BookGenre")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy_Final_Project.Models.Genre", "Genre")
                        .WithMany("BookGenre")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Author", b =>
                {
                    b.Navigation("AuthorBook");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Book", b =>
                {
                    b.Navigation("AuthorBook");

                    b.Navigation("BookGenre");

                    b.Navigation("BookType");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.BType", b =>
                {
                    b.Navigation("BookType");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Genre", b =>
                {
                    b.Navigation("BookGenre");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Language", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("CodeAcademy_Final_Project.Models.Promotion", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
