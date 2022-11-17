using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;
using ShopeeFake.Models;

namespace ShopeeFake.Data
{
    public static class SeedingData
    {
        public static void Seedings(this ModelBuilder modelBuilder)
        {/*
            //1 Table AppRole
            modelBuilder.Entity<AppRole>().HasData(
                new AppRole() { AppRoleId = 1, RoleName = "Admin" },
                new AppRole() { AppRoleId = 2, RoleName = "STAFF" },
                new AppRole() { AppRoleId = 3, RoleName = "Customer" }
                );*/

            /* //2 Table Cart
             modelBuilder.Entity<Cart>().HasData(
                new Cart() { CartId = 1, Address = "17 Trieu Khuc", Amount = 100000, Phone = 0393039393, UserId = 1 },
               new Cart() { CartId = 2, Address = "18 Trieu Khuc", Amount = 200000, Phone = 0393039393, UserId = 2 },
                new Cart() { CartId = 3, Address = "19 Trieu Khuc", Amount = 300000, Phone = 0393039393, UserId = 3 }
                );*/
            /* //3 Table CartDetail
             modelBuilder.Entity<CartDetail>().HasData(
                new CartDetail() { CartDetailId = 1, CartId = 1, Price = 20000, ProductId = 1, Quantity = 5 },
                new CartDetail() { CartDetailId = 2, CartId = 2, Price = 40000, ProductId = 2, Quantity = 5 },
                new CartDetail() { CartDetailId = 3, CartId = 1, Price = 30000, ProductId = 3, Quantity = 10 }
                );*/
            /*//4 Table Category
            modelBuilder.Entity<Category>().HasData(
               new Category() { CategoryId = 1, CategoryName = "Op Lung" },
               new Category() { CategoryId = 2, CategoryName = "Cuong luc" },
               new Category() { CategoryId = 3, CategoryName = "Xac" },
               new Category() { CategoryId = 4, CategoryName = "Tai Nghe" }

               );*/
            //5 Table Order
            modelBuilder.Entity<Order>().HasData(
               //new Order() { OrderId = 1, Address = "17 Trieu Khuc", Amount = 100000, Phone = 0393039393, Status = true, UserId = 3, OrderDate = DateTime.Parse("10/10/2022") },
               //new Order() { OrderId = 2, Address = "18 Trieu Khuc", Amount = 200000, Phone = 0393039393, Status = true, UserId = 2, OrderDate = DateTime.Parse("10/10/2022") },
               new Order() { OrderId = 3, Address = "19 Trieu Khuc", Amount = 300000, Phone = 0393039393, Status = true, UserId = 3, OrderDate = DateTime.Parse("10/10/2022") },
               new Order() { OrderId = 4, Address = "19 Trieu Khuc", Amount = 300000, Phone = 0393039393, Status = true, UserId = 3, OrderDate = DateTime.Parse("10/10/2022") },
               new Order() { OrderId = 5, Address = "18 Trieu Khuc", Amount = 200000, Phone = 0393039393, Status = true, UserId = 2, OrderDate = DateTime.Parse("10/10/2022") },
               new Order() { OrderId = 6, Address = "18 Trieu Khuc", Amount = 200000, Phone = 0393039393, Status = true, UserId = 2, OrderDate = DateTime.Parse("10/10/2022") }

               );
            //6 Table OrderDetail
            modelBuilder.Entity<OrderDetail>().HasData(
               //new OrderDetail() { OrderDetailId = 1, Price = 20000, ProductId = 1, Quantity = 5, OrderId = 1 },
               //new OrderDetail() { OrderDetailId = 2, Price = 40000, ProductId = 1, Quantity = 5, OrderId = 2 },
               new OrderDetail() { OrderDetailId = 3, Price = 30000, ProductId = 1, Quantity = 10, OrderId = 3 },
               new OrderDetail() { OrderDetailId = 4, Price = 30000, ProductId = 1, Quantity = 10, OrderId = 4 },
               new OrderDetail() { OrderDetailId = 2, Price = 40000, ProductId = 4, Quantity = 5, OrderId = 5 },
               new OrderDetail() { OrderDetailId = 6, Price = 40000, ProductId = 4, Quantity = 5, OrderId = 6 }
               );
            /*//7 Table Product
            modelBuilder.Entity<Product>().HasData(
               new Product() { ProductId = 1, ProductName = "Tai Nghe Iphone", Description = "", Discount = 0, Image = "ok", Price = 20000, Quantity = 100, Status = true, CategoryId = 4, Sold = 5, EnteredDate = DateTime.Parse("10/10/2022") },
               new Product() { ProductId = 2, ProductName = "Tai Nghe SamSung", Description = "", Discount = 0, Image = "ok", Price = 25000, Quantity = 100, Status = true, CategoryId = 4, Sold = 0, EnteredDate = DateTime.Parse("10/10/2022") },
               new Product() { ProductId = 3, ProductName = "Tai Nghe Oppo", Description = "", Discount = 0, Image = "ok", Price = 30000, Quantity = 100, Status = true, CategoryId = 4, Sold = 0, EnteredDate = DateTime.Parse("10/10/2022") },
               new Product() { ProductId = 4, ProductName = "Op Lung Iphone", Description = "", Discount = 0, Image = "ok", Price = 20000, Quantity = 100, Status = true, CategoryId = 1, Sold = 5, EnteredDate = DateTime.Parse("10/10/2022") },
               new Product() { ProductId = 5, ProductName = "Op Lung SamSung", Description = "", Discount = 0, Image = "ok", Price = 20000, Quantity = 100, Status = true, CategoryId = 1, Sold = 0, EnteredDate = DateTime.Parse("10/10/2022") },
               new Product() { ProductId = 6, ProductName = "Op Lung Oppo", Description = "", Discount = 0, Image = "ok", Price = 20000, Quantity = 100, Status = true, CategoryId = 1, Sold = 0, EnteredDate = DateTime.Parse("10/10/2022") },
               new Product() { ProductId = 7, ProductName = "Cuong Luc Iphone", Description = "", Discount = 0, Image = "ok", Price = 20000, Quantity = 100, Status = true, CategoryId = 2, Sold = 10, EnteredDate = DateTime.Parse("10/10/2022") },
               new Product() { ProductId = 8, ProductName = "Cuong Luc SamSung", Description = "", Discount = 0, Image = "ok", Price = 20000, Quantity = 100, Status = true, CategoryId = 2, Sold = 0, EnteredDate = DateTime.Parse("10/10/2022") },
               new Product() { ProductId = 9, ProductName = "Cuong Luc Oppo", Description = "", Discount = 0, Image = "ok", Price = 20000, Quantity = 100, Status = true, CategoryId = 2, Sold = 0, EnteredDate = DateTime.Parse("10/10/2022") },
               new Product() { ProductId = 10, ProductName = "Xac Iphone", Description = "", Discount = 0, Image = "ok", Price = 20000, Quantity = 100, Status = true, CategoryId = 3, Sold = 0, EnteredDate = DateTime.Parse("10/10/2022") },
               new Product() { ProductId = 11, ProductName = "Xac  SamSung", Description = "", Discount = 0, Image = "ok", Price = 20000, Quantity = 100, Status = true, CategoryId = 3, Sold = 0, EnteredDate = DateTime.Parse("10/10/2022") },
               new Product() { ProductId = 12, ProductName = "Xac  Oppo", Description = "", Discount = 0, Image = "ok", Price = 20000, Quantity = 100, Status = true, CategoryId = 3, Sold = 0, EnteredDate = DateTime.Parse("10/10/2022") }
            );
            //8 Table User
            modelBuilder.Entity<User>().HasData(
                new User() { UserId = 1, AppRoleId = 1, UserName = "KyTo", Password = "Ky1234567", Address = "68 Trieu Khuc", Email = "ngockyto008@gmail.com", Gender = 1, Phone = 0393039393, Status = true, Token = "", RegisterDate = DateTime.Parse("10/10/2022") },
               new User() { UserId = 2, AppRoleId = 2, UserName = "NgocAnh", Password = "Ky1234567", Address = "69 Trieu Khuc", Email = "ngockyto007@gmail.com", Gender = 1, Phone = 0393039393, Status = true, Token = "", RegisterDate = DateTime.Parse("10/10/2022") },
               new User() { UserId = 3, AppRoleId = 3, UserName = "MinhChien", Password = "Ky1234567", Address = "70 Trieu Khuc", Email = "ngockyto006@gmail.com", Gender = 1, Phone = 0393039393, Status = true, Token = "", RegisterDate = DateTime.Parse("10/10/2022") }
                );*/
        }
    }
}