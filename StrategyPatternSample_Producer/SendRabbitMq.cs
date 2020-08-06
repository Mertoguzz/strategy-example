using RabbitMQ.Client;
using StrategyPatternSample_Producer;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternSample
{
    class SendRabbitMq : Strategy
    {
        Helper helper = new Helper();
        public override void Send(string queueName, EmailMessage messageBase)
        {

            using (IConnection connection = new ConnectionFactory {HostName=helper.GetConfig("rabbitMqConfigs", "hostName") }.CreateConnection())
            {
                using (IModel channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: queueName, false, false, false, null);
                    channel.BasicPublish(string.Empty, routingKey: queueName, null, Encoding.UTF8.GetBytes(messageBase.Content.ToString()));
                }
            }

        }

    }
}


