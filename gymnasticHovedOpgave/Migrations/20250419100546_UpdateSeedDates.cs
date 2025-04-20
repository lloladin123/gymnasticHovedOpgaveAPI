using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gymnasticHovedOpgave.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop the old column
            migrationBuilder.DropColumn(
                name: "Date",
                table: "PlanningEvents");

            // Re-add it with the correct type
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "PlanningEvents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2000, 1, 1)); // or any safe default

            // Re-seed with valid dates
            migrationBuilder.UpdateData(
                table: "PlanningEvents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 12, 1, 17, 30, 0));

            migrationBuilder.UpdateData(
                table: "PlanningEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 12, 15, 14, 0, 0));
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Date",
                table: "PlanningEvents",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "PlanningEvents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: 638054496000000000L);

            migrationBuilder.UpdateData(
                table: "PlanningEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: 638066592000000000L);
        }
    }
}
