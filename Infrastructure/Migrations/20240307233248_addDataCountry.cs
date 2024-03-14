using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addDataCountry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "be");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "bg");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "br");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "ca");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "ch");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "cl");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "co");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "cy");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "cz");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "de");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "dk");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "ec");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "ee");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "es");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "fi");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "fr");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "gb");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "gr");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "hk");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "hr");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "hu");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "id");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "ie");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "il");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "in");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "is");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "it");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "jp");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "kr");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "lt");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "md");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "mk");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "mx");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "my");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "nl");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "no");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "nz");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "pa");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "pe");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "ph");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "pl");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "pt");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "ro");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "rs");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "ru");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "se");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "sg");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "si");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "th");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "tr");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "ua");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "us");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "vn");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Code",
                keyValue: "za");

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
        }
    }
}
