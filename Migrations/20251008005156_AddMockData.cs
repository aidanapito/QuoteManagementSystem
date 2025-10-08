using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestApp.Migrations
{
    /// <inheritdoc />
    public partial class AddMockData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comments", "CreatedDate", "CustomerName", "ProductName", "Quantity", "Status", "UnitPrice", "ValidQuotePeriod" },
                values: new object[] { "Special pricing", new DateTime(2025, 2, 5, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5350), "Global Industries", "Custom Widget", 26, "Approved", 178.43m, new DateTime(2025, 2, 23, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Comments", "CreatedDate", "CustomerName", "ProductName", "Quantity", "UnitPrice", "ValidQuotePeriod" },
                values: new object[] { "Priority customer", new DateTime(2025, 8, 4, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5430), "MegaCorp Ltd", "Standard Widget", 32, 515.60m, new DateTime(2025, 10, 13, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Comments", "CreatedDate", "CustomerName", "ProductName", "Quantity", "Status", "UnitPrice", "ValidQuotePeriod" },
                values: new object[] { "First-time customer", new DateTime(2025, 4, 1, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5430), "Kappa Corp", "Special Widget", 16, "Draft", 407.47m, new DateTime(2025, 4, 10, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Comments", "CreatedDate", "CustomerName", "ProductName", "Quantity", "Status", "UnitPrice", "ValidQuotePeriod" },
                values: new object[] { "Special pricing", new DateTime(2024, 12, 13, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5440), "Acme Corp", "Ultra Widget", 90, "Approved", 157.76m, new DateTime(2025, 2, 2, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Comments", "CreatedDate", "CustomerName", "ProductName", "Quantity", "Status", "UnitPrice", "ValidQuotePeriod" },
                values: new object[,]
                {
                    { 5, "Emergency order", new DateTime(2025, 7, 31, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5440), "Future Systems", "Special Widget", 1, "Approved", 831.07m, new DateTime(2025, 8, 10, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5440) },
                    { 6, "Rush delivery requested", new DateTime(2025, 1, 7, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5440), "Global Industries", "Widget A", 78, "Approved", 61.01m, new DateTime(2025, 2, 14, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5440) },
                    { 7, "Special pricing", new DateTime(2025, 7, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5450), "Innovation Co", "Advanced Widget", 5, "Approved", 153.65m, new DateTime(2025, 9, 17, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5450) },
                    { 8, "Bulk discount applied", new DateTime(2025, 9, 18, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5450), "Theta Group", "Advanced Widget", 2, "Pending", 228.45m, new DateTime(2025, 10, 29, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5450) },
                    { 9, "Special pricing", new DateTime(2025, 9, 12, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5450), "Tech Solutions", "Enterprise Widget", 79, "Pending", 22.03m, new DateTime(2025, 11, 17, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5450) },
                    { 10, "", new DateTime(2025, 4, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5450), "Kappa Corp", "Widget A", 7, "Approved", 13.07m, new DateTime(2025, 4, 15, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5450) },
                    { 11, "Standard processing", new DateTime(2024, 11, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5460), "Gamma Corp", "Basic Widget", 5, "Pending", 626.61m, new DateTime(2025, 1, 31, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5460) },
                    { 12, "VIP customer", new DateTime(2025, 4, 30, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5460), "Delta Enterprises", "Pro Widget", 90, "Approved", 307.37m, new DateTime(2025, 7, 11, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5460) },
                    { 13, "Expedited shipping", new DateTime(2025, 9, 29, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5460), "Nu Technologies", "Deluxe Widget", 17, "Draft", 720.70m, new DateTime(2025, 12, 18, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5460) },
                    { 14, "New product line", new DateTime(2025, 6, 7, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5460), "Global Industries", "Widget C", 59, "Approved", 225.66m, new DateTime(2025, 8, 17, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5460) },
                    { 15, "", new DateTime(2025, 1, 1, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5470), "Theta Group", "Standard Widget", 98, "Approved", 562.06m, new DateTime(2025, 3, 4, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5470) },
                    { 16, "Volume discount", new DateTime(2025, 6, 3, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5470), "Acme Corp", "Premium Widget", 4, "Draft", 275.44m, new DateTime(2025, 8, 26, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5470) },
                    { 17, "VIP customer", new DateTime(2025, 5, 6, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5470), "Nu Technologies", "Widget C", 32, "Pending", 116.09m, new DateTime(2025, 5, 20, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5470) },
                    { 18, "Emergency order", new DateTime(2024, 12, 10, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5470), "Acme Corp", "Giga Widget", 24, "Rejected", 905.89m, new DateTime(2024, 12, 17, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5470) },
                    { 19, "", new DateTime(2025, 6, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5480), "Zeta Manufacturing", "Advanced Widget", 30, "Draft", 202.31m, new DateTime(2025, 8, 18, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5480) },
                    { 20, "Bulk discount applied", new DateTime(2025, 7, 14, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5480), "Nu Technologies", "Mega Widget", 88, "Draft", 145.22m, new DateTime(2025, 10, 6, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5480) },
                    { 21, "Expedited shipping", new DateTime(2025, 3, 17, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5480), "Theta Group", "Widget C", 39, "Rejected", 608.18m, new DateTime(2025, 5, 9, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5480) },
                    { 22, "Rush delivery requested", new DateTime(2025, 6, 2, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5480), "Gamma Corp", "Custom Widget", 81, "Draft", 957.74m, new DateTime(2025, 8, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5480) },
                    { 23, "Rush delivery requested", new DateTime(2025, 10, 5, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5490), "Mu Solutions", "Ultra Widget", 59, "Pending", 414.00m, new DateTime(2025, 10, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5490) },
                    { 24, "New product line", new DateTime(2024, 11, 9, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5490), "Lambda Industries", "Widget D", 54, "Approved", 343.88m, new DateTime(2025, 2, 4, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5490) },
                    { 25, "Regular customer", new DateTime(2024, 12, 11, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5490), "Innovation Co", "Deluxe Widget", 80, "Draft", 535.59m, new DateTime(2025, 2, 18, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5490) },
                    { 26, "Expedited shipping", new DateTime(2025, 2, 7, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5500), "Innovation Co", "Premium Widget", 64, "Draft", 843.62m, new DateTime(2025, 3, 1, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5500) },
                    { 27, "New product line", new DateTime(2024, 12, 17, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5500), "Iota Systems", "Exa Widget", 47, "Rejected", 953.10m, new DateTime(2025, 3, 7, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5500) },
                    { 28, "Emergency order", new DateTime(2025, 8, 11, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5500), "MegaCorp Ltd", "Advanced Widget", 71, "Draft", 510.90m, new DateTime(2025, 10, 5, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5500) },
                    { 29, "Standard processing", new DateTime(2025, 6, 2, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5500), "Theta Group", "Premium Widget", 79, "Approved", 539.83m, new DateTime(2025, 7, 22, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5500) },
                    { 30, "Bulk discount applied", new DateTime(2024, 10, 31, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5510), "Tech Solutions", "Premium Widget", 17, "Pending", 323.67m, new DateTime(2024, 11, 11, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5510) },
                    { 31, "Custom configuration", new DateTime(2024, 11, 19, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5510), "Alpha Industries", "Enterprise Widget", 66, "Rejected", 773.41m, new DateTime(2025, 1, 4, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5510) },
                    { 32, "New product line", new DateTime(2024, 11, 29, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5510), "StartUp Inc", "Peta Widget", 61, "Pending", 603.05m, new DateTime(2024, 12, 31, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5510) },
                    { 33, "", new DateTime(2025, 9, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5510), "Lambda Industries", "Deluxe Widget", 88, "Rejected", 929.34m, new DateTime(2025, 10, 24, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5510) },
                    { 34, "New product line", new DateTime(2025, 6, 20, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5520), "Acme Corp", "Tera Widget", 67, "Approved", 420.93m, new DateTime(2025, 8, 14, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5520) },
                    { 35, "First-time customer", new DateTime(2025, 6, 21, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5520), "Iota Systems", "Widget A", 66, "Draft", 350.80m, new DateTime(2025, 9, 14, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5520) },
                    { 36, "Bulk discount applied", new DateTime(2025, 3, 31, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5520), "Future Systems", "Premium Widget", 64, "Approved", 615.14m, new DateTime(2025, 5, 7, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5520) },
                    { 37, "", new DateTime(2025, 2, 6, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5520), "Global Industries", "Giga Widget", 97, "Pending", 300.87m, new DateTime(2025, 2, 21, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5520) },
                    { 38, "Standard processing", new DateTime(2025, 3, 10, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5530), "StartUp Inc", "Widget D", 11, "Rejected", 653.95m, new DateTime(2025, 4, 15, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5530) },
                    { 39, "Expedited shipping", new DateTime(2025, 2, 10, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5530), "Zeta Manufacturing", "Super Widget", 36, "Approved", 870.62m, new DateTime(2025, 3, 5, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5530) },
                    { 40, "Annual contract", new DateTime(2025, 5, 4, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5530), "Iota Systems", "Special Widget", 67, "Pending", 547.53m, new DateTime(2025, 5, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5530) },
                    { 41, "Bulk discount applied", new DateTime(2024, 10, 17, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5530), "MegaCorp Ltd", "Deluxe Widget", 81, "Approved", 550.41m, new DateTime(2024, 12, 20, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5530) },
                    { 42, "Expedited shipping", new DateTime(2025, 3, 6, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5540), "Gamma Corp", "Exa Widget", 86, "Draft", 511.81m, new DateTime(2025, 5, 14, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5540) },
                    { 43, "Bulk discount applied", new DateTime(2025, 5, 7, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5540), "Epsilon Tech", "Pro Widget", 95, "Pending", 11.81m, new DateTime(2025, 5, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5540) },
                    { 44, "Regular customer", new DateTime(2025, 4, 13, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5540), "Beta Solutions", "Widget B", 79, "Pending", 198.40m, new DateTime(2025, 6, 18, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5540) },
                    { 45, "Emergency order", new DateTime(2024, 10, 29, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5540), "MegaCorp Ltd", "Peta Widget", 63, "Approved", 892.95m, new DateTime(2024, 12, 16, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5540) },
                    { 46, "Volume discount", new DateTime(2025, 4, 6, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5550), "Tech Solutions", "Widget C", 62, "Rejected", 914.71m, new DateTime(2025, 5, 9, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5550) },
                    { 47, "", new DateTime(2025, 8, 11, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5550), "Global Industries", "Basic Widget", 1, "Approved", 119.46m, new DateTime(2025, 9, 18, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5550) },
                    { 48, "VIP customer", new DateTime(2025, 7, 13, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5550), "Kappa Corp", "Giga Widget", 60, "Draft", 408.96m, new DateTime(2025, 10, 4, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5550) },
                    { 49, "VIP customer", new DateTime(2025, 6, 24, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5550), "Tech Solutions", "Widget A", 10, "Approved", 661.01m, new DateTime(2025, 8, 15, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5550) },
                    { 50, "Emergency order", new DateTime(2025, 3, 30, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5560), "Mu Solutions", "Super Widget", 35, "Pending", 899.82m, new DateTime(2025, 6, 4, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5560) },
                    { 51, "New product line", new DateTime(2024, 12, 21, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5560), "Mu Solutions", "Giga Widget", 9, "Rejected", 672.70m, new DateTime(2025, 3, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5560) },
                    { 52, "Regular customer", new DateTime(2024, 12, 2, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5560), "Theta Group", "Exa Widget", 81, "Pending", 816.31m, new DateTime(2024, 12, 24, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5560) },
                    { 53, "", new DateTime(2025, 7, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5560), "Kappa Corp", "Basic Widget", 91, "Rejected", 585.33m, new DateTime(2025, 8, 25, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5560) },
                    { 54, "Regular customer", new DateTime(2024, 12, 2, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5570), "Lambda Industries", "Basic Widget", 97, "Draft", 113.83m, new DateTime(2025, 1, 6, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5570) },
                    { 55, "Standard processing", new DateTime(2025, 4, 3, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5570), "Acme Corp", "Special Widget", 32, "Draft", 666.72m, new DateTime(2025, 6, 29, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5570) },
                    { 56, "First-time customer", new DateTime(2025, 1, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5570), "StartUp Inc", "Enterprise Widget", 56, "Rejected", 392.30m, new DateTime(2025, 1, 24, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5570) },
                    { 57, "Regular customer", new DateTime(2025, 6, 28, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5570), "Gamma Corp", "Advanced Widget", 5, "Pending", 541.63m, new DateTime(2025, 9, 25, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5570) },
                    { 58, "Regular customer", new DateTime(2024, 11, 3, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5580), "Nu Technologies", "Deluxe Widget", 41, "Rejected", 249.17m, new DateTime(2025, 1, 22, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5580) },
                    { 59, "Regular customer", new DateTime(2025, 9, 17, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5580), "Gamma Corp", "Giga Widget", 89, "Pending", 793.41m, new DateTime(2025, 12, 1, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5580) },
                    { 60, "Bulk discount applied", new DateTime(2025, 8, 16, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5580), "Zeta Manufacturing", "Enterprise Widget", 45, "Approved", 775.27m, new DateTime(2025, 10, 13, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5580) },
                    { 61, "Special pricing", new DateTime(2025, 5, 26, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5580), "Global Industries", "Widget C", 51, "Pending", 504.19m, new DateTime(2025, 6, 13, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5580) },
                    { 62, "Custom configuration", new DateTime(2025, 1, 30, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5590), "Zeta Manufacturing", "Mega Widget", 81, "Rejected", 363.23m, new DateTime(2025, 2, 18, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5590) },
                    { 63, "Custom configuration", new DateTime(2025, 6, 25, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5590), "Beta Solutions", "Special Widget", 15, "Rejected", 120.13m, new DateTime(2025, 7, 25, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5590) },
                    { 64, "Special pricing", new DateTime(2025, 1, 9, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5590), "Gamma Corp", "Peta Widget", 82, "Draft", 440.13m, new DateTime(2025, 3, 7, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5590) },
                    { 65, "Volume discount", new DateTime(2025, 7, 24, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5590), "Mu Solutions", "Widget B", 72, "Pending", 304.65m, new DateTime(2025, 9, 25, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5590) },
                    { 66, "Bulk discount applied", new DateTime(2025, 4, 16, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5600), "StartUp Inc", "Advanced Widget", 48, "Approved", 272.61m, new DateTime(2025, 7, 13, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5600) },
                    { 67, "Priority customer", new DateTime(2025, 2, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5600), "StartUp Inc", "Enterprise Widget", 13, "Draft", 54.29m, new DateTime(2025, 3, 9, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5600) },
                    { 68, "Emergency order", new DateTime(2025, 7, 21, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5600), "Alpha Industries", "Tera Widget", 44, "Draft", 45.25m, new DateTime(2025, 9, 26, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5600) },
                    { 69, "Volume discount", new DateTime(2025, 9, 21, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5610), "Epsilon Tech", "Super Widget", 86, "Draft", 876.37m, new DateTime(2025, 10, 10, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5610) },
                    { 70, "Bulk discount applied", new DateTime(2024, 11, 12, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5630), "Tech Solutions", "Widget C", 30, "Draft", 999.59m, new DateTime(2025, 1, 30, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5630) },
                    { 71, "Rush delivery requested", new DateTime(2025, 9, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5630), "MegaCorp Ltd", "Widget D", 63, "Pending", 658.88m, new DateTime(2025, 9, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5630) },
                    { 72, "", new DateTime(2025, 4, 4, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5630), "Lambda Industries", "Special Widget", 49, "Approved", 366.35m, new DateTime(2025, 6, 10, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5630) },
                    { 73, "Emergency order", new DateTime(2024, 10, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5630), "Epsilon Tech", "Widget C", 85, "Pending", 914.10m, new DateTime(2024, 11, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5630) },
                    { 74, "Regular customer", new DateTime(2025, 7, 14, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5640), "Epsilon Tech", "Widget D", 5, "Draft", 57.30m, new DateTime(2025, 9, 9, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5640) },
                    { 75, "Expedited shipping", new DateTime(2025, 3, 1, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5640), "Kappa Corp", "Tera Widget", 88, "Draft", 202.45m, new DateTime(2025, 3, 15, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5640) },
                    { 76, "Expedited shipping", new DateTime(2025, 1, 15, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5640), "StartUp Inc", "Widget C", 48, "Draft", 986.19m, new DateTime(2025, 3, 3, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5640) },
                    { 77, "Priority customer", new DateTime(2025, 5, 28, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5640), "StartUp Inc", "Super Widget", 2, "Pending", 719.89m, new DateTime(2025, 6, 7, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5640) },
                    { 78, "Expedited shipping", new DateTime(2025, 1, 28, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5650), "Mu Solutions", "Widget A", 25, "Draft", 55.64m, new DateTime(2025, 3, 13, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5650) },
                    { 79, "", new DateTime(2025, 4, 12, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5650), "Nu Technologies", "Standard Widget", 62, "Rejected", 684.96m, new DateTime(2025, 7, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5650) },
                    { 80, "VIP customer", new DateTime(2025, 9, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5650), "Alpha Industries", "Pro Widget", 32, "Rejected", 700.89m, new DateTime(2025, 9, 29, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5650) },
                    { 81, "Volume discount", new DateTime(2025, 5, 12, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5650), "Kappa Corp", "Widget A", 54, "Draft", 880.29m, new DateTime(2025, 6, 1, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5650) },
                    { 82, "Special pricing", new DateTime(2025, 1, 14, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5660), "StartUp Inc", "Ultra Widget", 18, "Pending", 970.20m, new DateTime(2025, 3, 10, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5660) },
                    { 83, "VIP customer", new DateTime(2025, 4, 23, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5660), "Eta Services", "Widget A", 94, "Approved", 522.79m, new DateTime(2025, 6, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5660) },
                    { 84, "Custom configuration", new DateTime(2025, 7, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5660), "Zeta Manufacturing", "Custom Widget", 95, "Approved", 642.15m, new DateTime(2025, 8, 12, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5660) },
                    { 85, "New product line", new DateTime(2025, 2, 21, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5660), "Zeta Manufacturing", "Tera Widget", 3, "Approved", 446.49m, new DateTime(2025, 3, 13, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5660) },
                    { 86, "Regular customer", new DateTime(2025, 1, 3, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5670), "Delta Enterprises", "Widget B", 10, "Draft", 438.48m, new DateTime(2025, 2, 10, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5670) },
                    { 87, "Expedited shipping", new DateTime(2024, 12, 19, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5670), "Nu Technologies", "Exa Widget", 81, "Draft", 673.06m, new DateTime(2025, 3, 11, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5670) },
                    { 88, "VIP customer", new DateTime(2025, 5, 5, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5670), "Kappa Corp", "Mega Widget", 67, "Rejected", 928.18m, new DateTime(2025, 5, 18, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5670) },
                    { 89, "Expedited shipping", new DateTime(2025, 9, 17, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5670), "Global Industries", "Mega Widget", 49, "Draft", 551.29m, new DateTime(2025, 12, 1, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5670) },
                    { 90, "Rush delivery requested", new DateTime(2025, 8, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5680), "MegaCorp Ltd", "Widget C", 65, "Pending", 426.26m, new DateTime(2025, 10, 31, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5680) },
                    { 91, "Emergency order", new DateTime(2025, 10, 3, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5680), "Theta Group", "Ultra Widget", 54, "Approved", 1006.30m, new DateTime(2025, 12, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5680) },
                    { 92, "Rush delivery requested", new DateTime(2024, 11, 3, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5680), "Gamma Corp", "Basic Widget", 83, "Draft", 227.56m, new DateTime(2024, 11, 24, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5680) },
                    { 93, "Bulk discount applied", new DateTime(2025, 5, 7, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5680), "Acme Corp", "Advanced Widget", 31, "Pending", 990.52m, new DateTime(2025, 7, 15, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5680) },
                    { 94, "VIP customer", new DateTime(2024, 11, 23, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5690), "Lambda Industries", "Exa Widget", 11, "Draft", 578.37m, new DateTime(2025, 1, 12, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5690) },
                    { 95, "Special pricing", new DateTime(2024, 12, 31, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5690), "Theta Group", "Premium Widget", 24, "Rejected", 942.46m, new DateTime(2025, 3, 7, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5690) },
                    { 96, "Bulk discount applied", new DateTime(2025, 8, 27, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5690), "Lambda Industries", "Basic Widget", 68, "Draft", 45.20m, new DateTime(2025, 9, 28, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5690) },
                    { 97, "First-time customer", new DateTime(2025, 2, 5, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5690), "Theta Group", "Super Widget", 70, "Draft", 627.66m, new DateTime(2025, 2, 24, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5690) },
                    { 98, "Emergency order", new DateTime(2025, 6, 1, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5700), "Kappa Corp", "Enterprise Widget", 75, "Draft", 675.32m, new DateTime(2025, 7, 13, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5700) },
                    { 99, "Standard processing", new DateTime(2025, 8, 18, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5700), "Epsilon Tech", "Custom Widget", 83, "Draft", 99.20m, new DateTime(2025, 10, 20, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5700) },
                    { 100, "Standard processing", new DateTime(2024, 10, 19, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5700), "Gamma Corp", "Super Widget", 99, "Pending", 455.57m, new DateTime(2024, 12, 8, 20, 51, 56, 529, DateTimeKind.Local).AddTicks(5700) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comments", "CreatedDate", "CustomerName", "ProductName", "Quantity", "Status", "UnitPrice", "ValidQuotePeriod" },
                values: new object[] { "Customer requested rush delivery", new DateTime(2025, 10, 1, 23, 50, 41, 485, DateTimeKind.Local).AddTicks(7320), "Acme Corp", "Widget A", 10, "Draft", 25.00m, new DateTime(2025, 10, 11, 23, 50, 41, 485, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Comments", "CreatedDate", "CustomerName", "ProductName", "Quantity", "UnitPrice", "ValidQuotePeriod" },
                values: new object[] { "", new DateTime(2025, 10, 3, 23, 50, 41, 485, DateTimeKind.Local).AddTicks(7380), "Tech Solutions", "Widget B", 5, 45.50m, new DateTime(2025, 11, 2, 23, 50, 41, 485, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Comments", "CreatedDate", "CustomerName", "ProductName", "Quantity", "Status", "UnitPrice", "ValidQuotePeriod" },
                values: new object[] { "", new DateTime(2025, 10, 5, 23, 50, 41, 485, DateTimeKind.Local).AddTicks(7380), "Global Industries", "Widget C", 20, "Approved", 15.75m, new DateTime(2025, 11, 4, 23, 50, 41, 485, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Comments", "CreatedDate", "CustomerName", "ProductName", "Quantity", "Status", "UnitPrice", "ValidQuotePeriod" },
                values: new object[] { "", new DateTime(2025, 10, 4, 23, 50, 41, 485, DateTimeKind.Local).AddTicks(7380), "StartUp Inc", "Widget D", 8, "Draft", 35.25m, new DateTime(2025, 10, 5, 23, 50, 41, 485, DateTimeKind.Local).AddTicks(7390) });
        }
    }
}
