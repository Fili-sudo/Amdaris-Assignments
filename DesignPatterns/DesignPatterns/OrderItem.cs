using DesignPatterns.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class OrderItem : Entity, IOrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public OrderItem() { }
        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            OrderItem other = (OrderItem)obj;
            return other.Id == Id;

        }
        public override string ToString()
        {
            return $"{Quantity} {Product.ProductName}";
        }
        public double GetProductPrice() { return Product.Price; }
        public string GetProductName() { return Product.ProductName; }

        public double GetOrderItemPrice()
        {
            return Product.Price * Quantity;
        }
    }
}
