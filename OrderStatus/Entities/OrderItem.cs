using System;
using System.Collections.Generic;
using System.Text;

namespace OrderStatus.Entities {
    class OrderItem {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product product { get; set; }

        public OrderItem(int quantity, double price) {
            Quantity = quantity;
            Price = price;
        }

        public OrderItem(int quantity, double price, Product product) : this(quantity, price) {
            this.product = product;
        }
    }
}
