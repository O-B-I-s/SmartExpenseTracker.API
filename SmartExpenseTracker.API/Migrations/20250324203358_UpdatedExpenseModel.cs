using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartExpenseTracker.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedExpenseModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "Expenses",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Amount",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Amount",
                value: 20.0);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Amount",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Amount",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                column: "Amount",
                value: 1000.0);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                column: "Amount",
                value: 120.0);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                column: "Amount",
                value: 70.0);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                column: "Amount",
                value: 300.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Expenses",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Amount",
                value: 50m);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Amount",
                value: 20m);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Amount",
                value: 15m);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Amount",
                value: 100m);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6,
                column: "Amount",
                value: 1000m);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7,
                column: "Amount",
                value: 120m);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8,
                column: "Amount",
                value: 70m);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9,
                column: "Amount",
                value: 300m);
        }
    }
}
