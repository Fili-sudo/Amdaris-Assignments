using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public abstract class BaseDecorator : IOrderItem
    {
        protected IOrderItem _orderItem;
        public int Quantity => _orderItem.Quantity;

        public BaseDecorator(IOrderItem orderItem)
        {
            _orderItem = orderItem;
        }

        public abstract double GetOrderItemPrice();
        
    }
}
