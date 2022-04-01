using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class GiftWrapped : BaseDecorator
    {
        public GiftWrapped(IOrderItem orderItem) :base(orderItem)
        {

        }
        public override double GetOrderItemPrice()
        {
            return _orderItem.GetOrderItemPrice() + _orderItem.Quantity * 10;
        }
        public override string ToString()
        {
            return _orderItem + " gift wrapped";
        }
    }
}
