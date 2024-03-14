using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixErrors2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("02599abe-bdda-4259-9e21-7f27291903aa"), "action" },
                    { new Guid("162bec6e-cee6-4b66-91b0-806a89c27508"), "horror" },
                    { new Guid("1aa68164-f0b1-4ea8-a9cb-c8193967e6a8"), "romance" },
                    { new Guid("1c8923bf-60a2-4a7f-858e-e6915a0a563e"), "music" },
                    { new Guid("38897f28-63b9-4d76-8785-e5ecaf63b551"), "animation" },
                    { new Guid("58aab9ec-92db-41d4-b7ea-278a9b58b6b5"), "news" },
                    { new Guid("70312cee-7e62-4b95-b67e-d7bc9fbfd39a"), "history" },
                    { new Guid("7b2fbc66-0cd2-425a-997f-0a658a8cc183"), "reality" },
                    { new Guid("8b13bea3-6238-4079-aa24-46fa5711de0f"), "thriller" },
                    { new Guid("901eb00d-86ee-48ea-a641-37e023b98d4f"), "war" },
                    { new Guid("a8dca6d5-72b8-4fe0-b21b-d27d0a95ef04"), "family" },
                    { new Guid("c26358b5-6af9-4671-9121-f21827f28501"), "crime" },
                    { new Guid("cb2226be-2766-4fa0-acae-60b3db5f3781"), "drama" },
                    { new Guid("cdf5b96d-cbb0-4b00-af24-2d0118dc2565"), "comedy" },
                    { new Guid("d1db0213-632a-49c6-9005-e8ab6544c65a"), "science fiction" },
                    { new Guid("dd04b307-5ddb-48ca-98bd-2496fd646eda"), "talk show" },
                    { new Guid("df586a04-e701-4710-a807-dd9926d828be"), "mystery" },
                    { new Guid("e7fa5969-44e1-4863-9cf6-fb0689ceb653"), "western" },
                    { new Guid("ebcc6d33-7bcb-4045-987f-7b0ffa03b377"), "fantasy" },
                    { new Guid("fbd740a8-6b8b-4733-8322-f86189f4a773"), "documentary" },
                    { new Guid("fe2fcdb9-a70b-467a-a5a9-2a17c933d6fc"), "adventure" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("02599abe-bdda-4259-9e21-7f27291903aa"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("162bec6e-cee6-4b66-91b0-806a89c27508"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1aa68164-f0b1-4ea8-a9cb-c8193967e6a8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1c8923bf-60a2-4a7f-858e-e6915a0a563e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("38897f28-63b9-4d76-8785-e5ecaf63b551"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("58aab9ec-92db-41d4-b7ea-278a9b58b6b5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("70312cee-7e62-4b95-b67e-d7bc9fbfd39a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7b2fbc66-0cd2-425a-997f-0a658a8cc183"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8b13bea3-6238-4079-aa24-46fa5711de0f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("901eb00d-86ee-48ea-a641-37e023b98d4f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a8dca6d5-72b8-4fe0-b21b-d27d0a95ef04"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c26358b5-6af9-4671-9121-f21827f28501"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cb2226be-2766-4fa0-acae-60b3db5f3781"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cdf5b96d-cbb0-4b00-af24-2d0118dc2565"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d1db0213-632a-49c6-9005-e8ab6544c65a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dd04b307-5ddb-48ca-98bd-2496fd646eda"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("df586a04-e701-4710-a807-dd9926d828be"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e7fa5969-44e1-4863-9cf6-fb0689ceb653"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ebcc6d33-7bcb-4045-987f-7b0ffa03b377"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fbd740a8-6b8b-4733-8322-f86189f4a773"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fe2fcdb9-a70b-467a-a5a9-2a17c933d6fc"));

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
        }
    }
}
