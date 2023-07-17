using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMS.Api.Migrations
{
    /// <inheritdoc />
    public partial class updatedtablenames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventTypes_EventTypeId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Venue_VenueId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_TicketCategories_TicketCategoryId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketCategories_Events_EventId",
                table: "TicketCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketCategories",
                table: "TicketCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventTypes",
                table: "EventTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.RenameTable(
                name: "TicketCategories",
                newName: "TicketCategory");

            migrationBuilder.RenameTable(
                name: "EventTypes",
                newName: "EventType");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "Event");

            migrationBuilder.RenameIndex(
                name: "IX_TicketCategories_EventId",
                table: "TicketCategory",
                newName: "IX_TicketCategory_EventId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_VenueId",
                table: "Event",
                newName: "IX_Event_VenueId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_EventTypeId",
                table: "Event",
                newName: "IX_Event_EventTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketCategory",
                table: "TicketCategory",
                column: "TicketCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventType",
                table: "EventType",
                column: "EventTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Event",
                table: "Event",
                column: "EventId");

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "CustomerName", "Email" },
                values: new object[] { 1, "John Doe", "test@test.com" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 17, 20, 53, 12, 32, DateTimeKind.Local).AddTicks(3678), new DateTime(2024, 1, 17, 20, 53, 12, 32, DateTimeKind.Local).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 17, 20, 53, 12, 32, DateTimeKind.Local).AddTicks(3686), new DateTime(2024, 1, 17, 20, 53, 12, 32, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 17, 20, 53, 12, 32, DateTimeKind.Local).AddTicks(3692), new DateTime(2024, 1, 17, 20, 53, 12, 32, DateTimeKind.Local).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 17, 20, 53, 12, 32, DateTimeKind.Local).AddTicks(3698), new DateTime(2024, 1, 17, 20, 53, 12, 32, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 17, 20, 53, 12, 32, DateTimeKind.Local).AddTicks(3710), new DateTime(2024, 1, 17, 20, 53, 12, 32, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "EventId",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 17, 20, 53, 12, 32, DateTimeKind.Local).AddTicks(3703), new DateTime(2024, 1, 17, 20, 53, 12, 32, DateTimeKind.Local).AddTicks(3702) });

            migrationBuilder.AddForeignKey(
                name: "FK_Event_EventType_EventTypeId",
                table: "Event",
                column: "EventTypeId",
                principalTable: "EventType",
                principalColumn: "EventTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Venue_VenueId",
                table: "Event",
                column: "VenueId",
                principalTable: "Venue",
                principalColumn: "VenueId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_TicketCategory_TicketCategoryId",
                table: "Orders",
                column: "TicketCategoryId",
                principalTable: "TicketCategory",
                principalColumn: "TicketCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketCategory_Event_EventId",
                table: "TicketCategory",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_EventType_EventTypeId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_Venue_VenueId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_TicketCategory_TicketCategoryId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketCategory_Event_EventId",
                table: "TicketCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketCategory",
                table: "TicketCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventType",
                table: "EventType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Event",
                table: "Event");

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "TicketCategory",
                newName: "TicketCategories");

            migrationBuilder.RenameTable(
                name: "EventType",
                newName: "EventTypes");

            migrationBuilder.RenameTable(
                name: "Event",
                newName: "Events");

            migrationBuilder.RenameIndex(
                name: "IX_TicketCategory_EventId",
                table: "TicketCategories",
                newName: "IX_TicketCategories_EventId");

            migrationBuilder.RenameIndex(
                name: "IX_Event_VenueId",
                table: "Events",
                newName: "IX_Events_VenueId");

            migrationBuilder.RenameIndex(
                name: "IX_Event_EventTypeId",
                table: "Events",
                newName: "IX_Events_EventTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketCategories",
                table: "TicketCategories",
                column: "TicketCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventTypes",
                table: "EventTypes",
                column: "EventTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "EventId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventTypes_EventTypeId",
                table: "Events",
                column: "EventTypeId",
                principalTable: "EventTypes",
                principalColumn: "EventTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Venue_VenueId",
                table: "Events",
                column: "VenueId",
                principalTable: "Venue",
                principalColumn: "VenueId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_TicketCategories_TicketCategoryId",
                table: "Orders",
                column: "TicketCategoryId",
                principalTable: "TicketCategories",
                principalColumn: "TicketCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketCategories_Events_EventId",
                table: "TicketCategories",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
