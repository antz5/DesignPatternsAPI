using BusinessLogic;
using BusinessLogic.MovieService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : Controller
    {
        private readonly IStreamServiceFactory _streamServiceFactory;

        public MoviesController(IStreamServiceFactory streamServiceFactory)
        {
            _streamServiceFactory = streamServiceFactory;
        }
        [HttpGet("api/{streamService}")]
        public IEnumerable<string> GetMovies(StreamServiceEnum streamService)
        {
            return _streamServiceFactory.GetStreamService(streamService).ListMovies();
        }
    }
}
