namespace Spents.Topics
{
    public static class KafkaTopics
    {
        public static class Events
        {
            /// <summary>
            /// topic for receipt events
            /// </summary>
            public const string ReceiptEventTopicName = "spents-receipts-events.v1";

            /// <summary>
            /// Spents receipts telemetry topic
            /// </summary>
            public const string ReceiptTelemetry = "spents-receipts-telemetry";
        }

        public static class Commands
        {
            /// <summary>
            /// topic for receipt documents
            /// </summary>
            public const string ReceitCommandTopicName = "spents-receipts-commands.v1";
        }
    }
}