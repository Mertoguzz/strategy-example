using StrategyPatternSample_Producer;
using System;

namespace StrategyPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            SendMsMq sendMsMq = new SendMsMq();
            SendRabbitMq sendRabbitMq = new SendRabbitMq();
            Helper helper = new Helper();

            //produce email message
            var emailMessage = new EmailMessage
            {
                Content = "Email Content",
                Subject = "Email Subject",
                To = "mm@mm.com.tr"
            };
            Sender senderMsMq = new Sender(sendMsMq,helper.GetConfig("MsMqConfigs", "queueName") , emailMessage);
            Sender senderRabbitMq = new Sender(sendRabbitMq, helper.GetConfig("RabbitMqConfigs", "queueName"), emailMessage);
            Console.Read();
        }
    }
}
