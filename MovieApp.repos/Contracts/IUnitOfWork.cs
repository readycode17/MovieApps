using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.repos.Contracts
{
    public interface IUnitOfWork:IDisposable
    {
        Task Commit();
        IMovieRepository Movie { get; }
        IDirectorRepository Director { get; }
        IGenreRepository Genre { get;  }
        IAddressRepository Address { get; }
        IHobbyRepository Hobby { get;  }
    }
}
