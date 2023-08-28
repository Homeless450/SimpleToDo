using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Patronymic",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15c6d539-e1a8-4357-abd6-5b10e54862fa", null, "User", null },
                    { "72b5e54d-5855-4e0f-8def-8eda38482d7e", null, "Admin", null }
                });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDay", "StartDay" },
                values: new object[] { new DateTime(2023, 8, 30, 15, 32, 47, 987, DateTimeKind.Local).AddTicks(2744), new DateTime(2023, 8, 28, 15, 32, 47, 987, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDay", "StartDay" },
                values: new object[] { new DateTime(2023, 8, 30, 15, 32, 47, 987, DateTimeKind.Local).AddTicks(2767), new DateTime(2023, 8, 28, 15, 32, 47, 987, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDay", "StartDay" },
                values: new object[] { new DateTime(2023, 8, 31, 15, 32, 47, 987, DateTimeKind.Local).AddTicks(2769), new DateTime(2023, 8, 28, 15, 32, 47, 987, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDay", "StartDay" },
                values: new object[] { new DateTime(2023, 9, 1, 15, 32, 47, 987, DateTimeKind.Local).AddTicks(2771), new DateTime(2023, 8, 28, 15, 32, 47, 987, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDay", "StartDay" },
                values: new object[] { new DateTime(2023, 8, 28, 15, 32, 47, 987, DateTimeKind.Local).AddTicks(2772), new DateTime(2023, 8, 27, 15, 32, 47, 987, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDay", "StartDay" },
                values: new object[] { new DateTime(2023, 8, 28, 15, 32, 47, 987, DateTimeKind.Local).AddTicks(2801), new DateTime(2023, 8, 27, 15, 32, 47, 987, DateTimeKind.Local).AddTicks(2802) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15c6d539-e1a8-4357-abd6-5b10e54862fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72b5e54d-5855-4e0f-8def-8eda38482d7e");

            migrationBuilder.AlterColumn<string>(
                name: "Patronymic",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDay", "StartDay" },
                values: new object[] { new DateTime(2023, 8, 30, 14, 58, 39, 817, DateTimeKind.Local).AddTicks(835), new DateTime(2023, 8, 28, 14, 58, 39, 817, DateTimeKind.Local).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDay", "StartDay" },
                values: new object[] { new DateTime(2023, 8, 30, 14, 58, 39, 817, DateTimeKind.Local).AddTicks(859), new DateTime(2023, 8, 28, 14, 58, 39, 817, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDay", "StartDay" },
                values: new object[] { new DateTime(2023, 8, 31, 14, 58, 39, 817, DateTimeKind.Local).AddTicks(862), new DateTime(2023, 8, 28, 14, 58, 39, 817, DateTimeKind.Local).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDay", "StartDay" },
                values: new object[] { new DateTime(2023, 9, 1, 14, 58, 39, 817, DateTimeKind.Local).AddTicks(863), new DateTime(2023, 8, 28, 14, 58, 39, 817, DateTimeKind.Local).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDay", "StartDay" },
                values: new object[] { new DateTime(2023, 8, 28, 14, 58, 39, 817, DateTimeKind.Local).AddTicks(865), new DateTime(2023, 8, 27, 14, 58, 39, 817, DateTimeKind.Local).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDay", "StartDay" },
                values: new object[] { new DateTime(2023, 8, 28, 14, 58, 39, 817, DateTimeKind.Local).AddTicks(867), new DateTime(2023, 8, 27, 14, 58, 39, 817, DateTimeKind.Local).AddTicks(867) });
        }
    }
}
