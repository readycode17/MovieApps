using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.data.Models;
using MovieApp.repos;
using MovieApp.repos.Contracts;

namespace MovieApps.Controllers
{
    public class MovieController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly MovieDBContext _db;

        public MovieController(IUnitOfWork unitOfWork, MovieDBContext db)
        {
            _unitOfWork = unitOfWork;
            _db = db;
        }
        public IActionResult MovieIndex()
        {
            var toList = _unitOfWork.Movie.GetAllMovies();
            return View(toList);
        }

        public IActionResult Index()
        {
            
            
            var newList = _db.Movie.ToList();
            var toList = _unitOfWork.Movie.GetAllMovies();

            return View(toList);
        }

        
    }
}