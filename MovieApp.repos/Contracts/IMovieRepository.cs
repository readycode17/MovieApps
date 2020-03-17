using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.data.Models;

namespace MovieApp.repos.Contracts
{
    public interface IMovieRepository
    {
       // IEnumerable<Movie> GetTop10MovieInYear(int year,int count);

        Movie GetMovieById(int id);

        IEnumerable<Movie> GetAllMovies();
    }
}
