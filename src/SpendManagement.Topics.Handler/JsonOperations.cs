using System.Text.Json;

namespace SpendManagement.Topics.Handler
{
    public static class JsonOperations
    {
        private static readonly JsonSerializerOptions s_writeOptions = new()
        {
            WriteIndented = true
        };

        public static string Serialize<T>(T value)
        {
            return JsonSerializer.Serialize(value, s_writeOptions);
        }
    }
}
