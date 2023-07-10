using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TMS.Api.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Venue",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "EventTypes",
                columns: new[] { "EventTypeId", "EventTypeName" },
                values: new object[,]
                {
                    { 1, "Concerts" },
                    { 2, "Musicals" },
                    { 3, "Plays" },
                    { 4, "Conferences" }
                });

            migrationBuilder.InsertData(
                table: "Venue",
                columns: new[] { "VenueId", "Capacity", "Location", "Type" },
                values: new object[,]
                {
                    { 1, 20, "Remote", null },
                    { 2, 20, "Physical", null }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "EndDate", "EventDescription", "EventName", "EventTypeId", "StartDate", "VenueId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5667), "Join John for his farwell tour across 15 continents. John really needs no introduction since he has already mesmerized the world with his banjo.", "John Egbert Live", 1, new DateTime(2024, 1, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5623), 1 },
                    { 2, new DateTime(2024, 2, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5683), "Michael Johnson doesn't need an introduction. His 25 concert across the globe last year were seen by thousands. Can we add you to the list?", "The State of Affairs: Michael Live!", 1, new DateTime(2024, 1, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5680), 1 },
                    { 3, new DateTime(2024, 2, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5694), "Join John for his farwell tour across 15 continents. John really needs no introduction since he has already mesmerized the world with his banjo.", "John Egbert Live", 1, new DateTime(2024, 1, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5692), 2 },
                    { 4, new DateTime(2024, 2, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5705), "DJs from all over the world will compete in this epic battle for eternal fame.", "Clash of the DJs", 1, new DateTime(2024, 1, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5703), 1 },
                    { 5, new DateTime(2024, 2, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5728), "The critics are over the moon and so will you after you've watched this sing and dance extravaganza written by Nick Sailor, the man from 'My dad and sister'.", "To the Moon and Back", 2, new DateTime(2024, 1, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5726), 1 },
                    { 6, new DateTime(2024, 2, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5716), "The best tech conference in the world", "Techorama 2021", 4, new DateTime(2024, 1, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5714), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "EventTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Venue",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
