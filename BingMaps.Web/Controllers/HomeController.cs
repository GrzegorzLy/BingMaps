using BingMaps.Core.Domain;
using BingMaps.Core.Repositories;
using BingMaps.Web.Models;
using System.Linq;
using System.Web.Mvc;

namespace BingMaps.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<Point> _repository;
        public HomeController(IRepository<Point> repository)
        {
            _repository = repository;
        }
        public ActionResult Index()
        {
            return View(new PointViewModel { City = "Kraków" });
        }

        public ActionResult About()
        {
            _repository.Add(new Point("sas", 23323, 2333));
            var all = _repository.GetAll().ToList();
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}