using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "78550f73-9fe8-42d4-9f8d-8673e59f619a", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENBjnNRUqPEKexjdLmHt4WqPdUF8YOFcZp+jHkJezRsWrXuPxvl8bEgwVi6UFye42w==", null, false, "615377d4-ad80-405a-942f-94ee009486df", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 21, 47, 475, DateTimeKind.Local).AddTicks(7897), new DateTime(2025, 12, 3, 16, 21, 47, 475, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 21, 47, 475, DateTimeKind.Local).AddTicks(7911), new DateTime(2025, 12, 3, 16, 21, 47, 475, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 21, 47, 475, DateTimeKind.Local).AddTicks(8126), new DateTime(2025, 12, 3, 16, 21, 47, 475, DateTimeKind.Local).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 21, 47, 475, DateTimeKind.Local).AddTicks(8129), new DateTime(2025, 12, 3, 16, 21, 47, 475, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 21, 47, 475, DateTimeKind.Local).AddTicks(8269), new DateTime(2025, 12, 3, 16, 21, 47, 475, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 21, 47, 475, DateTimeKind.Local).AddTicks(8272), new DateTime(2025, 12, 3, 16, 21, 47, 475, DateTimeKind.Local).AddTicks(8272) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 21, 47, 475, DateTimeKind.Local).AddTicks(8274), new DateTime(2025, 12, 3, 16, 21, 47, 475, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 21, 47, 475, DateTimeKind.Local).AddTicks(8276), new DateTime(2025, 12, 3, 16, 21, 47, 475, DateTimeKind.Local).AddTicks(8276) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 38, 4, 927, DateTimeKind.Local).AddTicks(7095), new DateTime(2025, 12, 3, 15, 38, 4, 927, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 38, 4, 927, DateTimeKind.Local).AddTicks(7115), new DateTime(2025, 12, 3, 15, 38, 4, 927, DateTimeKind.Local).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 38, 4, 927, DateTimeKind.Local).AddTicks(7423), new DateTime(2025, 12, 3, 15, 38, 4, 927, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 38, 4, 927, DateTimeKind.Local).AddTicks(7427), new DateTime(2025, 12, 3, 15, 38, 4, 927, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 38, 4, 927, DateTimeKind.Local).AddTicks(7558), new DateTime(2025, 12, 3, 15, 38, 4, 927, DateTimeKind.Local).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 38, 4, 927, DateTimeKind.Local).AddTicks(7562), new DateTime(2025, 12, 3, 15, 38, 4, 927, DateTimeKind.Local).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 38, 4, 927, DateTimeKind.Local).AddTicks(7565), new DateTime(2025, 12, 3, 15, 38, 4, 927, DateTimeKind.Local).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 38, 4, 927, DateTimeKind.Local).AddTicks(7568), new DateTime(2025, 12, 3, 15, 38, 4, 927, DateTimeKind.Local).AddTicks(7569) });
        }
    }
}
