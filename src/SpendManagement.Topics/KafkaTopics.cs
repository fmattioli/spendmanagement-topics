namespace SpendManagement.Topics
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
            /// topic for receipt documents
            /// </summary>
            public static string GetReceiptCommands(string environment)
            {
                return environment + ".spendmanagement.receipts.commands";
            }
        }
    }
}