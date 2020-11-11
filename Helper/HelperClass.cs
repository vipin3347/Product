using Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Helper
{
    public class HelperClass
    {
        public static List<ProductModel> products = new List<ProductModel>
        {
            new ProductModel{ ProductId = 1, ProductName = "Product 1", Description = "This is Product 1", ImageName = "product1.jpg", Price = 5999, Rating = 5},
            new ProductModel{ ProductId = 2, ProductName = "Product 2", Description = "This is Product 2", ImageName = "product2.jpg", Price = 3500, Rating = 3},
            new ProductModel{ ProductId = 3, ProductName = "Product 3", Description = "This is Product 3", ImageName = "product3.jpg", Price = 6999, Rating = 4},
            new ProductModel{ ProductId = 4, ProductName = "Product 4", Description = "This is Product 4", ImageName = "product4.jpg", Price = 4599, Rating = 2},
            new ProductModel{ ProductId = 5, ProductName = "Product 5", Description = "This is Product 5", ImageName = "product5.jpg", Price = 2900, Rating = 5}
        };
    }
}
