using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Courserep.ExtensionService
{
    public static class ExtensionService
    {
        public static void ConfigureCors(this IServiceCollection service)
        {
            service.AddCors(opt =>
           opt.AddPolicy("CorsPolicy", policy =>
           policy.AllowAnyHeader()
           .AllowAnyMethod()
           .AllowAnyOrigin()
           .AllowAnyMethod()));
        }

        public static void ConfigureIISOptions(this IServiceCollection service) =>
            service.Configure<IISOptions>(opt => { });


    }
}
