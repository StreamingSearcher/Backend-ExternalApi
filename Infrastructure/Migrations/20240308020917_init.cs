using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Code = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ImdbId = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Year = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    Overview = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    IsPlatformLoaded = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MediaGenres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GenreId = table.Column<Guid>(type: "uuid", nullable: false),
                    MediaId = table.Column<Guid>(type: "uuid", nullable: false),
                    ImdbId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MediaGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MediaGenres_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MediaPlatforms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MediaId = table.Column<Guid>(type: "uuid", nullable: false),
                    PlatformId = table.Column<Guid>(type: "uuid", nullable: false),
                    CountryCode = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaPlatforms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MediaPlatforms_Countries_CountryCode",
                        column: x => x.CountryCode,
                        principalTable: "Countries",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MediaPlatforms_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MediaPlatforms_Platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Code", "Name" },
                values: new object[,]
                {
                    { "be", "Belgium" },
                    { "bg", "Bulgaria" },
                    { "br", "Brazil" },
                    { "ca", "Canada" },
                    { "ch", "Switzerland" },
                    { "cl", "Chile" },
                    { "co", "Colombia" },
                    { "cy", "Cyprus" },
                    { "cz", "Czech Republic" },
                    { "de", "Germany" },
                    { "dk", "Denmark" },
                    { "ec", "Ecuador" },
                    { "ee", "Estonia" },
                    { "es", "Spain" },
                    { "fi", "Finland" },
                    { "fr", "France" },
                    { "gb", "United Kingdom" },
                    { "gr", "Greece" },
                    { "hk", "Hong Kong" },
                    { "hr", "Croatia" },
                    { "hu", "Hungary" },
                    { "id", "Indonesia" },
                    { "ie", "Ireland" },
                    { "il", "Israel" },
                    { "in", "India" },
                    { "is", "Iceland" },
                    { "it", "Italy" },
                    { "jp", "Japan" },
                    { "kr", "South Korea" },
                    { "lt", "Lithuania" },
                    { "md", "Moldova" },
                    { "mk", "North Macedonia" },
                    { "mx", "Mexico" },
                    { "my", "Malaysia" },
                    { "nl", "Netherlands" },
                    { "no", "Norway" },
                    { "nz", "New Zealand" },
                    { "pa", "Panama" },
                    { "pe", "Peru" },
                    { "ph", "Philippines" },
                    { "pl", "Poland" },
                    { "pt", "Portugal" },
                    { "ro", "Romania" },
                    { "rs", "Serbia" },
                    { "ru", "Russia" },
                    { "se", "Sweden" },
                    { "sg", "Singapore" },
                    { "si", "Slovenia" },
                    { "th", "Thailand" },
                    { "tr", "Turkey" },
                    { "ua", "Ukraine" },
                    { "us", "United States" },
                    { "vn", "Vietnam" },
                    { "za", "South Africa" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("03221487-5f54-46c2-bdc2-558faa3a52c4"), "comedy" },
                    { new Guid("18540b0e-5dd0-41ac-aa8b-12a725dfccd7"), "horror" },
                    { new Guid("1a756f05-9352-4577-9f35-47426c7e6b1c"), "drama" },
                    { new Guid("20132f2f-30b0-49ba-bdd6-2d7d8b0d43a6"), "documentary" },
                    { new Guid("2058753e-9650-408e-b1da-8ee327655908"), "action" },
                    { new Guid("29db72e4-bfc2-4c33-8208-1ea0266b5e76"), "animation" },
                    { new Guid("2adf17c9-1fcd-4e1d-b861-7b600b397755"), "reality" },
                    { new Guid("30dbeac2-074a-495e-8d6b-f9333f6e265b"), "war" },
                    { new Guid("3b21d899-6572-4b13-beff-edc701d40a6d"), "music" },
                    { new Guid("3e607a73-14ea-404b-bf02-2435807963cd"), "mystery" },
                    { new Guid("42089d28-4fac-41d8-a531-aef638d5c094"), "talk show" },
                    { new Guid("51d16fb6-4867-4c9c-b83b-d93abc390160"), "romance" },
                    { new Guid("68486913-dfb4-4675-bf1f-33f05a0b3bbf"), "adventure" },
                    { new Guid("75a33af4-056a-468d-bed3-ecec3b21ab71"), "science fiction" },
                    { new Guid("7648a40b-f5d6-4388-ae58-7882d820e866"), "crime" },
                    { new Guid("7a0980ce-2357-449b-9b3f-e7c8f47f3458"), "western" },
                    { new Guid("7d02d890-1c42-4b13-a3af-878763b2d6b6"), "fantasy" },
                    { new Guid("8b3d6342-df3e-4e9f-83a5-d03ee42a5ca2"), "news" },
                    { new Guid("8c4c6245-7b0c-43bd-9138-3414fc1302be"), "thriller" },
                    { new Guid("96031e4e-cb17-4ad4-827b-811802e52521"), "family" },
                    { new Guid("e765e863-96ab-4aee-89e7-fa94da25be9c"), "history" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0016fc0c-9440-4167-8519-d26e44f724e9"), "paramount" },
                    { new Guid("04f099df-13a8-4157-8deb-6fca0a4092be"), "wow" },
                    { new Guid("109db5a8-a147-4f78-b4ec-0a312be1a6d4"), "peacock" },
                    { new Guid("205860b6-5d0c-4145-b9d1-cb54e55696ef"), "stan" },
                    { new Guid("25b338c1-da28-4321-a04c-c3bed509a3c8"), "zee5" },
                    { new Guid("2ba735f2-92e0-4838-8141-3c2364ff8899"), "hotstar" },
                    { new Guid("368b4669-7f9a-4dfd-9e64-68415700fe36"), "starz" },
                    { new Guid("5e5f997d-05e9-4949-8c35-68afd9923d14"), "prime" },
                    { new Guid("9a648d82-6671-4083-a45d-f183b60eaf13"), "mubi" },
                    { new Guid("b8d3decc-872c-484b-89b1-bdee9b0199fe"), "disney" },
                    { new Guid("c84e4068-8a61-4e79-9ef8-3c799f351262"), "hbo" },
                    { new Guid("d62e4556-5c70-4b3d-a80b-2b622bfab1cc"), "iplayer" },
                    { new Guid("e62deea1-28ef-44b3-b76c-064155b35a32"), "netflix" },
                    { new Guid("f2b813c3-50de-4fee-9d17-55a2adf7a0e0"), "now" },
                    { new Guid("ff118264-fc46-4ca8-afbe-428c02f9d34a"), "hulu" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MediaGenres_GenreId",
                table: "MediaGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MediaGenres_MediaId",
                table: "MediaGenres",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_MediaPlatforms_CountryCode",
                table: "MediaPlatforms",
                column: "CountryCode");

            migrationBuilder.CreateIndex(
                name: "IX_MediaPlatforms_MediaId",
                table: "MediaPlatforms",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_MediaPlatforms_PlatformId",
                table: "MediaPlatforms",
                column: "PlatformId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MediaGenres");

            migrationBuilder.DropTable(
                name: "MediaPlatforms");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Medias");

            migrationBuilder.DropTable(
                name: "Platforms");
        }
    }
}
