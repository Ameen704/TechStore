using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechStore.Migrations
{
    /// <inheritdoc />
    public partial class SyncModelAfterSeedFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 9, 17, 22, 16, 10, 741, DateTimeKind.Local).AddTicks(8455), new DateTime(2025, 9, 17, 22, 16, 10, 744, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 9, 17, 22, 16, 10, 744, DateTimeKind.Local).AddTicks(8863), new DateTime(2025, 9, 17, 22, 16, 10, 744, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 9, 17, 22, 16, 10, 744, DateTimeKind.Local).AddTicks(8883), new DateTime(2025, 9, 17, 22, 16, 10, 744, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 9, 17, 22, 16, 10, 744, DateTimeKind.Local).AddTicks(8888), new DateTime(2025, 9, 17, 22, 16, 10, 744, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 9, 17, 22, 16, 10, 744, DateTimeKind.Local).AddTicks(8892), new DateTime(2025, 9, 17, 22, 16, 10, 744, DateTimeKind.Local).AddTicks(8894) });
        }
    }
}
