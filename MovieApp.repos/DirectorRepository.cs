using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MovieApp.data.Models;
using MovieApp.repos.Contracts;

namespace MovieApp.repos.Contracts
{
 public class DirectorRepository:GenericRepository<Director>, IDirectorRepository

    {   
        private readonly MovieDBContext _dbContext;



        public void Add(Director entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Director entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Director entity)
        {
            throw new NotImplementedException();
        }

   
        public DirectorRepository(MovieDBContext dbContext) : base(dbContext)
        {
        }

        //public IEnumerable<Director> GetAllDirectoryByMovieLanguage(string language)
        //{
        //    return FindbyCond
        //}

        public IEnumerable<Director> GetAllDirectoryByMovieLanguage(string language)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Director> GetAllDirectors()
        {
            return GetAll();
        }

        public IEnumerable<Director> GetbyDirectorsCon()
        {
            return FindByConditon(x => x.Firstname.Contains("b"),false);
        }
    }
}
