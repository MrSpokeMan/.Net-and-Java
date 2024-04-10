using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WinFormsApp2.Migrations
{
    /// <inheritdoc />
    public partial class Correction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CurrencyDB",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CurrencyDB",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Base",
                table: "CurrencyDB");

            migrationBuilder.DropColumn(
                name: "Disclaimer",
                table: "CurrencyDB");

            migrationBuilder.DropColumn(
                name: "License",
                table: "CurrencyDB");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "CurrencyDB");

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "CurrencyDB",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Value",
                table: "CurrencyDB",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "CurrencyDB",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Currency", "Value" },
                values: new object[] { "PKB", 2.1m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "CurrencyDB");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "CurrencyDB");

            migrationBuilder.AddColumn<string>(
                name: "Base",
                table: "CurrencyDB",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Disclaimer",
                table: "CurrencyDB",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "License",
                table: "CurrencyDB",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Timestamp",
                table: "CurrencyDB",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "CurrencyDB",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Base", "Disclaimer", "License", "Timestamp" },
                values: new object[] { null, null, null, 1631539200L });

            migrationBuilder.InsertData(
                table: "CurrencyDB",
                columns: new[] { "Id", "Base", "Disclaimer", "License", "Timestamp" },
                values: new object[,]
                {
                    { 2, null, null, null, 1631539200L },
                    { 3, null, null, null, 1631539200L }
                });
        }
    }
}
