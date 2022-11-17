using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopeeFake.Migrations
{
    public partial class SeedingDataInTableAppRole_Category_Product_User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRole",
                columns: new[] { "AppRoleId", "RoleName" },
                values: new object[,]
                {
                    { 1L, "Admin" },
                    { 2L, "STAFF" },
                    { 3L, "Customer" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1L, "Op Lung" },
                    { 2L, "Cuong luc" },
                    { 3L, "Xac" },
                    { 4L, "Tai Nghe" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CategoryId", "Description", "Discount", "EnteredDate", "Image", "Price", "ProductName", "Quantity", "Sold", "Status" },
                values: new object[,]
                {
                    { 1L, 4L, "", 0, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ok", 20000m, "Tai Nghe Iphone", 100, 5, true },
                    { 2L, 4L, "", 0, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ok", 25000m, "Tai Nghe SamSung", 100, 0, true },
                    { 3L, 4L, "", 0, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ok", 30000m, "Tai Nghe Oppo", 100, 0, true },
                    { 4L, 1L, "", 0, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ok", 20000m, "Op Lung Iphone", 100, 5, true },
                    { 5L, 1L, "", 0, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ok", 20000m, "Op Lung SamSung", 100, 0, true },
                    { 6L, 1L, "", 0, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ok", 20000m, "Op Lung Oppo", 100, 0, true },
                    { 7L, 2L, "", 0, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ok", 20000m, "Cuong Luc Iphone", 100, 10, true },
                    { 8L, 2L, "", 0, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ok", 20000m, "Cuong Luc SamSung", 100, 0, true },
                    { 9L, 2L, "", 0, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ok", 20000m, "Cuong Luc Oppo", 100, 0, true },
                    { 10L, 3L, "", 0, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ok", 20000m, "Xac Iphone", 100, 0, true },
                    { 11L, 3L, "", 0, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ok", 20000m, "Xac  SamSung", 100, 0, true },
                    { 12L, 3L, "", 0, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ok", 20000m, "Xac  Oppo", 100, 0, true }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Address", "AppRoleId", "Email", "Gender", "Image", "Password", "Phone", "RegisterDate", "Status", "Token", "UserName" },
                values: new object[,]
                {
                    { 1L, "68 Trieu Khuc", 1L, "ngockyto008@gmail.com", 1, null, "Ky1234567", 393039393, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "", "KyTo" },
                    { 2L, "69 Trieu Khuc", 2L, "ngockyto007@gmail.com", 1, null, "Ky1234567", 393039393, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "", "NgocAnh" },
                    { 3L, "70 Trieu Khuc", 3L, "ngockyto006@gmail.com", 1, null, "Ky1234567", 393039393, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "", "MinhChien" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "AppRole",
                keyColumn: "AppRoleId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "AppRole",
                keyColumn: "AppRoleId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "AppRole",
                keyColumn: "AppRoleId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4L);
        }
    }
}
