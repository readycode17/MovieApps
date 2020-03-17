using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MovieApp.data.Models;
using MovieApp.repos.Contracts;

namespace MovieApp.repos
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        private readonly MovieDBContext _dbContext;

        public MovieRepository(MovieDBContext dbContext) : base(dbContext)
        {

        }


        public Movie GetById(int id)
        {
            _dbContext.Movie.ToList();
            return GetById(id);
        }


        //public IEnumerable<Movie> GetAll()
        //{

        //    return GetAll().ToList();
        //}

        public Movie GetMovieById(int id)
        {
            return GetById(id);
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return GetAll();
        }
    }

}
