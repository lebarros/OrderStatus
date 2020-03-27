
using System;
using System.Collections.Generic;
using System.Text;
using OrderStatus.Entities.Enums;


namespace OrderStatus.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public Status Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Client Client { get; set; }

        public Order() {
        }

        public Order(DateTime moment, Status status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem product) {
            Items.Add(product);
        }

        public void RemoveItem(OrderItem product) {
            Items.Remove(product);
        }

        public double total() {
            double sum = 0;
            foreach (OrderItem order in Items) {
                sum += order.Price * order.Quantity;
            }
            return sum;
        }

        public override string ToString() {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order status: " + Status.ToString());
            sb.AppendLine("Client: " + Client.Name + " - (" + Client.BrithDate.ToShortDateString() + ") - " + Client.Email);
            sb.AppendLine("Order Itens:");
            foreach (OrderItem oi in Items) {
                sb.AppendLine(oi.product.Name.ToString() + ", $" + oi.Price.ToString() + ", Quantity: " + oi.Quantity.ToString() + " SubTotal: $" + oi.Price * oi.Quantity);
            }

            return sb.ToString();
        }
    }
}
