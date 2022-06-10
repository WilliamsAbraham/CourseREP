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




    }
}
