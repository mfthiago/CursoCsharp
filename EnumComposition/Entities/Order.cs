﻿using EnumComposition.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumComposition.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items{ get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) { Items.Add(item);  }
        public void RemoveItem(OrderItem item) {  Items.Remove(item); }

        public double Total(OrderItem item)
        {
            double sum = 0;
            foreach(OrderItem Item in Items)
            {
                sum += Item.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: "+ Client);
            sb.AppendLine("Order items: ");
            foreach(OrderItem Item in Items)
            {
                sb.AppendLine(Item.ToString());
            }
            sb.AppendLine("Total price: $"+ Total);
            
            return sb.ToString();
        }
    }
}
