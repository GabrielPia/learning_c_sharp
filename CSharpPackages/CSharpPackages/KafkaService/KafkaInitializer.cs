using Confluent.Kafka;
using System.Net;

namespace CSharpPackages.KafkaService
{
    public class KafkaInitializer
    {
        public ProducerConfig KafkaProducerConfig { get; private set; }
        public ConsumerConfig KafkaConsumerConfig { get; private set; }

        public List<string> Topics { get; private set; } = new List<string>();

        public KafkaInitializer()
        {
            KafkaProducerConfig = new ProducerConfig()
            {
                BootstrapServers = "localhost:9092",
                ClientId = "Teste_C#",
            };

            KafkaConsumerConfig = new ConsumerConfig()
            {
                BootstrapServers = "localhost:9092",
                GroupId = "Gabriel_teste",
                AutoOffsetReset = AutoOffsetReset.Earliest,
                FetchWaitMaxMs=500
            };

            Topics.Add("sas-message");
        }

        public void initProducer()
        {
            using (var producer = new ProducerBuilder<Null, string>(KafkaProducerConfig).Build())
            {

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Producing kafka message");
                    producer.Produce("sas-message", new Message<Null, string> { Value = "Test Message" });
                    Thread.Sleep(3000);
                }

            }
        }


        public void initConsumer()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            Console.CancelKeyPress += (_, e) =>
            {
                e.Cancel = true;
                cts.Cancel();
            };
            using (var consumer = new ConsumerBuilder<Ignore, string>(KafkaConsumerConfig).Build())
            {
                foreach (string topic in Topics)
                {
                    consumer.Subscribe(topic);
                }
                try
                {
                    while (true)
                    {
                        Console.WriteLine("Start Reading kafka topic");
                        var consumedMessage = consumer.Consume(cts.Token);
                        string key = consumedMessage.Message.Key == null ? "Null" : consumedMessage.Message.Key.ToString();
                        Console.WriteLine($"Consumed record with key {key} and value {consumedMessage.Message.Value}");
                    }
                }
                catch (OperationCanceledException e)
                {
                    Console.WriteLine("Leitura do consumidor kafka interrompida");
                }
                finally
                {
                    consumer.Close();
                }
            }
        }
    }
}
