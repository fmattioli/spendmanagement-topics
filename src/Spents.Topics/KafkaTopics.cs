namespace Spents.Topics
{
    public static class KafkaTopics
    {
        public static class Events
        {
            /// <summary>
            /// Spents receipts topic
            /// </summary>
            public const string Receipt = "spents-receipts";

            /// <summary>
            /// Spents receipts telemetry topic
            /// </summary>
            public const string ReceiptTelemetry = "spents-receipts-telemetry";
        }
    }
}