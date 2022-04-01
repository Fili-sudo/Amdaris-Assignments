using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class InMemoryProductRepository
    {
        private List<Product> _products;
        private ISorterStrategy _sorter;

        public ISorterStrategy Sorter 
        {
            set
            {
                _sorter = value;
            } 
        }

        public InMemoryProductRepository()
        {
            _products = new List<Product>();
        }

        public InMemoryProductRepository(ISorterStrategy sorter)
        {
            _sorter = sorter;
            _products = new List<Product>();
        }
        public void CreateProduct(Product product)
        {
            product.Id = _products.Count + 1;
            _products.Add(product);
        }
        public Product GetProduct(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
        public IEnumerable<Product> GetProducts()
        {
            if (_sorter != null) { _products = _sorter.Sort(_products).ToList(); }
            return _products;
        }

    }
}
