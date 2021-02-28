using BusinessLogic;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Infrastructure
{
    public static class FileServiceCollection
    {
        public static IServiceCollection RegisterFileServices(this IServiceCollection services)
        {
            services.AddTransient<IFileReaderAction, XmlReaderAction>();
            return services;
        }
    }
}
