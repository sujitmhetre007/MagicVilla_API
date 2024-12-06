using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class VillaTableENtrySeed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Rate", "Sqft", "UpdatedDate" },
                values: new object[] { "Pool, Gym, Parking", new DateTime(2024, 11, 28, 11, 52, 25, 536, DateTimeKind.Local).AddTicks(4059), "A spacious luxury apartment with modern amenities.", "https://example.com/luxury-apartment.jpg", "Luxury Apartment", 1500.0, 1200, new DateTime(2024, 11, 28, 11, 52, 25, 540, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[] { 2, "Wi-Fi, Coffee Maker", new DateTime(2024, 11, 28, 11, 52, 25, 540, DateTimeKind.Local).AddTicks(4901), "A small, cozy studio apartment in the city center.", "https://example.com/cozy-studio.jpg", "Cozy Studio", 2, 800.0, 450, new DateTime(2024, 11, 28, 11, 52, 25, 540, DateTimeKind.Local).AddTicks(4904) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Rate", "Sqft", "UpdatedDate" },
                values: new object[] { "", new DateTime(2024, 11, 28, 11, 35, 48, 655, DateTimeKind.Local).AddTicks(3758), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet.", "https://dotnetmastery.com/bluevillaimages/villa3.jpg", "Royal Villa", 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
