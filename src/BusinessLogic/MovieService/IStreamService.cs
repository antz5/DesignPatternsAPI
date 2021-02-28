using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.MovieService
{
    public interface IStreamService
    {
        List<string> ListMovies();
    }
}
