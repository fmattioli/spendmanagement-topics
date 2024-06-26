﻿namespace SpendManagement.Topics.Receipts
{
    public static class KafkaTopics
    {
        public static class Events
        {
            /// <summary>
            /// topic for receipt events
            /// </summary>
            public static string GetReceiptEvents(string environment)
            {
                return environment + ".spendmanagement.receipts.events";
            }
        }

        public static class Commands
        {
            /// <summary>
            /// topic for receipt commands
            /// </summary>
            public static string GetReceiptCommands(string environment)
            {
                return environment + ".spendmanagement.receipts.commands";
            }
        }
    }
}