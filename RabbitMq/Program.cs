using RabbitMQ.Client;
using System;
using System.Text;

namespace RabbitMq
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Hello";
            using (IConnection connection = new ConnectionFactory().CreateConnection())
            {
                using (IModel channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue:"hello", false, false, false, null);
                    channel.BasicPublish(string.Empty, routingKey: "hello", null, Encoding.UTF8.GetBytes(data));
                }
            }
        }
    }
}
