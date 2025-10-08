using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestApp.Migrations
{
    /// <inheritdoc />
    public partial class AddActivityLogs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    UserRole = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Action = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    EntityType = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    EntityId = table.Column<int>(type: "INTEGER", nullable: true),
                    Details = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    Timestamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IpAddress = table.Column<string>(type: "TEXT", maxLength: 45, nullable: true),
                    UserAgent = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLogs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 2, 6, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5310), new DateTime(2025, 2, 24, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 8, 5, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5390), new DateTime(2025, 10, 14, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 4, 2, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5390), new DateTime(2025, 4, 11, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 12, 14, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5400), new DateTime(2025, 2, 3, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 8, 1, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5400), new DateTime(2025, 8, 11, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 1, 8, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5400), new DateTime(2025, 2, 15, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 7, 9, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5410), new DateTime(2025, 9, 18, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 9, 19, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5410), new DateTime(2025, 10, 30, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 9, 13, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5410), new DateTime(2025, 11, 18, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 4, 9, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5420), new DateTime(2025, 4, 16, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 11, 9, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5420), new DateTime(2025, 2, 1, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 5, 1, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5420), new DateTime(2025, 7, 12, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 9, 30, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5420), new DateTime(2025, 12, 19, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 8, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5430), new DateTime(2025, 8, 18, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 1, 2, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5430), new DateTime(2025, 3, 5, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 4, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5430), new DateTime(2025, 8, 27, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 5, 7, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5430), new DateTime(2025, 5, 21, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 12, 11, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5440), new DateTime(2024, 12, 18, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 28, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5440), new DateTime(2025, 8, 19, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 7, 15, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5440), new DateTime(2025, 10, 7, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 3, 18, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5450), new DateTime(2025, 5, 10, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 3, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5450), new DateTime(2025, 8, 28, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 10, 6, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5450), new DateTime(2025, 10, 28, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 11, 10, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5450), new DateTime(2025, 2, 5, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 12, 12, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5460), new DateTime(2025, 2, 19, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 2, 8, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5460), new DateTime(2025, 3, 2, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 12, 18, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5460), new DateTime(2025, 3, 8, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 8, 12, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5470), new DateTime(2025, 10, 6, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 3, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5470), new DateTime(2025, 7, 23, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 11, 1, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5470), new DateTime(2024, 11, 12, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 11, 20, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5470), new DateTime(2025, 1, 5, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 11, 30, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5480), new DateTime(2025, 1, 1, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 9, 9, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5480), new DateTime(2025, 10, 25, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 21, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5480), new DateTime(2025, 8, 15, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 22, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5480), new DateTime(2025, 9, 15, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 4, 1, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5490), new DateTime(2025, 5, 8, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 2, 7, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5490), new DateTime(2025, 2, 22, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 3, 11, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5490), new DateTime(2025, 4, 16, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 2, 11, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5500), new DateTime(2025, 3, 6, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 5, 5, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5500), new DateTime(2025, 5, 28, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 10, 18, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5500), new DateTime(2024, 12, 21, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 3, 7, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5510), new DateTime(2025, 5, 15, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 5, 8, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5510), new DateTime(2025, 5, 28, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 4, 14, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5520), new DateTime(2025, 6, 19, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 10, 30, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5520), new DateTime(2024, 12, 17, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 4, 7, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5520), new DateTime(2025, 5, 10, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 8, 12, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5520), new DateTime(2025, 9, 19, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 7, 14, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5530), new DateTime(2025, 10, 5, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 25, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5530), new DateTime(2025, 8, 16, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 3, 31, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5530), new DateTime(2025, 6, 5, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 12, 22, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5530), new DateTime(2025, 3, 9, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 12, 3, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5540), new DateTime(2024, 12, 25, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 7, 28, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5540), new DateTime(2025, 8, 26, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 12, 3, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5540), new DateTime(2025, 1, 7, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 4, 4, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5540), new DateTime(2025, 6, 30, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 1, 9, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5550), new DateTime(2025, 1, 25, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 29, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5550), new DateTime(2025, 9, 26, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 11, 4, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5550), new DateTime(2025, 1, 23, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5560), new DateTime(2025, 12, 2, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 8, 17, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5560), new DateTime(2025, 10, 14, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 5, 27, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5560), new DateTime(2025, 6, 14, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 1, 31, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5560), new DateTime(2025, 2, 19, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 26, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5570), new DateTime(2025, 7, 26, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 1, 10, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5570), new DateTime(2025, 3, 8, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 7, 25, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5570), new DateTime(2025, 9, 26, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 4, 17, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5570), new DateTime(2025, 7, 14, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5580), new DateTime(2025, 3, 10, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 7, 22, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5580), new DateTime(2025, 9, 27, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 9, 22, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5580), new DateTime(2025, 10, 11, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5590), new DateTime(2025, 1, 31, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 9, 9, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5590), new DateTime(2025, 9, 28, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 4, 5, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5590), new DateTime(2025, 6, 11, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 10, 28, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5590), new DateTime(2024, 11, 28, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 7, 15, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5600), new DateTime(2025, 9, 10, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 3, 2, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5600), new DateTime(2025, 3, 16, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 1, 16, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5600), new DateTime(2025, 3, 4, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 5, 29, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5600), new DateTime(2025, 6, 8, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 1, 29, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5610), new DateTime(2025, 3, 14, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 4, 13, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5610), new DateTime(2025, 7, 9, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 9, 9, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5610), new DateTime(2025, 9, 30, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 5, 13, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5610), new DateTime(2025, 6, 2, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 1, 15, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5620), new DateTime(2025, 3, 11, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 4, 24, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5620), new DateTime(2025, 6, 28, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 7, 28, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5620), new DateTime(2025, 8, 13, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 2, 22, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5620), new DateTime(2025, 3, 14, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 1, 4, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5630), new DateTime(2025, 2, 11, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 12, 20, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5630), new DateTime(2025, 3, 12, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 5, 6, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5630), new DateTime(2025, 5, 19, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 9, 18, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5640), new DateTime(2025, 12, 2, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 8, 28, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5640), new DateTime(2025, 11, 1, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 10, 4, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5640), new DateTime(2025, 12, 9, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 11, 4, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5640), new DateTime(2024, 11, 25, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 5, 8, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5650), new DateTime(2025, 7, 16, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 11, 24, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5650), new DateTime(2025, 1, 13, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 1, 1, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5650), new DateTime(2025, 3, 8, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 8, 28, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5650), new DateTime(2025, 9, 29, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 2, 6, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5660), new DateTime(2025, 2, 25, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 2, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5660), new DateTime(2025, 7, 14, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 8, 19, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5660), new DateTime(2025, 10, 21, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 10, 20, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5660), new DateTime(2024, 12, 9, 18, 12, 30, 686, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityLogs_Action",
                table: "ActivityLogs",
                column: "Action");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityLogs_Timestamp",
                table: "ActivityLogs",
                column: "Timestamp");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityLogs_UserName",
                table: "ActivityLogs",
                column: "UserName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityLogs");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 2, 5, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5350), new DateTime(2025, 2, 23, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 8, 4, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5430), new DateTime(2025, 10, 13, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 4, 1, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5430), new DateTime(2025, 4, 10, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 12, 13, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5440), new DateTime(2025, 2, 2, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 7, 31, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5440), new DateTime(2025, 8, 10, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 1, 7, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5440), new DateTime(2025, 2, 14, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 7, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5450), new DateTime(2025, 9, 17, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 9, 18, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5450), new DateTime(2025, 10, 29, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 9, 12, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5450), new DateTime(2025, 11, 17, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 4, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5450), new DateTime(2025, 4, 15, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 11, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5460), new DateTime(2025, 1, 31, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 4, 30, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5460), new DateTime(2025, 7, 11, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 9, 29, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5460), new DateTime(2025, 12, 18, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 7, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5460), new DateTime(2025, 8, 17, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 1, 1, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5470), new DateTime(2025, 3, 4, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 3, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5470), new DateTime(2025, 8, 26, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 5, 6, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5470), new DateTime(2025, 5, 20, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 12, 10, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5470), new DateTime(2024, 12, 17, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5480), new DateTime(2025, 8, 18, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 7, 14, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5480), new DateTime(2025, 10, 6, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 3, 17, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5480), new DateTime(2025, 5, 9, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5480), new DateTime(2025, 8, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 10, 5, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5490), new DateTime(2025, 10, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 11, 9, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5490), new DateTime(2025, 2, 4, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 12, 11, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5490), new DateTime(2025, 2, 18, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 2, 7, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5500), new DateTime(2025, 3, 1, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 12, 17, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5500), new DateTime(2025, 3, 7, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 8, 11, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5500), new DateTime(2025, 10, 5, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 2, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5500), new DateTime(2025, 7, 22, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 10, 31, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5510), new DateTime(2024, 11, 11, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 11, 19, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5510), new DateTime(2025, 1, 4, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 11, 29, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5510), new DateTime(2024, 12, 31, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 9, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5510), new DateTime(2025, 10, 24, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 20, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5520), new DateTime(2025, 8, 14, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 21, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5520), new DateTime(2025, 9, 14, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 3, 31, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5520), new DateTime(2025, 5, 7, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 2, 6, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5520), new DateTime(2025, 2, 21, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 3, 10, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5530), new DateTime(2025, 4, 15, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 2, 10, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5530), new DateTime(2025, 3, 5, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 5, 4, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5530), new DateTime(2025, 5, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 10, 17, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5530), new DateTime(2024, 12, 20, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 3, 6, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5540), new DateTime(2025, 5, 14, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 5, 7, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5540), new DateTime(2025, 5, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 4, 13, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5540), new DateTime(2025, 6, 18, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 10, 29, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5540), new DateTime(2024, 12, 16, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 4, 6, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5550), new DateTime(2025, 5, 9, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 8, 11, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5550), new DateTime(2025, 9, 18, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 7, 13, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5550), new DateTime(2025, 10, 4, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 24, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5550), new DateTime(2025, 8, 15, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 3, 30, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5560), new DateTime(2025, 6, 4, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 12, 21, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5560), new DateTime(2025, 3, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 12, 2, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5560), new DateTime(2024, 12, 24, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 7, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5560), new DateTime(2025, 8, 25, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 12, 2, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5570), new DateTime(2025, 1, 6, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 4, 3, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5570), new DateTime(2025, 6, 29, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 1, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5570), new DateTime(2025, 1, 24, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 28, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5570), new DateTime(2025, 9, 25, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5580), new DateTime(2025, 1, 22, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 9, 17, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5580), new DateTime(2025, 12, 1, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 8, 16, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5580), new DateTime(2025, 10, 13, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 5, 26, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5580), new DateTime(2025, 6, 13, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 1, 30, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5590), new DateTime(2025, 2, 18, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 25, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5590), new DateTime(2025, 7, 25, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 1, 9, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5590), new DateTime(2025, 3, 7, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 7, 24, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5590), new DateTime(2025, 9, 25, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 4, 16, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5600), new DateTime(2025, 7, 13, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 2, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5600), new DateTime(2025, 3, 9, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 7, 21, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5600), new DateTime(2025, 9, 26, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 9, 21, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5610), new DateTime(2025, 10, 10, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 11, 12, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5630), new DateTime(2025, 1, 30, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 9, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5630), new DateTime(2025, 9, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 4, 4, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5630), new DateTime(2025, 6, 10, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 10, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5630), new DateTime(2024, 11, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 7, 14, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5640), new DateTime(2025, 9, 9, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5640), new DateTime(2025, 3, 15, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5640), new DateTime(2025, 3, 3, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 5, 28, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5640), new DateTime(2025, 6, 7, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 1, 28, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5650), new DateTime(2025, 3, 13, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 4, 12, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5650), new DateTime(2025, 7, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 9, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5650), new DateTime(2025, 9, 29, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 5, 12, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5650), new DateTime(2025, 6, 1, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 1, 14, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5660), new DateTime(2025, 3, 10, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 4, 23, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5660), new DateTime(2025, 6, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 7, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5660), new DateTime(2025, 8, 12, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 2, 21, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5660), new DateTime(2025, 3, 13, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 1, 3, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5670), new DateTime(2025, 2, 10, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 12, 19, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5670), new DateTime(2025, 3, 11, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 5, 5, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5670), new DateTime(2025, 5, 18, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 9, 17, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5670), new DateTime(2025, 12, 1, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 8, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5680), new DateTime(2025, 10, 31, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 10, 3, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5680), new DateTime(2025, 12, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5680), new DateTime(2024, 11, 24, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 5, 7, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5680), new DateTime(2025, 7, 15, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 11, 23, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5690), new DateTime(2025, 1, 12, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 12, 31, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5690), new DateTime(2025, 3, 7, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 8, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5690), new DateTime(2025, 9, 28, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 2, 5, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5690), new DateTime(2025, 2, 24, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 6, 1, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5700), new DateTime(2025, 7, 13, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2025, 8, 18, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5700), new DateTime(2025, 10, 20, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "ValidQuotePeriod" },
                values: new object[] { new DateTime(2024, 10, 19, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5700), new DateTime(2024, 12, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5700) });
        }
    }
}
