using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMS.Api.Migrations
{
    /// <inheritdoc />
    public partial class updated_entities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Orders",
                newName: "OrderedAt");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

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
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customer_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customer_CustomerId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "OrderedAt",
                table: "Orders",
                newName: "OrderDate");

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
        }
    }
}
