using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public interface IOrderItem
    {
        public double GetOrderItemPrice();
        public int Quantity { get; }
    }
}
