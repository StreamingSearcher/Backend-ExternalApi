using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePlatformData : Migration
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

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Platforms");

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("202d72a9-d6c4-47d7-9452-012a8bc18930"), "Now" },
                    { new Guid("292e3c8a-d6f2-47e2-b4db-1b7d9d851bf9"), "Zee5" },
                    { new Guid("3c2b7798-ab58-402e-aee5-43ebcf7b7535"), "Peacock" },
                    { new Guid("3dff5e3d-fb74-4e08-a6fb-8cdad36e8942"), "Disney" },
                    { new Guid("40dc221d-c37f-4800-a900-661cc0b24f06"), "Iplayer" },
                    { new Guid("422baaef-2371-4273-9ec7-16a8bad58048"), "Mubi" },
                    { new Guid("49826e16-5277-4365-a4d5-8397a0f8855c"), "Hbo" },
                    { new Guid("4ba1ce32-0b9c-4100-a9d9-a0f31459cf66"), "Hotstar" },
                    { new Guid("503acfe1-8a08-4546-b8aa-4407bd5a1c57"), "Hulu" },
                    { new Guid("579d8a1d-7618-478b-b8fe-ebb8f12c31d5"), "Paramount" },
                    { new Guid("63f19fff-0a09-4b80-8aca-e12e21d7d9aa"), "Prime" },
                    { new Guid("6a3bf78c-5d5f-4348-bfc6-d006e988f2d2"), "Netflix" },
                    { new Guid("743a1c3b-3d21-40b9-9e9f-c9cd4237e98d"), "Stan" },
                    { new Guid("a44cd301-0562-4334-88cf-f85a2ef0a526"), "Starz" },
                    { new Guid("a8605f3e-55f1-4629-9767-7fe62aa4d058"), "Wow" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("202d72a9-d6c4-47d7-9452-012a8bc18930"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("292e3c8a-d6f2-47e2-b4db-1b7d9d851bf9"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("3c2b7798-ab58-402e-aee5-43ebcf7b7535"));

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
                keyValue: new Guid("579d8a1d-7618-478b-b8fe-ebb8f12c31d5"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("63f19fff-0a09-4b80-8aca-e12e21d7d9aa"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("6a3bf78c-5d5f-4348-bfc6-d006e988f2d2"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("743a1c3b-3d21-40b9-9e9f-c9cd4237e98d"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("a44cd301-0562-4334-88cf-f85a2ef0a526"));

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: new Guid("a8605f3e-55f1-4629-9767-7fe62aa4d058"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Platforms",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

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
