// See https://aka.ms/new-console-template for more information
using KafkaConsumer;

Console.WriteLine("Hello!, This is Kafka Consumer Application");
ConsumeMessage consumeMessage = new ConsumeMessage();
consumeMessage.ReadMessage();
