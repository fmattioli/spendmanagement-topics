namespace Spents.Topics
{
    public static class KafkaTopics
    {
        public static class Events
        {
            /// <summary>
            /// topic for receipt events
            /// </summary>
            public const string ReceiptEvents = "spents-receipts-events";

            /// <summary>
            /// Spents receipts telemetry topic
            /// </summary>
            public const string ReceiptTelemetry = "spents-receipts-telemetry";
        }

        public static class Documents
        {
            /// <summary>
            /// topic for receipt documents
            /// </summary>
            public const string ReceiptDocuments = "spents-receipts-documents.v1";
        }
    }
}