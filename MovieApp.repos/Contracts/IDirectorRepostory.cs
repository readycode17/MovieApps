using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.data.Models;

namespace MovieApp.repos.Contracts
{
    public interface IDirectorRepository
    {
        IEnumerable<Director> GetAllDirectoryByMovieLanguage(string language);

        IEnumerable<Director> GetAllDirectors();
        IEnumerable<Director> GetbyDirectorsCon();
    }
}
