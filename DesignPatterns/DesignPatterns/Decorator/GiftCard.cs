using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class GiftCard : BaseDecorator
    {
        public GiftCard(IOrderItem orderItem) : base(orderItem)
        {

        }
        public override double GetOrderItemPrice()
        {
            return _orderItem.GetOrderItemPrice() + _orderItem.Quantity * 5;
        }
        public override string ToString()
        {
            return _orderItem + " gift card included";
        }
    }
}
