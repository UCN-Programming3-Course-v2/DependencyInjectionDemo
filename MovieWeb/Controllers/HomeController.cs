using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieDAL;
using MovieDAL.Daos;
using MovieDAL.Model;
using MovieWeb.Models;
using System.Diagnostics;

namespace MovieWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       // private readonly IDao<Movie> _movieDao = new MovieDao(); // This is BAD!!! High coupling and all that
        private readonly IDao<Movie> _movieDao; // This is BAD!!! High coupling and all that
        public HomeController(ILogger<HomeController> logger, IDao<Movie> movieDao)
        {
            _logger = logger;
            _movieDao = movieDao;
        }

        public IActionResult Index()
        {
            var model = _movieDao.GetAll();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
