using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 12, 56, 338, DateTimeKind.Local).AddTicks(879), new DateTime(2025, 12, 3, 15, 12, 56, 338, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 12, 56, 338, DateTimeKind.Local).AddTicks(897), new DateTime(2025, 12, 3, 15, 12, 56, 338, DateTimeKind.Local).AddTicks(898) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 12, 56, 338, DateTimeKind.Local).AddTicks(1085), new DateTime(2025, 12, 3, 15, 12, 56, 338, DateTimeKind.Local).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Name" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 12, 56, 338, DateTimeKind.Local).AddTicks(1088), new DateTime(2025, 12, 3, 15, 12, 56, 338, DateTimeKind.Local).AddTicks(1089), "Toyota" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 12, 56, 338, DateTimeKind.Local).AddTicks(1155), new DateTime(2025, 12, 3, 15, 12, 56, 338, DateTimeKind.Local).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 12, 56, 338, DateTimeKind.Local).AddTicks(1158), new DateTime(2025, 12, 3, 15, 12, 56, 338, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 12, 56, 338, DateTimeKind.Local).AddTicks(1160), new DateTime(2025, 12, 3, 15, 12, 56, 338, DateTimeKind.Local).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 12, 56, 338, DateTimeKind.Local).AddTicks(1162), new DateTime(2025, 12, 3, 15, 12, 56, 338, DateTimeKind.Local).AddTicks(1162) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 11, 28, 619, DateTimeKind.Local).AddTicks(2645), new DateTime(2025, 12, 3, 15, 11, 28, 619, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 11, 28, 619, DateTimeKind.Local).AddTicks(2659), new DateTime(2025, 12, 3, 15, 11, 28, 619, DateTimeKind.Local).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 11, 28, 619, DateTimeKind.Local).AddTicks(2849), new DateTime(2025, 12, 3, 15, 11, 28, 619, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Name" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 11, 28, 619, DateTimeKind.Local).AddTicks(2852), new DateTime(2025, 12, 3, 15, 11, 28, 619, DateTimeKind.Local).AddTicks(2853), "Ferrari" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 11, 28, 619, DateTimeKind.Local).AddTicks(2924), new DateTime(2025, 12, 3, 15, 11, 28, 619, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 11, 28, 619, DateTimeKind.Local).AddTicks(2927), new DateTime(2025, 12, 3, 15, 11, 28, 619, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 11, 28, 619, DateTimeKind.Local).AddTicks(2929), new DateTime(2025, 12, 3, 15, 11, 28, 619, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 11, 28, 619, DateTimeKind.Local).AddTicks(2931), new DateTime(2025, 12, 3, 15, 11, 28, 619, DateTimeKind.Local).AddTicks(2931) });
        }
    }
}
