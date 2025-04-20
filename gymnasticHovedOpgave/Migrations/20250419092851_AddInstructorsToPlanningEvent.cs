using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gymnasticHovedOpgave.Migrations
{
    /// <inheritdoc />
    public partial class AddInstructorsToPlanningEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlanningEvents",
                columns: new[] { "Id", "CategoryId", "CreatorId", "Date", "Description", "InstructorsId", "Name", "TeamId", "VenueId" },
                values: new object[,]
                {
                    { 1, 1, 1, 638054496000000000L, "Training session for all teams.", "[1,2]", "Gymnastics Training", 1, 1 },
                    { 2, 2, 2, 638066592000000000L, "Annual competition for all teams.", "[3,4]", "Annual Gymnastics Championship", 2, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlanningEvents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlanningEvents",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
