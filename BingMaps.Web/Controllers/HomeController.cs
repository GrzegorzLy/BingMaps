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
        public async Task<ActionResult> Index()
        {
            var points = await _pointService.GetListOfPointAsync("Kraków Chmieleniec");
            var model = _mapper.Map<List<PointViewModel>>(points);
            return View();
        }

        public async Task<ActionResult> AddressList(PointViewModel model)
        {
            var points = await _pointService.GetListOfPointAsync(model.AddressLine);
            var addresses = _mapper.Map<List<PointViewModel>>(points);

            var entities = _mapper.Map<List<Point>>(addresses);
            entities.ForEach(e => _repository.Add(e));          
            
            return View(addresses);
        }

        public async Task<ActionResult> About(PointViewModel model)
        {
            var points = await _pointService.GetListOfPointAsync(model.AddressLine);
            var addresses = _mapper.Map<List<PointViewModel>>(points);
            return View(addresses);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}