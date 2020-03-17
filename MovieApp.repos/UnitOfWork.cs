using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieApp.data.Models;
using MovieApp.repos.Contracts;

namespace MovieApp.repos
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly MovieDBContext _dbContext;
        private  IMovieRepository _movieRepository;
        private  IAddressRepository _addressRepository;
        private  IHobbyRepository _hobbyRepository;
        private  IGenreRepository _genreRepository;
        private  IDirectorRepository _directorRepository;
    
        public UnitOfWork(MovieDBContext dbContext)
        {
            _dbContext = dbContext;
           
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public Task Commit()
        {
            throw new NotImplementedException();
        }

        public IMovieRepository Movie
        {
            get
            {
                if (_movieRepository == null) _movieRepository = new MovieRepository(_dbContext);
                    return _movieRepository;
                
            }
           
        }

        public IDirectorRepository Director
        {
            get
            {
                if (_directorRepository == null) _directorRepository = new DirectorRepository(_dbContext);
                return _directorRepository;
            }

        }

        public IGenreRepository Genre
        {
            get { return _genreRepository = new GenreRepository(_dbContext); }
        }

        public IAddressRepository Address { get;  }
        public IHobbyRepository Hobby { get;  }
    }
}
