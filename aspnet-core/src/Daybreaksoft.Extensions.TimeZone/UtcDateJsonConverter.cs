using System;
using Newtonsoft.Json;

namespace Daybreaksoft.Extensions.TimeZone
{
    public class UtcDateJsonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, ((UtcDate?) value)?.ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (DateTime.TryParse(reader.Value.ToString(), out var date))
            {
                return new UtcDate(date);
            }

            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(UtcDate) || objectType == typeof(UtcDate?);
        }
    }
}
