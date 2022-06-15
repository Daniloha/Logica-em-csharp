using System.Globalization;
using System.Text;
using System;
using System.Collections.Generic;
using Loja.Entities.Enums;
using Loja.Entities;

namespace Loja.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();
        public Client Client{ get; set; }
        
        public Order()
        { }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void addItem(OrderItem item){
            Item.Add(item);
        }
        public void removeItem(OrderItem item){
            Item.Remove(item);
        }
        public double total()
        {
            double sum = 0;
            foreach (OrderItem item in Item)
            {
                sum += item.subTotal();
            }
            return sum;
        }

         public override string ToString()
        {
           StringBuilder sb = new StringBuilder();
           sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
           sb.AppendLine("Order status: " + Status);
           sb.AppendLine("Client: " + Client.Name + ", "
            + Client.Date.ToString("dd/MM/yyyy") + " - " 
           + Client.Email);
           sb.AppendLine("Order items: ");
           foreach (OrderItem item in Item)
           {
            sb.AppendLine(item.ToString());
           }
            sb.AppendLine("Total price: $" + total().ToString("f2", CultureInfo.InvariantCulture) );
            return sb.ToString();
        }
        
    }
}