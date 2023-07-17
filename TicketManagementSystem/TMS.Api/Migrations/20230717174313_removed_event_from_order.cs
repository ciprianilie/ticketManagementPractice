using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMS.Api.Migrations
{
    /// <inheritdoc />
    public partial class removed_event_from_order : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Events_EventId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_EventId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 17, 20, 43, 13, 911, DateTimeKind.Local).AddTicks(3144), new DateTime(2024, 1, 17, 20, 43, 13, 911, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 17, 20, 43, 13, 911, DateTimeKind.Local).AddTicks(3174), new DateTime(2024, 1, 17, 20, 43, 13, 911, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 17, 20, 43, 13, 911, DateTimeKind.Local).AddTicks(3181), new DateTime(2024, 1, 17, 20, 43, 13, 911, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 17, 20, 43, 13, 911, DateTimeKind.Local).AddTicks(3187), new DateTime(2024, 1, 17, 20, 43, 13, 911, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 17, 20, 43, 13, 911, DateTimeKind.Local).AddTicks(3200), new DateTime(2024, 1, 17, 20, 43, 13, 911, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 17, 20, 43, 13, 911, DateTimeKind.Local).AddTicks(3193), new DateTime(2024, 1, 17, 20, 43, 13, 911, DateTimeKind.Local).AddTicks(3192) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1073), new DateTime(2024, 1, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1081), new DateTime(2024, 1, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1088), new DateTime(2024, 1, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1093), new DateTime(2024, 1, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1125), new DateTime(2024, 1, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1099), new DateTime(2024, 1, 17, 20, 33, 24, 623, DateTimeKind.Local).AddTicks(1098) });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_EventId",
                table: "Orders",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Events_EventId",
                table: "Orders",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
