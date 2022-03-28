using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategySorters
{
    public class ProductNameSorter : ISorterStrategy
    {
        public IEnumerable<Product> Sort(List<Product> productList)
        {
            return productList.OrderBy(x => x.ProductName);
        }
    }
}
