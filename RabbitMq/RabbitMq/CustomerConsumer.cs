using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MassTransit;

namespace RabbitMq.RabbitMq.Consumer
{
    class CustomerConsumer:IConsumer<ICustomer>
    {
        public Task Consume(ConsumeContext<ICustomer> context)
        {
            Console.WriteLine("****"+ context.Message.Name);
            
            return Task.FromResult(1);
        }
    }
}
