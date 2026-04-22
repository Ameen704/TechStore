using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechStore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategoriesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 9, 18, 0, 10, 40, 454, DateTimeKind.Local).AddTicks(357), new DateTime(2025, 9, 18, 0, 10, 40, 457, DateTimeKind.Local).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 9, 18, 0, 10, 40, 457, DateTimeKind.Local).AddTicks(2154), new DateTime(2025, 9, 18, 0, 10, 40, 457, DateTimeKind.Local).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 9, 18, 0, 10, 40, 457, DateTimeKind.Local).AddTicks(2170), new DateTime(2025, 9, 18, 0, 10, 40, 457, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 9, 18, 0, 10, 40, 457, DateTimeKind.Local).AddTicks(2174), new DateTime(2025, 9, 18, 0, 10, 40, 457, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 9, 18, 0, 10, 40, 457, DateTimeKind.Local).AddTicks(2178), new DateTime(2025, 9, 18, 0, 10, 40, 457, DateTimeKind.Local).AddTicks(2180) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 9, 17, 22, 41, 24, 389, DateTimeKind.Local).AddTicks(8402), new DateTime(2025, 9, 17, 22, 41, 24, 392, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 9, 17, 22, 41, 24, 392, DateTimeKind.Local).AddTicks(6177), new DateTime(2025, 9, 17, 22, 41, 24, 392, DateTimeKind.Local).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 9, 17, 22, 41, 24, 392, DateTimeKind.Local).AddTicks(6198), new DateTime(2025, 9, 17, 22, 41, 24, 392, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 9, 17, 22, 41, 24, 392, DateTimeKind.Local).AddTicks(6202), new DateTime(2025, 9, 17, 22, 41, 24, 392, DateTimeKind.Local).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 9, 17, 22, 41, 24, 392, DateTimeKind.Local).AddTicks(6206), new DateTime(2025, 9, 17, 22, 41, 24, 392, DateTimeKind.Local).AddTicks(6208) });
        }
    }
}
