using System;

namespace RabbitMq
{
    public interface ICustomer
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Message { get; set; }
        public DateTime MessageDate { get; set; }
    }
}