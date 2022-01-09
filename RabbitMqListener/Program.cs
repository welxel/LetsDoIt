using System;
using DemandManagement.MessageContracts;
using MassTransit;
using RabbitMq.RabbitMq;
using RabbitMq.RabbitMq.Consumer;

namespace RabbitMqListener
{
    class Program
    {
        static void Main(string[] args)
        {


            var bus = BusConfigurator.ConfigureBus(new RabbitMqConfiguration
            {
                Url = "rabbitmq://localhost/"
            });

            var productChangeHandler = bus.ConnectReceiveEndpoint("test", x =>
            {
                x.Consumer<CustomerConsumer>();
            });

            productChangeHandler.Ready.GetAwaiter().GetResult();


            Console.ReadLine();
        }
    }
}
