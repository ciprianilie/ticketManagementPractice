using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMS.Api.Migrations
{
    /// <inheritdoc />
    public partial class removedEventsFromEventType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 12, 10, 27, 47, 369, DateTimeKind.Local).AddTicks(2278), new DateTime(2024, 1, 12, 10, 27, 47, 369, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 12, 10, 27, 47, 369, DateTimeKind.Local).AddTicks(2287), new DateTime(2024, 1, 12, 10, 27, 47, 369, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 12, 10, 27, 47, 369, DateTimeKind.Local).AddTicks(2293), new DateTime(2024, 1, 12, 10, 27, 47, 369, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 12, 10, 27, 47, 369, DateTimeKind.Local).AddTicks(2298), new DateTime(2024, 1, 12, 10, 27, 47, 369, DateTimeKind.Local).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 12, 10, 27, 47, 369, DateTimeKind.Local).AddTicks(2334), new DateTime(2024, 1, 12, 10, 27, 47, 369, DateTimeKind.Local).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 12, 10, 27, 47, 369, DateTimeKind.Local).AddTicks(2326), new DateTime(2024, 1, 12, 10, 27, 47, 369, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "TicketCategories",
                keyColumn: "TicketCategoryId",
                keyValue: 1,
                column: "Price",
                value: 10m);

            migrationBuilder.UpdateData(
                table: "TicketCategories",
                keyColumn: "TicketCategoryId",
                keyValue: 2,
                column: "Price",
                value: 20m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 11, 22, 43, 11, 994, DateTimeKind.Local).AddTicks(2572), new DateTime(2024, 1, 11, 22, 43, 11, 994, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 11, 22, 43, 11, 994, DateTimeKind.Local).AddTicks(2580), new DateTime(2024, 1, 11, 22, 43, 11, 994, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 11, 22, 43, 11, 994, DateTimeKind.Local).AddTicks(2587), new DateTime(2024, 1, 11, 22, 43, 11, 994, DateTimeKind.Local).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 11, 22, 43, 11, 994, DateTimeKind.Local).AddTicks(2592), new DateTime(2024, 1, 11, 22, 43, 11, 994, DateTimeKind.Local).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 11, 22, 43, 11, 994, DateTimeKind.Local).AddTicks(2604), new DateTime(2024, 1, 11, 22, 43, 11, 994, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 11, 22, 43, 11, 994, DateTimeKind.Local).AddTicks(2597), new DateTime(2024, 1, 11, 22, 43, 11, 994, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "TicketCategories",
                keyColumn: "TicketCategoryId",
                keyValue: 1,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TicketCategories",
                keyColumn: "TicketCategoryId",
                keyValue: 2,
                column: "Price",
                value: 0m);
        }
    }
}
