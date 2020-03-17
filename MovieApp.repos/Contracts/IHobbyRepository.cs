using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.data.Models;

namespace MovieApp.repos.Contracts
{
    public interface IHobbyRepository
    {
        IEnumerable<Hobby> getAllAddress();
    }
}
