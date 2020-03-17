using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MovieApp.data.Models;
using MovieApp.repos.Contracts;

namespace MovieApp.repos
{
   public class GenreRepository:GenericRepository<Genre>,IGenreRepository
   {
       private readonly MovieDBContext _dbContext;
        public GenreRepository(MovieDBContext dbContext) : base(dbContext)
        {
            
        }


        public  Genre GetById(int id)
        {
            _dbContext.Genre.ToList(); 
            return GetById(id);
        }



        public Genre GetMovieById(int id)
        {
            return GetById(id);
        }

  

        public IEnumerable<Genre> GetAllGenres()
        {
            return GetAll().ToList();
        }

        public IEnumerable<Genre> GetByAllGenresLetters()
        {
            return FindByConditon(x => x.Name.Contains("a"), false);
        }

        public IEnumerable<Genre> GetByWords(string s)
        {
            return FindByConitions(a => a.Name.Equals(s));
        }
   }
}
