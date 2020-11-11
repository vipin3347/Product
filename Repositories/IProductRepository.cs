using Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Repositories
{
    public interface IProductRepository
    {
        public List<ProductModel> GetAllProducts();
        public ProductModel SearchProductById(int productId);
        public ProductModel SearchProductByName(string productName);
        public int AddProductRating(int productId, double rating);
    }
}
