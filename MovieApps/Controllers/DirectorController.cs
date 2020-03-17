using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.repos;
using MovieApp.repos.Contracts;

namespace MovieApps.Controllers
{
    public class DirectorController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DirectorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var toList = _unitOfWork.Director.GetAllDirectors();
            return View(toList);
        }

        public IActionResult ABC()
        {
            var myList = _unitOfWork.Director.GetbyDirectorsCon();
            return View(myList);
        }
    }
}