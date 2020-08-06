
using Confluent.Kafka;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Kafka
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new Dictionary<string, string>
            {
                { "bootstrap.servers", "localhost:9092" }
            };

            string kafkaTopic = "testtopic";
            using (var producer = new ProducerBuilder<Null, string>(config)
              .SetKeySerializer(Serializers.Null)
              .SetValueSerializer(Serializers.Utf8)
              .Build())
            {
                // Send 10 messages to the topic
                for (int i = 0; i < 10; i++)
                {
                    var message = $"Event {i}";
                    var result = producer.ProduceAsync(kafkaTopic, new Message<Null, string> { Value = message }).GetAwaiter().GetResult();
                    Console.WriteLine($"Event {i} sent on Partition: {result.Partition} with Offset: {result.Offset}");
                }
            }
        }
    }
}
