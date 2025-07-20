using System;
using System.Threading.Tasks;

namespace KafkaChatApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string bootstrapServers = "localhost:9092";
            string topic = "chat-topic";
            string groupId = "chat-group";

            Console.WriteLine("📡 Kafka Chat App");
            Console.WriteLine("Choose mode:");
            Console.WriteLine("1. Producer");
            Console.WriteLine("2. Consumer");

            var choice = Console.ReadLine();

            if (choice == "1")
            {
                await Producer.SendMessages(topic, bootstrapServers);
            }
            else if (choice == "2")
            {
                Consumer.ReadMessages(topic, bootstrapServers, groupId);
            }
            else
            {
                Console.WriteLine("❌ Invalid choice.");
            }
        }
    }
}
