namespace RabbitMq.RabbitMq
{
    public class RabbitMqConfiguration : IBusConfiguration
    {
        public string Url { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}