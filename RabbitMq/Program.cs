using System;
using DemandManagement.MessageContracts;
using MassTransit;
using RabbitMq.RabbitMq;

namespace RabbitMq
{
    public class Program
    {

        public  static void Main(string[] args)
        {
            var bus = BusConfigurator.ConfigureBus(new RabbitMqConfiguration
            {
                Url = "rabbitmq://localhost/"
            });

            RabbitService rabbitService = new RabbitService();
            Customer customer = new Customer
            {
                Name = "babadaa",
                Surname = "Bektas",
                Message = "Test"
            };

            rabbitService.SendMessageRabbitServer(bus,customer,"test");
            rabbitService.GetMessageRabbitServer(bus, "test");

            Console.ReadLine();

            #region Old Code

            //var customer = new Customer
            //{
            //    Name = "Furkan",
            //    Surname = "BEKTAS"
            //};
            //var factory = new ConnectionFactory
            //{
            //    HostName = "localhost"
            //};

            //using IConnection connetion = factory.CreateConnection();

            //using (IModel channel = connetion.CreateModel())
            //{
            //    channel.QueueDeclare(queue:"test",
            //        durable:false,
            //        exclusive:false,
            //        autoDelete:false,
            //        arguments:null
            //    );

            //    String message = JsonConvert.SerializeObject(customer);
            //    var body = Encoding.UTF8.GetBytes(message);
            //    channel.BasicPublish(exchange:"",
            //        routingKey:"test",
            //        basicProperties:null,
            //        body:body);
            //}

            #endregion
        }
    }
}