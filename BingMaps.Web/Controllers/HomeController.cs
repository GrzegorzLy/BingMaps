using AutoMapper;
using BingMaps.Core.Domain;
using BingMaps.Core.Repositories;
using BingMaps.Core.Services;
using BingMaps.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BingMaps.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<Point> _repository;
        private readonly IPointService _pointService;
        private readonly IMapper _mapper;
        public HomeController(IRepository<Point> repository, IPointService pointService, IMapper mapper)
        {
            _repository = repository;
            _pointService = pointService;
            _mapper = mapper;
        }
        public ActionResult Index()
        {
            // var points = await _pointService.GetListOfPointAsync("Kraków Chmieleniec");
           // var model = _mapper.Map<List<PointViewModel>>(points);
            return View();
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