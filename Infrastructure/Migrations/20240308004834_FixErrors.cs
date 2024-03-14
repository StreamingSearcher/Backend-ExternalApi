using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixErrors : Migration
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

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("06318f6d-9735-46f8-8cc3-da2884a304d8"), "family" },
                    { new Guid("1615bbe2-36ee-4bfd-aa07-2901bc7069f8"), "drama" },
                    { new Guid("2652f998-51ba-471e-b395-2ed7cbfffe7b"), "war" },
                    { new Guid("44a5fe5c-f022-460d-82e7-5c16c124e038"), "action" },
                    { new Guid("6b46f22d-6824-4319-b23c-9c74a61d0b6e"), "horror" },
                    { new Guid("77e0017a-78c5-4aab-99cc-65e37e5d1847"), "crime" },
                    { new Guid("96aea2c4-fa6e-48fa-9fe6-77a87f8b0826"), "comedy" },
                    { new Guid("bb411e10-e5ff-4171-b9c7-825b8f7ac4c3"), "fantasy" },
                    { new Guid("bd8fcfd7-2419-49be-91a6-202a7feba3d5"), "mystery" },
                    { new Guid("ce1efe24-efb9-48c5-9ceb-01be47451710"), "history" },
                    { new Guid("ce5737e6-eab6-43b2-906c-92eecf4e1860"), "reality" },
                    { new Guid("cf9753df-b273-400f-939d-39e0893238e2"), "talk show" },
                    { new Guid("d8f5ab1d-b7fa-4193-9787-ed8c75daa2f7"), "romance" },
                    { new Guid("e235925c-6f8a-4b48-bf66-ab4059e1209e"), "news" },
                    { new Guid("e4c7611c-083c-4871-acaa-f62905e60dbc"), "documentary" },
                    { new Guid("e90b23cd-d9de-44e1-bf39-955ba00d686e"), "science fiction" },
                    { new Guid("e9ce06c9-b883-4afa-8ce1-246df7a761a3"), "adventure" },
                    { new Guid("eb05b477-6f7d-4cae-8062-7eca5796c014"), "animation" },
                    { new Guid("eedfc440-153d-4a7b-9383-de327f813e86"), "music" },
                    { new Guid("f07e7ef8-8a04-44c0-bb3a-5bbe4db939d9"), "western" },
                    { new Guid("fc90dbca-9044-403a-93e0-8da66b8a4c52"), "thriller" }
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
                keyValue: new Guid("06318f6d-9735-46f8-8cc3-da2884a304d8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1615bbe2-36ee-4bfd-aa07-2901bc7069f8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2652f998-51ba-471e-b395-2ed7cbfffe7b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("44a5fe5c-f022-460d-82e7-5c16c124e038"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6b46f22d-6824-4319-b23c-9c74a61d0b6e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("77e0017a-78c5-4aab-99cc-65e37e5d1847"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("96aea2c4-fa6e-48fa-9fe6-77a87f8b0826"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("bb411e10-e5ff-4171-b9c7-825b8f7ac4c3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("bd8fcfd7-2419-49be-91a6-202a7feba3d5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ce1efe24-efb9-48c5-9ceb-01be47451710"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ce5737e6-eab6-43b2-906c-92eecf4e1860"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cf9753df-b273-400f-939d-39e0893238e2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d8f5ab1d-b7fa-4193-9787-ed8c75daa2f7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e235925c-6f8a-4b48-bf66-ab4059e1209e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e4c7611c-083c-4871-acaa-f62905e60dbc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e90b23cd-d9de-44e1-bf39-955ba00d686e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e9ce06c9-b883-4afa-8ce1-246df7a761a3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("eb05b477-6f7d-4cae-8062-7eca5796c014"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("eedfc440-153d-4a7b-9383-de327f813e86"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f07e7ef8-8a04-44c0-bb3a-5bbe4db939d9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fc90dbca-9044-403a-93e0-8da66b8a4c52"));

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
