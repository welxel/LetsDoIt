using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMq.RabbitMq
{
    public class Customer:ICustomer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Message { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
