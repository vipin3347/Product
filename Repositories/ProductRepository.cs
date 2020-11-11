using Product.Helper;
using Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public int AddProductRating(int productId, double rating)
        {
            ProductModel product = HelperClass.products.Where(p => p.ProductId == productId).FirstOrDefault();

            if (product != null)
            {
                double oldRating = product.Rating;
                double newRating = (oldRating + rating) / 2;
                product.Rating = Convert.ToDouble(string.Format("{0:F1}", newRating));
                return 1;
            }
            return 0;
        }

        public List<ProductModel> GetAllProducts()
        {
            if (HelperClass.products != null)
            {
                return HelperClass.products;
            }
            return null;
        }

        public ProductModel SearchProductById(int productId)
        {
            ProductModel product = HelperClass.products.Where(p => p.ProductId == productId).FirstOrDefault();

            if (product != null)
            {
                return product;
            }
            return null;
        }

        public ProductModel SearchProductByName(string productName)
        {
            ProductModel product = HelperClass.products.Where(p => p.ProductName == productName).FirstOrDefault();

            if (product != null)
            {
                return product;
            }
            return null;
        }
    }
}
