using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.API.Migrations
{
    public partial class addseeddataforcollege : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8001b763-1e65-43b5-9616-72134f3ce724");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92bfa350-4e60-4d94-aab9-b771701a67f5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "196d6d63-edaa-4f27-907c-b06099ee29c5", null, "Administrator", "ADMINISTRATOR" },
                    { "fb820b2b-cfbe-427e-a71a-6a64361f5a6d", null, "User", "USER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "196d6d63-edaa-4f27-907c-b06099ee29c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb820b2b-cfbe-427e-a71a-6a64361f5a6d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8001b763-1e65-43b5-9616-72134f3ce724", null, "User", "USER" },
                    { "92bfa350-4e60-4d94-aab9-b771701a67f5", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
