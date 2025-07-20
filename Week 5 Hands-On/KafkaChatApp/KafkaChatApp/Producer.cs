using Confluent.Kafka;
using System;
using System.Threading.Tasks;

namespace KafkaChatApp
{
    public class Producer
    {
        public static async Task SendMessages(string topic, string bootstrapServers)
        {
            var config = new ProducerConfig { BootstrapServers = bootstrapServers };

            using var producer = new ProducerBuilder<Null, string>(config).Build();

            Console.WriteLine("💬 Type messages to send to Kafka (type 'exit' to quit):");

            while (true)
            {
                var input = Console.ReadLine();
                if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
                    break;

                var result = await producer.ProduceAsync(topic, new Message<Null, string> { Value = input });

                Console.WriteLine($"✅ Sent to {result.TopicPartitionOffset}: {input}");
            }
        }
    }
}
