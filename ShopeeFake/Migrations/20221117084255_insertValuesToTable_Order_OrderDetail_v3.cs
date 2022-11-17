using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopeeFake.Migrations
{
    public partial class insertValuesToTable_Order_OrderDetail_v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "Address", "Amount", "OrderDate", "Phone", "Status", "UserId" },
                values: new object[] { 4L, "19 Trieu Khuc", 300000m, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 393039393, true, 3L });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderDetailId", "OrderId", "Price", "ProductId", "Quantity" },
                values: new object[] { 4L, 4L, 30000m, 1L, 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 4L);
        }
    }
}
