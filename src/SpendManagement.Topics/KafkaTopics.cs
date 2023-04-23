﻿namespace SpendManagement.Topics
{
    public static class KafkaTopics
    {
        public static class Events
        {
            /// <summary>
            /// topic for receipt events
            /// </summary>
            public const string ReceiptEventTopicName = "spend.management.receipts.events.v1";

            /// <summary>
            /// telemetry topic
            /// </summary>
            public const string ReceiptTelemetry = "spend.management.receipts.telemetry";
        }

        public static class Commands
        {
            /// <summary>
            /// topic for receipt documents
            /// </summary>
            public const string ReceiptCommandTopicName = "spend.management.receipts.commands.v1";
        }
    }
}