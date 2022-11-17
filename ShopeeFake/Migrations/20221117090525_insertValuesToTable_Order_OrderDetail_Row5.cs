using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopeeFake.Migrations
{
    public partial class insertValuesToTable_Order_OrderDetail_Row5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "Address", "Amount", "OrderDate", "Phone", "Status", "UserId" },
                values: new object[] { 5L, "18 Trieu Khuc", 200000m, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 393039393, true, 2L });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderDetailId", "OrderId", "Price", "ProductId", "Quantity" },
                values: new object[] { 2L, 5L, 40000m, 4L, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 5L);
        }
    }
}
