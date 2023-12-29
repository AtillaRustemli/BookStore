using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeAcademy_Final_Project.DAL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SettingKeyValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettingKeyValue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pinterest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genre_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ABooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Narrator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Released = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PopularityCount = table.Column<long>(type: "bigint", nullable: true),
                    SellCount = table.Column<long>(type: "bigint", nullable: true),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BTypeId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    PromotionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ABooks_BTypes_BTypeId",
                        column: x => x.BTypeId,
                        principalTable: "BTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ABooks_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ABooks_Promotions_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "Promotions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Released = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PopularityCount = table.Column<long>(type: "bigint", nullable: true),
                    SellCount = table.Column<long>(type: "bigint", nullable: true),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BTypeId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    PromotionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_BTypes_BTypeId",
                        column: x => x.BTypeId,
                        principalTable: "BTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Promotions_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "Promotions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EBookUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Released = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PopularityCount = table.Column<long>(type: "bigint", nullable: true),
                    SellCount = table.Column<long>(type: "bigint", nullable: true),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BTypeId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    PromotionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EBooks_BTypes_BTypeId",
                        column: x => x.BTypeId,
                        principalTable: "BTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EBooks_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EBooks_Promotions_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "Promotions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ABookChapter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ABookUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ABookId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABookChapter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ABookChapter_ABooks_ABookId",
                        column: x => x.ABookId,
                        principalTable: "ABooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookBaseAuthor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookBaseId = table.Column<int>(type: "int", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    ABookId = table.Column<int>(type: "int", nullable: true),
                    AuthorId1 = table.Column<int>(type: "int", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: true),
                    EBookId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookBaseAuthor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookBaseAuthor_ABooks_ABookId",
                        column: x => x.ABookId,
                        principalTable: "ABooks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookBaseAuthor_ABooks_BookBaseId",
                        column: x => x.BookBaseId,
                        principalTable: "ABooks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookBaseAuthor_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookBaseAuthor_Author_AuthorId1",
                        column: x => x.AuthorId1,
                        principalTable: "Author",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookBaseAuthor_Book_BookBaseId",
                        column: x => x.BookBaseId,
                        principalTable: "Book",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookBaseAuthor_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookBaseAuthor_EBooks_BookBaseId",
                        column: x => x.BookBaseId,
                        principalTable: "EBooks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookBaseAuthor_EBooks_EBookId",
                        column: x => x.EBookId,
                        principalTable: "EBooks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookBaseCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookBaseId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    ABookId = table.Column<int>(type: "int", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: true),
                    CategoryId1 = table.Column<int>(type: "int", nullable: true),
                    EBookId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookBaseCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookBaseCategory_ABooks_ABookId",
                        column: x => x.ABookId,
                        principalTable: "ABooks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookBaseCategory_ABooks_BookBaseId",
                        column: x => x.BookBaseId,
                        principalTable: "ABooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookBaseCategory_Book_BookBaseId",
                        column: x => x.BookBaseId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookBaseCategory_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookBaseCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookBaseCategory_Categories_CategoryId1",
                        column: x => x.CategoryId1,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookBaseCategory_EBooks_BookBaseId",
                        column: x => x.BookBaseId,
                        principalTable: "EBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookBaseCategory_EBooks_EBookId",
                        column: x => x.EBookId,
                        principalTable: "EBooks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookBaseGenre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookBaseId = table.Column<int>(type: "int", nullable: true),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    ABookId = table.Column<int>(type: "int", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: true),
                    EBookId = table.Column<int>(type: "int", nullable: true),
                    GenreId1 = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookBaseGenre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookBaseGenre_ABooks_ABookId",
                        column: x => x.ABookId,
                        principalTable: "ABooks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookBaseGenre_ABooks_BookBaseId",
                        column: x => x.BookBaseId,
                        principalTable: "ABooks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookBaseGenre_Book_BookBaseId",
                        column: x => x.BookBaseId,
                        principalTable: "Book",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookBaseGenre_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookBaseGenre_EBooks_BookBaseId",
                        column: x => x.BookBaseId,
                        principalTable: "EBooks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookBaseGenre_EBooks_EBookId",
                        column: x => x.EBookId,
                        principalTable: "EBooks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookBaseGenre_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookBaseGenre_Genre_GenreId1",
                        column: x => x.GenreId1,
                        principalTable: "Genre",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[] { 1, null, null, "Mir Celal", null });

            migrationBuilder.InsertData(
                table: "BTypes",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, null, "Book", null },
                    { 2, null, null, "eBook", null },
                    { 3, null, null, "aBook", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[] { 1, null, null, "Fiction", null });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, null, "Azerbaijany", null },
                    { 2, null, null, "English", null }
                });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "DetailImageUrl", "EndTime", "ImgUrl", "Name", "Title", "UpdatedAt" },
                values: new object[] { 1, null, null, "Look at our fantasting promotion.This is amasing!!!", "promotion-detail1.jpg", new DateTime(2023, 12, 29, 22, 20, 44, 408, DateTimeKind.Local).AddTicks(3083), "promotion-image1.jpg", "New Year Discount", "Amasing new year discount", null });

            migrationBuilder.InsertData(
                table: "SettingKeyValue",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Key", "UpdatedAt", "Value" },
                values: new object[] { 1, null, null, "Number", null, "+612 9045 4394" });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Facebook", "Pinterest", "Twitter", "UpdatedAt" },
                values: new object[] { 1, null, null, "https://www.facebook.com/", "https://www.pinterest.com/", "https://twitter.com/", null });

            migrationBuilder.InsertData(
                table: "ABooks",
                columns: new[] { "Id", "BTypeId", "CreatedAt", "DeletedAt", "Description", "ImgUrl", "LanguageId", "Name", "Narrator", "PopularityCount", "Price", "PromotionId", "Released", "SellCount", "UpdatedAt" },
                values: new object[] { 1, 2, null, null, "This is book's description and there is nothing but description so good luck)", "book-example4.jpg", 1, "Talk to the Heart", "Atilla", 0L, 11.0, 1, new DateTime(2023, 12, 29, 22, 20, 44, 408, DateTimeKind.Local).AddTicks(1423), 0L, null });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "BTypeId", "CreatedAt", "DeletedAt", "Description", "ImgUrl", "LanguageId", "Name", "PopularityCount", "Price", "PromotionId", "Released", "SellCount", "UpdatedAt" },
                values: new object[] { 1, 1, null, null, "This is book's description and there is nothing but description so good luck)", "book-example4.jpg", 1, "Talk to the Heart", 0L, 11.0, 1, new DateTime(2023, 12, 29, 22, 20, 44, 408, DateTimeKind.Local).AddTicks(1978), 0L, null });

            migrationBuilder.InsertData(
                table: "EBooks",
                columns: new[] { "Id", "BTypeId", "CreatedAt", "DeletedAt", "Description", "EBookUrl", "ImgUrl", "LanguageId", "Name", "PopularityCount", "Price", "PromotionId", "Released", "SellCount", "UpdatedAt" },
                values: new object[] { 1, 2, null, null, "This is book's description and there is nothing but description so good luck)", "ardino.pdf", "book-example4.jpg", 1, "Talk to the Heart", 0L, 11.0, 1, new DateTime(2023, 12, 29, 22, 20, 44, 408, DateTimeKind.Local).AddTicks(2553), 0L, null });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[] { 1, 1, null, null, "Fanatsy", null });

            migrationBuilder.InsertData(
                table: "ABookChapter",
                columns: new[] { "Id", "ABookId", "ABookUrl", "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { 1, 1, "", null, null, null });

            migrationBuilder.InsertData(
                table: "BookBaseAuthor",
                columns: new[] { "Id", "ABookId", "AuthorId", "AuthorId1", "BookBaseId", "BookId", "CreatedAt", "DeletedAt", "EBookId", "TypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, 1, null, 1, null, null, null, null, 1, null },
                    { 2, null, 1, null, 1, null, null, null, null, 2, null },
                    { 3, null, 1, null, 1, null, null, null, null, 3, null }
                });

            migrationBuilder.InsertData(
                table: "BookBaseCategory",
                columns: new[] { "Id", "ABookId", "BookBaseId", "BookId", "CategoryId", "CategoryId1", "CreatedAt", "DeletedAt", "EBookId", "TypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, 1, null, 1, null, null, null, null, 1, null },
                    { 2, null, 1, null, 1, null, null, null, null, 1, null },
                    { 3, null, 1, null, 1, null, null, null, null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "BookBaseGenre",
                columns: new[] { "Id", "ABookId", "BookBaseId", "BookId", "CreatedAt", "DeletedAt", "EBookId", "GenreId", "GenreId1", "TypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, 1, null, null, null, null, 1, null, 1, null },
                    { 2, null, 1, null, null, null, null, 1, null, 2, null },
                    { 3, null, 1, null, null, null, null, 1, null, 3, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ABookChapter_ABookId",
                table: "ABookChapter",
                column: "ABookId");

            migrationBuilder.CreateIndex(
                name: "IX_ABooks_BTypeId",
                table: "ABooks",
                column: "BTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ABooks_LanguageId",
                table: "ABooks",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ABooks_PromotionId",
                table: "ABooks",
                column: "PromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_BTypeId",
                table: "Book",
                column: "BTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_LanguageId",
                table: "Book",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_PromotionId",
                table: "Book",
                column: "PromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBaseAuthor_ABookId",
                table: "BookBaseAuthor",
                column: "ABookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBaseAuthor_AuthorId",
                table: "BookBaseAuthor",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBaseAuthor_AuthorId1",
                table: "BookBaseAuthor",
                column: "AuthorId1");

            migrationBuilder.CreateIndex(
                name: "IX_BookBaseAuthor_BookBaseId",
                table: "BookBaseAuthor",
                column: "BookBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBaseAuthor_BookId",
                table: "BookBaseAuthor",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBaseAuthor_EBookId",
                table: "BookBaseAuthor",
                column: "EBookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBaseCategory_ABookId",
                table: "BookBaseCategory",
                column: "ABookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBaseCategory_BookBaseId",
                table: "BookBaseCategory",
                column: "BookBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBaseCategory_BookId",
                table: "BookBaseCategory",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBaseCategory_CategoryId",
                table: "BookBaseCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBaseCategory_CategoryId1",
                table: "BookBaseCategory",
                column: "CategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_BookBaseCategory_EBookId",
                table: "BookBaseCategory",
                column: "EBookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBaseGenre_ABookId",
                table: "BookBaseGenre",
                column: "ABookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBaseGenre_BookBaseId",
                table: "BookBaseGenre",
                column: "BookBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBaseGenre_BookId",
                table: "BookBaseGenre",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBaseGenre_EBookId",
                table: "BookBaseGenre",
                column: "EBookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBaseGenre_GenreId",
                table: "BookBaseGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBaseGenre_GenreId1",
                table: "BookBaseGenre",
                column: "GenreId1");

            migrationBuilder.CreateIndex(
                name: "IX_EBooks_BTypeId",
                table: "EBooks",
                column: "BTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EBooks_LanguageId",
                table: "EBooks",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_EBooks_PromotionId",
                table: "EBooks",
                column: "PromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_Genre_CategoryId",
                table: "Genre",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ABookChapter");

            migrationBuilder.DropTable(
                name: "BookBaseAuthor");

            migrationBuilder.DropTable(
                name: "BookBaseCategory");

            migrationBuilder.DropTable(
                name: "BookBaseGenre");

            migrationBuilder.DropTable(
                name: "SettingKeyValue");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "ABooks");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "EBooks");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "BTypes");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
