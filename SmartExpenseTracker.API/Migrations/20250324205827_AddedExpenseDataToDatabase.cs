using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartExpenseTracker.API.Migrations
{
    /// <inheritdoc />
    public partial class AddedExpenseDataToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "Category", "Date", "Description" },
                values: new object[,]
                {
                    { 10, 4.5, "Food & Dining", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coffee at Starbucks" },
                    { 11, 12.75, "Food & Dining", new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lunch at McDonald's" },
                    { 12, 67.900001525878906, "Food & Dining", new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grocery shopping at Walmart" },
                    { 13, 18.25, "Transportation", new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uber ride downtown" },
                    { 14, 45.299999237060547, "Transportation", new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gas refill" },
                    { 15, 10.5, "Transportation", new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Train ticket" },
                    { 16, 15.989999771118164, "Entertainment", new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Netflix subscription" },
                    { 17, 14.0, "Entertainment", new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie ticket" },
                    { 18, 75.0, "Entertainment", new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Concert ticket" },
                    { 19, 120.44999694824219, "Utilities", new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Electricity bill" },
                    { 20, 65.989997863769531, "Utilities", new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Internet bill" },
                    { 21, 35.200000762939453, "Utilities", new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Water bill" },
                    { 22, 120.0, "Shopping", new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon purchase - headphones" },
                    { 23, 45.0, "Shopping", new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clothing from H&M" },
                    { 24, 90.0, "Shopping", new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shoes from Nike" },
                    { 25, 150.0, "Healthcare", new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor's visit" },
                    { 26, 30.25, "Healthcare", new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pharmacy - medication" },
                    { 27, 200.0, "Healthcare", new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dental checkup" },
                    { 28, 45.0, "Education", new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Online course on Udemy" },
                    { 29, 120.0, "Education", new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Textbooks" },
                    { 30, 25.5, "Education", new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "School supplies" },
                    { 31, 350.0, "Travel", new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flight ticket" },
                    { 32, 120.0, "Travel", new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hotel booking" },
                    { 33, 85.0, "Travel", new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Car rental" },
                    { 34, 250.0, "Insurance", new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Health insurance" },
                    { 35, 180.0, "Insurance", new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Car insurance" },
                    { 36, 300.0, "Insurance", new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Home insurance" },
                    { 37, 40.0, "Miscellaneous", new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Birthday gift" },
                    { 38, 20.0, "Miscellaneous", new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donation" },
                    { 39, 5.5, "Miscellaneous", new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Postage" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 3, 23, 17, 48, 37, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 3, 23, 17, 48, 37, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 3, 23, 17, 48, 37, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2025, 3, 23, 17, 48, 37, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2025, 3, 23, 17, 48, 37, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 3, 23, 17, 48, 37, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2025, 3, 23, 17, 48, 37, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2025, 3, 23, 17, 48, 37, 0, DateTimeKind.Utc));
        }
    }
}
