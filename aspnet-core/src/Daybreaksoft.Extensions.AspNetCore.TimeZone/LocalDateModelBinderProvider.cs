using System;
using Daybreaksoft.Extensions.TimeZone;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Daybreaksoft.Extensions.AspNetCore.TimeZone
{
    public class LocalDateModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context.Metadata.ModelType == typeof(LocalDate) || context.Metadata.ModelType == typeof(LocalDate?))
            {
                return new LocalDateModelBinder(context.Services.GetRequiredService<ILoggerFactory>());
            }

            return null;
        }
    }
}
