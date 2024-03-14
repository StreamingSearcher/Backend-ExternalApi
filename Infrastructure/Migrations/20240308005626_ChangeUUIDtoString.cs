using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeUUIDtoString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Description",
                table: "Platforms");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Platforms",
                type: "text",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<string>(
                name: "PlatformId",
                table: "MediaPlatforms",
                type: "text",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<string>(
                name: "ImdbId",
                table: "MediaGenres",
                type: "text",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("036abcae-fac8-46c4-b271-22e935e693f4"), "horror" },
                    { new Guid("16e95309-2eb4-497e-b1e6-69f38656a8ea"), "comedy" },
                    { new Guid("1e62bbe3-d573-4b38-8872-dde0f7b42cf9"), "talk show" },
                    { new Guid("4106adc9-1a7f-497e-897a-8a446aec7746"), "drama" },
                    { new Guid("5b3d03ac-4da7-4e69-b45e-7c774a2950dd"), "thriller" },
                    { new Guid("713cc2a4-d9bd-4665-9fe4-ec2f62bd464e"), "western" },
                    { new Guid("731fb28a-5778-4a1c-a0f7-27ed13d4082f"), "reality" },
                    { new Guid("75023c65-7346-4aaf-91e9-52f1827e48fa"), "family" },
                    { new Guid("75e59d56-62d0-4ded-8c9b-5b8b1de6771d"), "action" },
                    { new Guid("7d2750af-db2f-4043-944d-8f2b23919ad2"), "mystery" },
                    { new Guid("8fb34070-0b5d-4430-80f1-c21befff3e8b"), "adventure" },
                    { new Guid("92ae7773-9b74-4efe-9626-f2008eac10cf"), "science fiction" },
                    { new Guid("acc90a6b-40c1-4e3e-b70f-804a4ea2a6f2"), "documentary" },
                    { new Guid("ad9816ae-28aa-4787-9e72-442023acb8af"), "war" },
                    { new Guid("c1fe2607-0779-47d5-a917-35c10721a032"), "animation" },
                    { new Guid("d5cb64b9-60bf-4c1d-a7aa-feeff5ca113e"), "news" },
                    { new Guid("d8565381-4de0-42fe-9d9b-306ab1493273"), "history" },
                    { new Guid("e441d708-8ba1-46ca-83a4-b9baa31f5d05"), "romance" },
                    { new Guid("f0c39dcb-a5fa-4ae6-ad46-e6ce32115ba7"), "music" },
                    { new Guid("f1c7537d-5565-4fa9-8627-5c54c8d25abf"), "fantasy" },
                    { new Guid("fac2f3f5-3e24-47fb-b1f4-69a40a275471"), "crime" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "disney", "Disney" },
                    { "hbo", "Hbo" },
                    { "hotstar", "Hotstar" },
                    { "hulu", "Hulu" },
                    { "iplayer", "Iplayer" },
                    { "mubi", "Mubi" },
                    { "netflix", "Netflix" },
                    { "now", "Now" },
                    { "paramount", "Paramount" },
                    { "peacock", "Peacock" },
                    { "prime", "Prime" },
                    { "stan", "Stan" },
                    { "starz", "Starz" },
                    { "wow", "Wow" },
                    { "zee5", "Zee5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("036abcae-fac8-46c4-b271-22e935e693f4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("16e95309-2eb4-497e-b1e6-69f38656a8ea"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1e62bbe3-d573-4b38-8872-dde0f7b42cf9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4106adc9-1a7f-497e-897a-8a446aec7746"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5b3d03ac-4da7-4e69-b45e-7c774a2950dd"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("713cc2a4-d9bd-4665-9fe4-ec2f62bd464e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("731fb28a-5778-4a1c-a0f7-27ed13d4082f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("75023c65-7346-4aaf-91e9-52f1827e48fa"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("75e59d56-62d0-4ded-8c9b-5b8b1de6771d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7d2750af-db2f-4043-944d-8f2b23919ad2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8fb34070-0b5d-4430-80f1-c21befff3e8b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("92ae7773-9b74-4efe-9626-f2008eac10cf"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("acc90a6b-40c1-4e3e-b70f-804a4ea2a6f2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ad9816ae-28aa-4787-9e72-442023acb8af"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c1fe2607-0779-47d5-a917-35c10721a032"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d5cb64b9-60bf-4c1d-a7aa-feeff5ca113e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d8565381-4de0-42fe-9d9b-306ab1493273"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e441d708-8ba1-46ca-83a4-b9baa31f5d05"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f0c39dcb-a5fa-4ae6-ad46-e6ce32115ba7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f1c7537d-5565-4fa9-8627-5c54c8d25abf"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fac2f3f5-3e24-47fb-b1f4-69a40a275471"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: "disney");

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: "hbo");

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: "hotstar");

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: "hulu");

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: "iplayer");

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: "mubi");

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: "netflix");

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: "now");

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: "paramount");

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: "peacock");

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: "prime");

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: "stan");

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: "starz");

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: "wow");

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: "zee5");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Platforms",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Platforms",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<Guid>(
                name: "PlatformId",
                table: "MediaPlatforms",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<Guid>(
                name: "ImdbId",
                table: "MediaGenres",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

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
    }
}
