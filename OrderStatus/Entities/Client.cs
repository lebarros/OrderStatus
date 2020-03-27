using System;
using System.Collections.Generic;
using System.Text;

namespace OrderStatus.Entities {
    class Client {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BrithDate { get; set; }

        public Client(string name, string email, DateTime brithDate) {
            Name = name;
            Email = email;
            BrithDate = brithDate;
        }
    }
}
