using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.data.Models;
using MovieApp.repos.Contracts;

namespace MovieApps.Controllers
{
    public class GenreController : Controller
    {
        private readonly MovieDBContext _dbContext;
        private readonly IUnitOfWork _unitOfWork;
        public GenreController(IUnitOfWork unitOfWork, MovieDBContext dbContext)
        {
            _dbContext = dbContext;
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var yourList = _dbContext.Genre.ToList();
            var myList = _unitOfWork.Genre.GetAllGenres();
            return View(myList);
        }

        public IActionResult FilterByLetter()
        {
            var myFilter = _unitOfWork.Genre.GetByAllGenresLetters();
            return View(myFilter);
        }

        public IActionResult FilterByWord()
        {
            var myFilter = _unitOfWork.Genre.GetByWords("Comedy");
            return View(myFilter);
        }
    }
}