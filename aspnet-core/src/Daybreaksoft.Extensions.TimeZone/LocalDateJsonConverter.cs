using System;
using Newtonsoft.Json;

namespace Daybreaksoft.Extensions.TimeZone
{
    public class LocalDateJsonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, ((LocalDate?) value)?.ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (DateTime.TryParse(reader.Value.ToString(), out var date))
            {
                return new LocalDate(date);
            }

            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LocalDate) || objectType == typeof(LocalDate?);
        }
    }
}
