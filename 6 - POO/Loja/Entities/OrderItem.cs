using System.Globalization;
using Loja.Entities.Enums;
using Loja.Entities;

namespace Loja.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
        
        

        public OrderItem()
        {   }        
        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
        }
        
        public double subTotal(){
            return Quantity*Product.Price;
        }
        public override string ToString()
        {
            return Product.Name + ", $"
            + Product.Price.ToString("F2", CultureInfo.InvariantCulture) 
            + ", Quantity: " 
            + Quantity + ", Subtotal: $"
            +subTotal().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}