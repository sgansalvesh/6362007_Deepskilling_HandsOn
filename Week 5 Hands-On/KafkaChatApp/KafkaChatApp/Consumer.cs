using Confluent.Kafka;
using System;

namespace KafkaChatApp
{
    public class Consumer
    {
        public static void ReadMessages(string topic, string bootstrapServers, string groupId)
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = bootstrapServers,
                GroupId = groupId,
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
            consumer.Subscribe(topic);

            Console.WriteLine("📥 Listening for messages (Press Ctrl+C to stop)...");

            try
            {
                while (true)
                {
                    var consumeResult = consumer.Consume();
                    Console.WriteLine($"📨 Received: {consumeResult.Message.Value}");
                }
            }
            catch (OperationCanceledException)
            {
                consumer.Close();
                Console.WriteLine("❌ Consumer stopped.");
            }
        }
    }
}
