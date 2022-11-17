using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopeeFake.Migrations
{
    public partial class DeleteOrder_Orderdetail_row1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "OrderDetailId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "Address", "Amount", "OrderDate", "Phone", "Status", "UserId" },
                values: new object[] { 1L, "17 Trieu Khuc", 100000m, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 393039393, true, 3L });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "OrderDetailId", "OrderId", "Price", "ProductId", "Quantity" },
                values: new object[] { 1L, 1L, 20000m, 1L, 5 });
        }
    }
}
