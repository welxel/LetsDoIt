using System;
using System.Collections.Generic;
using System.Text;
using DemandManagement.MessageContracts;
using MassTransit;
using RabbitMq.RabbitMq;
using RabbitMq.RabbitMq.Consumer;

namespace RabbitMq
{
    public class RabbitService
    {
        public void SendMessageRabbitServer(IBusControl bus,Customer customer, string reciever)
        {
            var endPoint = bus.GetSendEndpoint(new Uri("rabbitmq://localhost/"+reciever)).GetAwaiter().GetResult();

            endPoint.Send<ICustomer>(customer).GetAwaiter().GetResult();
        }

        public ICustomer GetMessageRabbitServer(IBusControl bus,string reciever)
        {
            var productChangeHandler = bus.ConnectReceiveEndpoint(reciever, x =>
            {
                x.Consumer<CustomerConsumer>();
            });

            productChangeHandler.Ready.GetAwaiter().GetResult();

            return null;
        }

    }
}
