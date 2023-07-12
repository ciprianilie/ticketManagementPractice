using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TMS.Api.Migrations
{
    /// <inheritdoc />
    public partial class addednewtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TicketCategories",
                columns: table => new
                {
                    TicketCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketCategories", x => x.TicketCategoryId);
                    table.ForeignKey(
                        name: "FK_TicketCategories_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    NumberOfTickets = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TicketCategoryId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Orders_TicketCategories_TicketCategoryId",
                        column: x => x.TicketCategoryId,
                        principalTable: "TicketCategories",
                        principalColumn: "TicketCategoryId",
                        onDelete: ReferentialAction.NoAction);
                });

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

            migrationBuilder.InsertData(
                table: "TicketCategories",
                columns: new[] { "TicketCategoryId", "Description", "EventId", "Price" },
                values: new object[,]
                {
                    { 1, "Regular", 1, 10m },
                    { 2, "VIP", 1, 20m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_EventId",
                table: "Orders",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TicketCategoryId",
                table: "Orders",
                column: "TicketCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketCategories_EventId",
                table: "TicketCategories",
                column: "EventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "TicketCategories");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5667), new DateTime(2024, 1, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5683), new DateTime(2024, 1, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5694), new DateTime(2024, 1, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5705), new DateTime(2024, 1, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5728), new DateTime(2024, 1, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 2, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5716), new DateTime(2024, 1, 4, 1, 18, 12, 977, DateTimeKind.Local).AddTicks(5714) });
        }
    }
}
