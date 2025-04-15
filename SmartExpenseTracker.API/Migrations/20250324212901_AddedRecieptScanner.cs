using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartExpenseTracker.API.Migrations
{
    /// <inheritdoc />
    public partial class AddedRecieptScanner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExtractedText",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiptFilePath",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ExtractedText", "ReceiptFilePath" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtractedText",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "ReceiptFilePath",
                table: "Expenses");
        }
    }
}
