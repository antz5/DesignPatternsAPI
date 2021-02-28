using BusinessLogic.MovieService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Infrastructure
{
    public static  class MovieServiceCollection
    {
        public static void RegisterMovieServices(this IServiceCollection services)
        {
            services.AddScoped<IStreamServiceFactory, StreamServiceFactory>();
            services.AddScoped<NetflixStreamService>();
            services.AddScoped<IStreamService, NetflixStreamService>(s=>s.GetService<NetflixStreamService>());
            services.AddScoped<AmazonStreamService>();
            services.AddScoped<IStreamService, AmazonStreamService>(s => s.GetService<AmazonStreamService>());
        }
    }
}
