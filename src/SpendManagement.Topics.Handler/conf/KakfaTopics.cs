namespace SpendManagement.Topics.Handler.conf
{
    public class KafkaTopicsConfig
    {
        public IEnumerable<KafkaTopics> KafkaTopics { get; set; } = [];
    }

    public class KafkaTopics()
    {
        public string Name { get; set; } = null!;
        public int NumberOfPartitions { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
