using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.MovieService
{
    public class NetflixStreamService : IStreamService
    {
        public List<string> ListMovies()
        {
            return new List<string>()
            {
                "Cast Away",
                "3 Idiots",
                "The Mechanic",
                "The Mechanic 2",
                "Equalizer 2",
                "Transporter",
                "Transporter 2",
                "A few good men"
            };
        }
    }
}
