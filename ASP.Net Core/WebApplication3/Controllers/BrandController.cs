using WebApplication3.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Controllers
{
    public class BrandController : Controller
    {
        private readonly BikeStoreContext bikeStoreContext;

        public BrandController()
        {
            bikeStoreContext = new BikeStoreContext();
        }
        public IActionResult Index()
        {
            var brands = bikeStoreContext.Brands.ToList();
            return View(brands);
        }
        public IActionResult Details(int BikeId)
        {
            var Bike = bikeStoreContext.Brands.SingleOrDefault(e => e.BrandId == BikeId);
            return View(Bike);
        }

    }
}
