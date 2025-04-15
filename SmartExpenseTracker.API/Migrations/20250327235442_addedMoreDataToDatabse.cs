using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartExpenseTracker.API.Migrations
{
    /// <inheritdoc />
    public partial class addedMoreDataToDatabse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "Category", "Date", "Description", "ExtractedText", "ReceiptFilePath" },
                values: new object[,]
                {
                    { 100, 3.5, "Food & Dining", new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coffee at Tim Hortons", null, null },
                    { 101, 8.9899997711181641, "Food & Dining", new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lunch at Subway", null, null },
                    { 102, 14.5, "Food & Dining", new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dinner at KFC", null, null },
                    { 103, 120.75, "Food & Dining", new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grocery shopping at T&T Supermarket", null, null },
                    { 104, 5.0, "Food & Dining", new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Snack at 7-Eleven", null, null },
                    { 105, 9.25, "Food & Dining", new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burger King meal", null, null },
                    { 106, 78.199996948242188, "Food & Dining", new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grocery shopping at Walmart", null, null },
                    { 107, 2.75, "Food & Dining", new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coffee at McDonald's", null, null },
                    { 108, 4.9899997711181641, "Food & Dining", new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ice cream at Dairy Queen", null, null },
                    { 109, 18.450000762939453, "Food & Dining", new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pizza at Domino's", null, null },
                    { 110, 3.25, "Transportation", new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bus fare", null, null },
                    { 111, 45.0, "Transportation", new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taxi ride to airport", null, null },
                    { 112, 55.400001525878906, "Transportation", new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gas refill at Shell", null, null },
                    { 113, 320.75, "Transportation", new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flight to Toronto", null, null },
                    { 114, 20.5, "Transportation", new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uber ride to downtown", null, null },
                    { 115, 12.5, "Transportation", new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Train ticket", null, null },
                    { 116, 5.0, "Transportation", new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Electric scooter rental", null, null },
                    { 117, 10.0, "Transportation", new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parking fee", null, null },
                    { 118, 15.0, "Transportation", new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Car wash", null, null },
                    { 119, 60.0, "Transportation", new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oil change", null, null },
                    { 120, 15.989999771118164, "Entertainment", new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Netflix subscription", null, null },
                    { 121, 13.5, "Entertainment", new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Movie at Cineplex", null, null },
                    { 122, 12.989999771118164, "Entertainment", new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spotify premium", null, null },
                    { 123, 80.0, "Entertainment", new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Concert ticket", null, null },
                    { 124, 9.9899997711181641, "Entertainment", new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gaming subscription", null, null },
                    { 125, 28.0, "Entertainment", new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escape room", null, null },
                    { 126, 20.0, "Entertainment", new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bowling night", null, null },
                    { 127, 15.0, "Entertainment", new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karaoke night", null, null },
                    { 128, 18.0, "Entertainment", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Museum entry", null, null },
                    { 129, 25.0, "Entertainment", new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comedy show", null, null },
                    { 130, 100.25, "Utilities", new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Electric bill", null, null },
                    { 131, 60.75, "Utilities", new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Internet bill", null, null },
                    { 132, 40.0, "Utilities", new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Water bill", null, null },
                    { 133, 70.5, "Utilities", new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heating bill", null, null },
                    { 134, 55.0, "Utilities", new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone bill", null, null },
                    { 135, 45.0, "Health & Fitness", new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gym membership", null, null },
                    { 136, 70.0, "Health & Fitness", new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Massage therapy", null, null },
                    { 137, 15.0, "Health & Fitness", new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yoga class", null, null },
                    { 138, 90.0, "Health & Fitness", new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Personal trainer", null, null },
                    { 139, 35.0, "Health & Fitness", new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supplements", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 139);
        }
    }
}
