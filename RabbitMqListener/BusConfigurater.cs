using MassTransit;
using MassTransit.RabbitMqTransport;
using System;
using System.Collections.Generic;
using System.Text;
using RabbitMq;
using RabbitMq.RabbitMq;

namespace DemandManagement.MessageContracts
{

    public static class BusConfigurator
    {
        public static IBusControl ConfigureBus(IBusConfiguration config)
        {
            if (config is RabbitMqConfiguration)
            {
                return Bus.Factory.CreateUsingRabbitMq(cfg =>
                {
                    cfg.Host(new Uri(config.Url), hst =>
                    {
                        hst.Username(config.UserName);
                        hst.Password(config.Password);
                    });

                });
            }

            throw new NotImplementedException();
        }
    }

}
