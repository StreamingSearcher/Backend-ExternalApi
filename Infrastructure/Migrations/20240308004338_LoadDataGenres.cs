using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class LoadDataGenres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("00fdf910-c8a4-4b81-8c83-2ddcb8ff4e13"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("0244898b-e6f9-4768-ac4f-f0426616da6f"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("57caba37-8651-4a86-b4ef-cdc3bc36c867"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("ba2d4783-bbeb-4650-837a-cfcb95eb4a8c"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("c28d4021-229c-4448-8644-d06b5c6c9f94"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("cf0fbba0-abee-40ea-ab79-0675313189c2"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("ddac1c39-3df2-477d-8976-67f58a9584af"));

            migrationBuilder.AddColumn<bool>(
                name: "IsPlatformLoaded",
                table: "Medias",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1fa06447-694d-4ba0-bf67-2dedbcbc2650"), "family" },
                    { new Guid("284a3ed2-43fc-4665-a3ef-77da7ef8fc29"), "horror" },
                    { new Guid("35c2a615-a147-45da-9717-3b6a93a37ec2"), "adventure" },
                    { new Guid("426c47d2-fa6a-4838-9b56-b5d957271777"), "science fiction" },
                    { new Guid("4f06cf69-ba0d-4b51-8136-241dc173bb9b"), "war" },
                    { new Guid("6f5a91a6-5a97-4202-a252-a0a05ac638b2"), "drama" },
                    { new Guid("79fd5c7f-90d6-482d-9340-9aa5ca2b8ee0"), "western" },
                    { new Guid("9412b81d-7cf3-4d33-aefb-6d3b08154731"), "documentary" },
                    { new Guid("a2b871a2-a155-4dc4-a9b3-71b80f046dc5"), "animation" },
                    { new Guid("abf60177-a779-4b3d-a1f7-b93b6339f1a6"), "history" },
                    { new Guid("ae2c2e0c-1d0c-41da-b194-9ec87b1e2324"), "comedy" },
                    { new Guid("aeec74c9-b61c-4119-9754-08b89343d7ca"), "reality" },
                    { new Guid("c66e532e-eb52-46e5-b6ee-08936ef5186f"), "music" },
                    { new Guid("c97a5310-848d-4102-a22a-c63fe54eae19"), "news" },
                    { new Guid("ca4e6ce6-c8d9-41ba-b62e-ea449246b8d9"), "talk show" },
                    { new Guid("d4550bb3-a47f-4cdf-9b44-beeb42f7cbd7"), "crime" },
                    { new Guid("d8f16e02-64dc-4b74-b517-3fe56ec27631"), "thriller" },
                    { new Guid("dd62f195-5f80-4098-9502-e76f496d6334"), "romance" },
                    { new Guid("e33d6edc-ce1b-4390-a0d8-c71377c90338"), "mystery" },
                    { new Guid("eb928850-e02d-4a47-ab61-445d803339ac"), "action" },
                    { new Guid("fcdfb04b-0267-496e-a161-63ef9f70b646"), "fantasy" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("2ae2f1c5-d98d-4acb-a6b1-6dfe86612354"), "hbo max", "hbo" },
                    { new Guid("592874ee-6ba6-4c12-b86d-3836f238d07a"), "netflix", "netflix" },
                    { new Guid("9bd335da-5ab2-408d-8772-454841e0e658"), "paramount", "paramount" },
                    { new Guid("c31c5c3b-b568-456a-b11f-e42aec2a58d7"), "prime video", "prime" },
                    { new Guid("d9771caa-cb26-4ded-817d-4456ef6b9aab"), "apple", "apple" },
                    { new Guid("e158a9e5-6f96-46e0-b0d0-dce162c7bff2"), "disney plus", "disney" },
                    { new Guid("f240e071-919a-4d93-94a4-d247e4f18248"), "hulu", "hulu" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1fa06447-694d-4ba0-bf67-2dedbcbc2650"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("284a3ed2-43fc-4665-a3ef-77da7ef8fc29"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("35c2a615-a147-45da-9717-3b6a93a37ec2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("426c47d2-fa6a-4838-9b56-b5d957271777"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4f06cf69-ba0d-4b51-8136-241dc173bb9b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6f5a91a6-5a97-4202-a252-a0a05ac638b2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("79fd5c7f-90d6-482d-9340-9aa5ca2b8ee0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9412b81d-7cf3-4d33-aefb-6d3b08154731"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a2b871a2-a155-4dc4-a9b3-71b80f046dc5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("abf60177-a779-4b3d-a1f7-b93b6339f1a6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ae2c2e0c-1d0c-41da-b194-9ec87b1e2324"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("aeec74c9-b61c-4119-9754-08b89343d7ca"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c66e532e-eb52-46e5-b6ee-08936ef5186f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c97a5310-848d-4102-a22a-c63fe54eae19"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ca4e6ce6-c8d9-41ba-b62e-ea449246b8d9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d4550bb3-a47f-4cdf-9b44-beeb42f7cbd7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d8f16e02-64dc-4b74-b517-3fe56ec27631"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dd62f195-5f80-4098-9502-e76f496d6334"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e33d6edc-ce1b-4390-a0d8-c71377c90338"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("eb928850-e02d-4a47-ab61-445d803339ac"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fcdfb04b-0267-496e-a161-63ef9f70b646"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("2ae2f1c5-d98d-4acb-a6b1-6dfe86612354"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("592874ee-6ba6-4c12-b86d-3836f238d07a"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("9bd335da-5ab2-408d-8772-454841e0e658"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("c31c5c3b-b568-456a-b11f-e42aec2a58d7"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("d9771caa-cb26-4ded-817d-4456ef6b9aab"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("e158a9e5-6f96-46e0-b0d0-dce162c7bff2"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("f240e071-919a-4d93-94a4-d247e4f18248"));

            migrationBuilder.DropColumn(
                name: "IsPlatformLoaded",
                table: "Medias");

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("00fdf910-c8a4-4b81-8c83-2ddcb8ff4e13"), "netflix", "netflix" },
                    { new Guid("0244898b-e6f9-4768-ac4f-f0426616da6f"), "prime video", "prime" },
                    { new Guid("57caba37-8651-4a86-b4ef-cdc3bc36c867"), "paramount", "paramount" },
                    { new Guid("ba2d4783-bbeb-4650-837a-cfcb95eb4a8c"), "apple", "apple" },
                    { new Guid("c28d4021-229c-4448-8644-d06b5c6c9f94"), "hulu", "hulu" },
                    { new Guid("cf0fbba0-abee-40ea-ab79-0675313189c2"), "disney plus", "disney" },
                    { new Guid("ddac1c39-3df2-477d-8976-67f58a9584af"), "hbo max", "hbo" }
                });
        }
    }
}
