namespace RabbitMq
{
    public interface IBusConfiguration
    {
        public string Url { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}