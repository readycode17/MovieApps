using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.data.Models;

namespace MovieApp.repos.Contracts
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> GetAllGenres();
        IEnumerable<Genre> GetByAllGenresLetters();

        IEnumerable<Genre> GetByWords(string s);
    }
}
