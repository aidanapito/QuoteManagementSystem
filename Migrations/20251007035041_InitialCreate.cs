using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    ProductName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ValidQuotePeriod = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Comments = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Comments", "CreatedDate", "CustomerName", "ProductName", "Quantity", "Status", "UnitPrice", "ValidQuotePeriod" },
                values: new object[,]
                {
                    { 1, "Customer requested rush delivery", new DateTime(2025, 10, 1, 23, 50, 41, 485, DateTimeKind.Local).AddTicks(7320), "Acme Corp", "Widget A", 10, "Draft", 25.00m, new DateTime(2025, 10, 11, 23, 50, 41, 485, DateTimeKind.Local).AddTicks(7370) },
                    { 2, "", new DateTime(2025, 10, 3, 23, 50, 41, 485, DateTimeKind.Local).AddTicks(7380), "Tech Solutions", "Widget B", 5, "Pending", 45.50m, new DateTime(2025, 11, 2, 23, 50, 41, 485, DateTimeKind.Local).AddTicks(7380) },
                    { 3, "", new DateTime(2025, 10, 5, 23, 50, 41, 485, DateTimeKind.Local).AddTicks(7380), "Global Industries", "Widget C", 20, "Approved", 15.75m, new DateTime(2025, 11, 4, 23, 50, 41, 485, DateTimeKind.Local).AddTicks(7380) },
                    { 4, "", new DateTime(2025, 10, 4, 23, 50, 41, 485, DateTimeKind.Local).AddTicks(7380), "StartUp Inc", "Widget D", 8, "Draft", 35.25m, new DateTime(2025, 10, 5, 23, 50, 41, 485, DateTimeKind.Local).AddTicks(7390) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
