using System;

namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumeRabbitMq consumeRabbitMq = new ConsumeRabbitMq();
            Consumer consumer = new Consumer(consumeRabbitMq, "Queue-RabbitMqTest");
            Console.Read();
        }
    }
}
