using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.MovieService
{
    public class AmazonStreamService : IStreamService
    {
        public List<string> ListMovies()
        {
            return new List<string>()
            {
                "Shawshank Redemption",
                "Poseidon",
                "Red",
                "Red 2",
                "Equalizer"
            };
        }
    }
}
