using Daybreaksoft.Extensions.TimeZone;
using Microsoft.AspNetCore.Mvc;

namespace Daybreaksoft.Extensions.AspNetCore.TimeZone
{
    public static class TimeZoneAppBuilderExtensions
    {
        public static void ConfigureTimeZoneModelBinderProviders(this MvcOptions options)
        {
            options.ModelBinderProviders.Insert(0, new LocalDateModelBinderProvider());
            options.ModelBinderProviders.Insert(0, new UtcDateModelBinderProvider());
        }

        public static void ConfigureTimeZoneJsonConverters(this MvcJsonOptions options)
        {
            options.SerializerSettings.Converters.Add(new LocalDateJsonConverter());
            options.SerializerSettings.Converters.Add(new UtcDateJsonConverter());
        }
    }
}
