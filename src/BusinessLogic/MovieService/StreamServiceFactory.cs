using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.MovieService
{
    public class StreamServiceFactory : IStreamServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public StreamServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        IStreamService IStreamServiceFactory.GetStreamService(StreamServiceEnum streamService)
        {
            switch (streamService)
            {
                case StreamServiceEnum.Amazon:
                   return (IStreamService)_serviceProvider.GetService((typeof(AmazonStreamService)));                    
                case StreamServiceEnum.Netflix:
                    return (IStreamService)_serviceProvider.GetService((typeof(NetflixStreamService)));                   
                
                default:
                    return null;
            }
        }
    }
}
