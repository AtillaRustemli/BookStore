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
                    SocialMediaId = table.Column<int>(type: "int", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_ABooks_SocialMedias_SocialMediaId",
                        column: x => x.SocialMediaId,
                        principalTable: "SocialMedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
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
                    SocialMediaId = table.Column<int>(type: "int", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Book_SocialMedias_SocialMediaId",
                        column: x => x.SocialMediaId,
                        principalTable: "SocialMedias",
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
                    SocialMediaId = table.Column<int>(type: "int", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_EBooks_SocialMedias_SocialMediaId",
                        column: x => x.SocialMediaId,
                        principalTable: "SocialMedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ABookAuthor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ABookId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABookAuthor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ABookAuthor_ABooks_ABookId",
                        column: x => x.ABookId,
                        principalTable: "ABooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ABookAuthor_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ABookAuthor_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ABookBCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ABookId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABookBCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ABookBCategory_ABooks_ABookId",
                        column: x => x.ABookId,
                        principalTable: "ABooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ABookBCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
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
                name: "ABookGenre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ABookId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABookGenre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ABookGenre_ABooks_ABookId",
                        column: x => x.ABookId,
                        principalTable: "ABooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ABookGenre_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookAuthor_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthor_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookCategory_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookGenre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookGenre_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGenre_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EBookAuthor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EBookId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EBookAuthor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EBookAuthor_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EBookAuthor_EBooks_EBookId",
                        column: x => x.EBookId,
                        principalTable: "EBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EBookBaseCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EBookId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EBookBaseCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EBookBaseCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EBookBaseCategory_EBooks_EBookId",
                        column: x => x.EBookId,
                        principalTable: "EBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EBookGenre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EBookId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EBookGenre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EBookGenre_EBooks_EBookId",
                        column: x => x.EBookId,
                        principalTable: "EBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EBookGenre_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                values: new object[] { 1, null, null, "Look at our fantasting promotion.This is amasing!!!", "promotion-detail1.jpg", new DateTime(2023, 12, 31, 19, 25, 25, 457, DateTimeKind.Local).AddTicks(4390), "promotion-image1.jpg", "New Year Discount", "Amasing new year discount", null });

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
                columns: new[] { "Id", "BTypeId", "CreatedAt", "DeletedAt", "Description", "ImgUrl", "LanguageId", "Name", "Narrator", "PopularityCount", "Price", "PromotionId", "Released", "SellCount", "SocialMediaId", "UpdatedAt" },
                values: new object[] { 1, 2, null, null, "This is book's description and there is nothing but description so good luck)", "book-example4.jpg", 1, "Talk to the Heart", "Atilla", 0L, 11.0, 1, new DateTime(2023, 12, 31, 19, 25, 25, 457, DateTimeKind.Local).AddTicks(2521), 0L, 1, null });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "BTypeId", "CreatedAt", "DeletedAt", "Description", "Height", "ImgUrl", "LanguageId", "Length", "Name", "PopularityCount", "Price", "PromotionId", "Released", "SellCount", "SocialMediaId", "UpdatedAt", "Width" },
                values: new object[] { 1, 1, null, null, "This is book's description and there is nothing but description so good luck)", 5.4000000000000004, "book-example4.jpg", 1, 20.300000000000001, "Talk to the Heart", 0L, 11.0, 1, new DateTime(2023, 12, 31, 19, 25, 25, 457, DateTimeKind.Local).AddTicks(3228), 0L, 1, null, 15.1 });

            migrationBuilder.InsertData(
                table: "EBooks",
                columns: new[] { "Id", "BTypeId", "CreatedAt", "DeletedAt", "Description", "EBookUrl", "ImgUrl", "LanguageId", "Name", "PopularityCount", "Price", "PromotionId", "Released", "SellCount", "SocialMediaId", "UpdatedAt" },
                values: new object[] { 1, 2, null, null, "This is book's description and there is nothing but description so good luck)", "ardino.pdf", "book-example4.jpg", 1, "Talk to the Heart", 0L, 11.0, 1, new DateTime(2023, 12, 31, 19, 25, 25, 457, DateTimeKind.Local).AddTicks(3864), 0L, 1, null });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[] { 1, 1, null, null, "Fanatsy", null });

            migrationBuilder.InsertData(
                table: "ABookAuthor",
                columns: new[] { "Id", "ABookId", "AuthorId", "CreatedAt", "DeletedAt", "GenreId", "UpdatedAt" },
                values: new object[] { 1, 1, 1, null, null, null, null });

            migrationBuilder.InsertData(
                table: "ABookBCategory",
                columns: new[] { "Id", "ABookId", "CategoryId", "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { 1, 1, 1, null, null, null });

            migrationBuilder.InsertData(
                table: "ABookChapter",
                columns: new[] { "Id", "ABookId", "ABookUrl", "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { 1, 1, "", null, null, null });

            migrationBuilder.InsertData(
                table: "ABookGenre",
                columns: new[] { "Id", "ABookId", "CreatedAt", "DeletedAt", "GenreId", "UpdatedAt" },
                values: new object[] { 1, 1, null, null, 1, null });

            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "Id", "AuthorId", "BookId", "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { 1, 1, 1, null, null, null });

            migrationBuilder.InsertData(
                table: "BookCategory",
                columns: new[] { "Id", "BookId", "CategoryId", "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { 1, 1, 1, null, null, null });

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "Id", "BookId", "CreatedAt", "DeletedAt", "GenreId", "UpdatedAt" },
                values: new object[] { 1, 1, null, null, 1, null });

            migrationBuilder.InsertData(
                table: "EBookAuthor",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "DeletedAt", "EBookId", "UpdatedAt" },
                values: new object[] { 1, 1, null, null, 1, null });

            migrationBuilder.InsertData(
                table: "EBookBaseCategory",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "DeletedAt", "EBookId", "UpdatedAt" },
                values: new object[] { 1, 1, null, null, 1, null });

            migrationBuilder.InsertData(
                table: "EBookGenre",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "EBookId", "GenreId", "UpdatedAt" },
                values: new object[] { 1, null, null, 1, 1, null });

            migrationBuilder.CreateIndex(
                name: "IX_ABookAuthor_ABookId",
                table: "ABookAuthor",
                column: "ABookId");

            migrationBuilder.CreateIndex(
                name: "IX_ABookAuthor_AuthorId",
                table: "ABookAuthor",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_ABookAuthor_GenreId",
                table: "ABookAuthor",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_ABookBCategory_ABookId",
                table: "ABookBCategory",
                column: "ABookId");

            migrationBuilder.CreateIndex(
                name: "IX_ABookBCategory_CategoryId",
                table: "ABookBCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ABookChapter_ABookId",
                table: "ABookChapter",
                column: "ABookId");

            migrationBuilder.CreateIndex(
                name: "IX_ABookGenre_ABookId",
                table: "ABookGenre",
                column: "ABookId");

            migrationBuilder.CreateIndex(
                name: "IX_ABookGenre_GenreId",
                table: "ABookGenre",
                column: "GenreId");

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
                name: "IX_ABooks_SocialMediaId",
                table: "ABooks",
                column: "SocialMediaId",
                unique: true);

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
                name: "IX_Book_SocialMediaId",
                table: "Book",
                column: "SocialMediaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_AuthorId",
                table: "BookAuthor",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_BookId",
                table: "BookAuthor",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCategory_BookId",
                table: "BookCategory",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCategory_CategoryId",
                table: "BookCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenre_BookId",
                table: "BookGenre",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenre_GenreId",
                table: "BookGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_EBookAuthor_AuthorId",
                table: "EBookAuthor",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_EBookAuthor_EBookId",
                table: "EBookAuthor",
                column: "EBookId");

            migrationBuilder.CreateIndex(
                name: "IX_EBookBaseCategory_CategoryId",
                table: "EBookBaseCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_EBookBaseCategory_EBookId",
                table: "EBookBaseCategory",
                column: "EBookId");

            migrationBuilder.CreateIndex(
                name: "IX_EBookGenre_EBookId",
                table: "EBookGenre",
                column: "EBookId");

            migrationBuilder.CreateIndex(
                name: "IX_EBookGenre_GenreId",
                table: "EBookGenre",
                column: "GenreId");

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
                name: "IX_EBooks_SocialMediaId",
                table: "EBooks",
                column: "SocialMediaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Genre_CategoryId",
                table: "Genre",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ABookAuthor");

            migrationBuilder.DropTable(
                name: "ABookBCategory");

            migrationBuilder.DropTable(
                name: "ABookChapter");

            migrationBuilder.DropTable(
                name: "ABookGenre");

            migrationBuilder.DropTable(
                name: "BookAuthor");

            migrationBuilder.DropTable(
                name: "BookCategory");

            migrationBuilder.DropTable(
                name: "BookGenre");

            migrationBuilder.DropTable(
                name: "EBookAuthor");

            migrationBuilder.DropTable(
                name: "EBookBaseCategory");

            migrationBuilder.DropTable(
                name: "EBookGenre");

            migrationBuilder.DropTable(
                name: "SettingKeyValue");

            migrationBuilder.DropTable(
                name: "ABooks");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Author");

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
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
