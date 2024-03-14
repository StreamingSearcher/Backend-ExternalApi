using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCountryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MediaGenres_Genres_Id",
                table: "MediaGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MediaGenres_Medias_Id",
                table: "MediaGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MediaPlatforms_Medias_Id",
                table: "MediaPlatforms");

            migrationBuilder.DropForeignKey(
                name: "FK_MediaPlatforms_Platforms_Id",
                table: "MediaPlatforms");

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

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("143021aa-358f-443c-a650-b070622c2377"), "paramount", "paramount" },
                    { new Guid("18a22578-c276-43d8-9e5a-c7f89deefcaf"), "apple", "apple" },
                    { new Guid("20cc91aa-57aa-4d9d-81ec-c1021f365e2b"), "hbo max", "hbo" },
                    { new Guid("79a8828d-3196-48bf-aa3d-955bd4f1886e"), "hulu", "hulu" },
                    { new Guid("815a9811-9447-46cb-8bf3-834f1aac5139"), "disney plus", "disney" },
                    { new Guid("9041569f-d035-400c-bdd3-660af06ac211"), "prime video", "prime" },
                    { new Guid("be0ad997-c459-4dff-b349-beee10f4116d"), "netflix", "netflix" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_MediaGenres_GenreId",
                table: "MediaGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MediaGenres_MediaId",
                table: "MediaGenres",
                column: "MediaId");

            migrationBuilder.AddForeignKey(
                name: "FK_MediaGenres_Genres_GenreId",
                table: "MediaGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MediaGenres_Medias_MediaId",
                table: "MediaGenres",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MediaPlatforms_Countries_CountryCode",
                table: "MediaPlatforms",
                column: "CountryCode",
                principalTable: "Countries",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MediaPlatforms_Medias_MediaId",
                table: "MediaPlatforms",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MediaPlatforms_Platforms_PlatformId",
                table: "MediaPlatforms",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MediaGenres_Genres_GenreId",
                table: "MediaGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MediaGenres_Medias_MediaId",
                table: "MediaGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MediaPlatforms_Countries_CountryCode",
                table: "MediaPlatforms");

            migrationBuilder.DropForeignKey(
                name: "FK_MediaPlatforms_Medias_MediaId",
                table: "MediaPlatforms");

            migrationBuilder.DropForeignKey(
                name: "FK_MediaPlatforms_Platforms_PlatformId",
                table: "MediaPlatforms");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_MediaPlatforms_CountryCode",
                table: "MediaPlatforms");

            migrationBuilder.DropIndex(
                name: "IX_MediaPlatforms_MediaId",
                table: "MediaPlatforms");

            migrationBuilder.DropIndex(
                name: "IX_MediaPlatforms_PlatformId",
                table: "MediaPlatforms");

            migrationBuilder.DropIndex(
                name: "IX_MediaGenres_GenreId",
                table: "MediaGenres");

            migrationBuilder.DropIndex(
                name: "IX_MediaGenres_MediaId",
                table: "MediaGenres");

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("143021aa-358f-443c-a650-b070622c2377"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("18a22578-c276-43d8-9e5a-c7f89deefcaf"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("20cc91aa-57aa-4d9d-81ec-c1021f365e2b"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("79a8828d-3196-48bf-aa3d-955bd4f1886e"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("815a9811-9447-46cb-8bf3-834f1aac5139"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("9041569f-d035-400c-bdd3-660af06ac211"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("be0ad997-c459-4dff-b349-beee10f4116d"));

            migrationBuilder.AddForeignKey(
                name: "FK_MediaGenres_Genres_Id",
                table: "MediaGenres",
                column: "Id",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MediaGenres_Medias_Id",
                table: "MediaGenres",
                column: "Id",
                principalTable: "Medias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MediaPlatforms_Medias_Id",
                table: "MediaPlatforms",
                column: "Id",
                principalTable: "Medias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MediaPlatforms_Platforms_Id",
                table: "MediaPlatforms",
                column: "Id",
                principalTable: "Platforms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
