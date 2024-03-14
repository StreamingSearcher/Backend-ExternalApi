using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddLoadGenreData : Migration
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
                keyValue: new Guid("00fdf910-c8a4-4b81-8c83-2ddcb8ff4e13"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("0244898b-e6f9-4768-ac4f-f0426616da6f"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("202d72a9-d6c4-47d7-9452-012a8bc18930"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("3dff5e3d-fb74-4e08-a6fb-8cdad36e8942"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("40dc221d-c37f-4800-a900-661cc0b24f06"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("422baaef-2371-4273-9ec7-16a8bad58048"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("49826e16-5277-4365-a4d5-8397a0f8855c"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("4ba1ce32-0b9c-4100-a9d9-a0f31459cf66"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("503acfe1-8a08-4546-b8aa-4407bd5a1c57"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("57caba37-8651-4a86-b4ef-cdc3bc36c867"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("6a3bf78c-5d5f-4348-bfc6-d006e988f2d2"));

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

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("024e57b5-fddc-4f77-9321-b67f937f19bc"), "comedy" },
                    { new Guid("08e6138a-52f1-43a3-856c-23f58ed6bfd3"), "crime" },
                    { new Guid("1203b8ef-2903-47c1-81b4-69c75912ea3e"), "talk show" },
                    { new Guid("12afa0a9-cc90-413d-969e-dcf7ad5aff23"), "family" },
                    { new Guid("370029c8-01a9-42e0-a0ed-b283c429c7ec"), "mystery" },
                    { new Guid("3d246efc-86d5-4db7-b78d-75113d65e463"), "adventure" },
                    { new Guid("4e914224-650c-4e4b-a8bb-668bcfae0000"), "drama" },
                    { new Guid("6116a999-808a-4ba7-867c-2b20018d4111"), "music" },
                    { new Guid("6e96bc54-965c-4e63-ba6a-7b5ed6c210e5"), "science fiction" },
                    { new Guid("8d16fc36-7140-4f93-80c3-9c49158215cf"), "horror" },
                    { new Guid("a0ddc010-69de-4b8d-a1bf-9a80a84f52eb"), "western" },
                    { new Guid("a5446d78-9969-420a-8310-940b3cb2b4ca"), "fantasy" },
                    { new Guid("abe981a4-3a10-46fb-9421-b678608c9d35"), "thriller" },
                    { new Guid("af69bf4d-d807-4ef2-aea1-13b7e75ce0ae"), "war" },
                    { new Guid("af7e174c-b96e-4276-ab6f-f663806a91b6"), "documentary" },
                    { new Guid("c401d5a2-a8d0-48c0-8411-961c4c4f0761"), "animation" },
                    { new Guid("ccb5f3fc-6523-417b-98ba-613be7184729"), "romance" },
                    { new Guid("d8cce0a8-a20d-4b3e-922c-3238b0472122"), "history" },
                    { new Guid("e6ed0877-4131-4eae-8912-62a77e05e9ca"), "action" },
                    { new Guid("e95b7824-dd73-4611-b963-5f1f585a4b0f"), "reality" },
                    { new Guid("f177c75f-5107-48c8-83b2-089fa2daab09"), "news" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("368fc032-f553-494d-a260-e4d50b5eb15f"), "disney" },
                    { new Guid("554f22f0-a4bf-474c-89ab-c8756ab3ec21"), "peacock" },
                    { new Guid("637263a0-dbfc-4072-9857-5886bef7465d"), "paramount" },
                    { new Guid("690cadd8-d2f7-4cd0-88cb-c04473ce6c59"), "wow" },
                    { new Guid("6db4cee2-fc9c-4e7c-8351-ce0d38a65972"), "hulu" },
                    { new Guid("75f738af-99f3-4e6e-83f5-83218127b351"), "netflix" },
                    { new Guid("79bd47da-39de-43bf-be7f-6b7f1cfa66dd"), "hotstar" },
                    { new Guid("821b992e-0484-4394-8fee-5dc021073698"), "iplayer" },
                    { new Guid("854edcdb-e33c-4838-af6c-6fc5bde2064c"), "mubi" },
                    { new Guid("d68930d2-b922-4aa9-8916-804a36b7352d"), "hbo" },
                    { new Guid("d8402061-928e-4849-890a-674801c7080b"), "now" },
                    { new Guid("de498e77-4d56-45d7-8098-60bb563e28da"), "zee5" },
                    { new Guid("e2a78b5a-c1ce-4911-81ac-41922166656e"), "stan" },
                    { new Guid("f2c87527-15e9-45b0-a736-ed8c2c41df34"), "starz" },
                    { new Guid("f90e3a5e-8f10-42f7-a78e-9ba3dd5949fc"), "prime" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("024e57b5-fddc-4f77-9321-b67f937f19bc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("08e6138a-52f1-43a3-856c-23f58ed6bfd3"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1203b8ef-2903-47c1-81b4-69c75912ea3e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("12afa0a9-cc90-413d-969e-dcf7ad5aff23"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("370029c8-01a9-42e0-a0ed-b283c429c7ec"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3d246efc-86d5-4db7-b78d-75113d65e463"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4e914224-650c-4e4b-a8bb-668bcfae0000"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6116a999-808a-4ba7-867c-2b20018d4111"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6e96bc54-965c-4e63-ba6a-7b5ed6c210e5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8d16fc36-7140-4f93-80c3-9c49158215cf"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a0ddc010-69de-4b8d-a1bf-9a80a84f52eb"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a5446d78-9969-420a-8310-940b3cb2b4ca"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("abe981a4-3a10-46fb-9421-b678608c9d35"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("af69bf4d-d807-4ef2-aea1-13b7e75ce0ae"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("af7e174c-b96e-4276-ab6f-f663806a91b6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c401d5a2-a8d0-48c0-8411-961c4c4f0761"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ccb5f3fc-6523-417b-98ba-613be7184729"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d8cce0a8-a20d-4b3e-922c-3238b0472122"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e6ed0877-4131-4eae-8912-62a77e05e9ca"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e95b7824-dd73-4611-b963-5f1f585a4b0f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f177c75f-5107-48c8-83b2-089fa2daab09"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("368fc032-f553-494d-a260-e4d50b5eb15f"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("554f22f0-a4bf-474c-89ab-c8756ab3ec21"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("637263a0-dbfc-4072-9857-5886bef7465d"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("690cadd8-d2f7-4cd0-88cb-c04473ce6c59"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("6db4cee2-fc9c-4e7c-8351-ce0d38a65972"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("75f738af-99f3-4e6e-83f5-83218127b351"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("79bd47da-39de-43bf-be7f-6b7f1cfa66dd"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("821b992e-0484-4394-8fee-5dc021073698"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("854edcdb-e33c-4838-af6c-6fc5bde2064c"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("d68930d2-b922-4aa9-8916-804a36b7352d"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("d8402061-928e-4849-890a-674801c7080b"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("de498e77-4d56-45d7-8098-60bb563e28da"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("e2a78b5a-c1ce-4911-81ac-41922166656e"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("f2c87527-15e9-45b0-a736-ed8c2c41df34"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("f90e3a5e-8f10-42f7-a78e-9ba3dd5949fc"));

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
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00fdf910-c8a4-4b81-8c83-2ddcb8ff4e13"), "netflix" },
                    { new Guid("0244898b-e6f9-4768-ac4f-f0426616da6f"), "prime" },
                    { new Guid("202d72a9-d6c4-47d7-9452-012a8bc18930"), "Now" },
                    { new Guid("3dff5e3d-fb74-4e08-a6fb-8cdad36e8942"), "Disney" },
                    { new Guid("40dc221d-c37f-4800-a900-661cc0b24f06"), "Iplayer" },
                    { new Guid("422baaef-2371-4273-9ec7-16a8bad58048"), "Mubi" },
                    { new Guid("49826e16-5277-4365-a4d5-8397a0f8855c"), "Hbo" },
                    { new Guid("4ba1ce32-0b9c-4100-a9d9-a0f31459cf66"), "Hotstar" },
                    { new Guid("503acfe1-8a08-4546-b8aa-4407bd5a1c57"), "Hulu" },
                    { new Guid("57caba37-8651-4a86-b4ef-cdc3bc36c867"), "paramount" },
                    { new Guid("6a3bf78c-5d5f-4348-bfc6-d006e988f2d2"), "Netflix" },
                    { new Guid("ba2d4783-bbeb-4650-837a-cfcb95eb4a8c"), "apple" },
                    { new Guid("c28d4021-229c-4448-8644-d06b5c6c9f94"), "hulu" },
                    { new Guid("cf0fbba0-abee-40ea-ab79-0675313189c2"), "disney" }
                });
        }
    }
}
