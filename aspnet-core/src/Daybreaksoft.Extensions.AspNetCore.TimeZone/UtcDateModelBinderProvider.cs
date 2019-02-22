using System;
using Daybreaksoft.Extensions.TimeZone;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Daybreaksoft.Extensions.AspNetCore.TimeZone
{
    public class UtcDateModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context.Metadata.ModelType == typeof(UtcDate) || context.Metadata.ModelType == typeof(UtcDate?))
            {
                return new UtcDateModelBinder(context.Services.GetRequiredService<ILoggerFactory>());
            }

            return null;
        }
    }
}
