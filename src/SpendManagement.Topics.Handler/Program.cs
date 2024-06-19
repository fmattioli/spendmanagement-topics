using Confluent.Kafka.Admin;
using Confluent.Kafka;
using SpendManagement.Topics.Handler.conf;
using System.Text.Json;
using SpendManagement.Topics.Handler;

string projectDirectory = Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.Parent.FullName;
string filePath = Path.Combine(projectDirectory, "conf", "kakfatopics.json");
Console.WriteLine(filePath);

if (File.Exists(filePath))
{
    var config = new AdminClientConfig
    {
        BootstrapServers = Environment.GetEnvironmentVariable("BOOTSTRAPSERVERS"),
        SaslMechanism = SaslMechanism.ScramSha256,
        SecurityProtocol = SecurityProtocol.SaslSsl,
        SaslUsername = Environment.GetEnvironmentVariable("SASLPASSWORD"),
        SaslPassword = Environment.GetEnvironmentVariable("SASLUSERNAME")
    };

    string jsonString = File.ReadAllText(filePath);
    var topicConfigs = JsonSerializer.Deserialize<KafkaTopicsConfig>(jsonString);

    topicConfigs?.KafkaTopics?
        .Where(topics => topics.CreatedAt == DateTime.MinValue)
        .ToList()
        .ForEach(async topic =>
        {
            var topicSpec = new TopicSpecification
            {
                Name = IsDevelopmentEnvironment() ? $"dev.{topic.Name!}" : $"live.{topic.Name!}",
                NumPartitions = topic.NumberOfPartitions,
                ReplicationFactor = 1
            };

            using var admin = new AdminClientBuilder(config).Build();
            await admin.CreateTopicsAsync([topicSpec]);
            Console.WriteLine($"Topic {topic.Name!} created with successfully!");
            topic.CreatedAt = DateTime.Now;
        });

    string newJsonString = JsonOperations.Serialize(topicConfigs);
    File.WriteAllText(filePath, newJsonString);
}

static bool IsDevelopmentEnvironment()
{
    return Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "dev" || string.IsNullOrEmpty(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));
}