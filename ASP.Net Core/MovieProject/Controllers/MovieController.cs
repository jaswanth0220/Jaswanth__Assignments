using Microsoft.AspNetCore.Mvc;
using MovieProject.Models;

namespace MovieProject.Controllers
{
    public class MovieController : Controller
    {
        MovieRepository repository;

        public MovieController()
        {
            repository = new MovieRepository();
        }

        public IActionResult Index()
        {
            var AllMovies = repository.GetAllMovies();
            return View(AllMovies);
        }

        public IActionResult Details(string Name)
        {
            var movie = repository.GetMovieByName(Name);
            return View(movie);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Add(Movie movie)
        {
            repository.AddMovie(movie);
            return RedirectToAction("Index");
        }
    }
}
