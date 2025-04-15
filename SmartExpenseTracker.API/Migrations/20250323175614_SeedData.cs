using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartExpenseTracker.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "Category", "Date", "Description" },
                values: new object[,]
                {
                    { 2, 50m, "Food", new DateTime(2025, 3, 23, 17, 48, 37, 0, DateTimeKind.Utc), "Groceries from Walmart" },
                    { 3, 20m, "Transportation", new DateTime(2025, 3, 23, 17, 48, 37, 0, DateTimeKind.Utc), "Uber ride to downtown" },
                    { 4, 15m, "Entertainment", new DateTime(2025, 3, 23, 17, 48, 37, 0, DateTimeKind.Utc), "Monthly Netflix subscription" },
                    { 5, 100m, "Healthcare", new DateTime(2025, 3, 23, 17, 48, 37, 0, DateTimeKind.Utc), "Doctor's appointment fee" },
                    { 6, 1000m, "Education", new DateTime(2025, 3, 23, 17, 48, 37, 0, DateTimeKind.Utc), "College tuition payment" },
                    { 7, 120m, "Utilities", new DateTime(2025, 3, 23, 17, 48, 37, 0, DateTimeKind.Utc), "Electricity bill" },
                    { 8, 70m, "Shopping", new DateTime(2025, 3, 23, 17, 48, 37, 0, DateTimeKind.Utc), "Clothes from Zara" },
                    { 9, 300m, "Travel", new DateTime(2025, 3, 23, 17, 48, 37, 0, DateTimeKind.Utc), "Flight to Toronto" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
