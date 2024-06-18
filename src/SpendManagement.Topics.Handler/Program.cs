using Confluent.Kafka.Admin;
using Confluent.Kafka;
using SpendManagement.Topics.Receipts;

var topicsNames = new string[]
{
    KafkaTopics.Commands.GetReceiptCommands("lives"),
    KafkaTopics.Events.GetReceiptEvents("lives"),
};

var config = new AdminClientConfig
{
    BootstrapServers = "unique-camel-8345-eu2-kafka.upstash.io:9092",
    SaslMechanism = SaslMechanism.ScramSha256,
    SecurityProtocol = SecurityProtocol.SaslSsl,
    SaslUsername = "dW5pcXVlLWNhbWVsLTgzNDUk8RLsTQoJ7i1X5nGz0HNWvMirQdh7ldh4--2vvmY",
    SaslPassword = "ZmExNzIwZDgtYTI4ZC00OTFhLWI5YzgtMzMyMzFkYjBiMjEz"
};

using (var admin = new AdminClientBuilder(config).Build())
{
    try
    {
        foreach (var topic in topicsNames)
        {
            var topicSpec = new TopicSpecification
            {
                Name = topic!,
                NumPartitions = 6,
                ReplicationFactor = 1
            };

            await admin.CreateTopicsAsync([topicSpec]);
            Console.WriteLine($"Tópico criado com sucesso: {topic!}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro ao criar o tópico: {ex.Message}");
    }
}