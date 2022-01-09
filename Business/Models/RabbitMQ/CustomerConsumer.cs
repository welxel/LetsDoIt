using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MassTransit;

namespace RabbitMq.RabbitMq.Consumer {
    public class CustomerConsumer : IConsumer<ICustomer> {

        public Task Consume(ConsumeContext<ICustomer> context) {
            IEnumerable<int> numbers = Enumerable.Range(0, 100000000);

            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            Task startedTask = Task.Factory.StartNew(() => {
                for (int i = 0; i < numbers.Count(); i++) {
                    token.ThrowIfCancellationRequested();
                    i++;
                    i--;
                    i *= 2;
                    Console.Write(".");
                }
            }
                , token);
            return startedTask;
        }

    }
}
