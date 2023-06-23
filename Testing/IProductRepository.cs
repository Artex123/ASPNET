using System.Collections;
using System.Collections.Generic;
using Testing.Models;

namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProduct();
        public Product GetProduct(int id);
    }
}
