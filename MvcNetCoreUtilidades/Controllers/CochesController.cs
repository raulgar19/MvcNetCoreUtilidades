using Microsoft.AspNetCore.Mvc;
using MvcNetCoreUtilidades.Models;
using MvcNetCoreUtilidades.Repositories;

namespace MvcNetCoreUtilidades.Controllers
{
    public class CochesController : Controller
    {
        private RepositoryCoches repo;

        public CochesController(RepositoryCoches repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _CochesPartial()
        {
            List<Coche> cars = this.repo.GetCoches();
            return PartialView("_CochesPartial", cars);
        }

        public IActionResult _CochesDetails(int idcoche)
        {
            Coche car = this.repo.FindCoche(idcoche);

            return PartialView("_CochesDetailsView", car);
        }

        public IActionResult Details(int idcoche)
        {
            Coche car = this.repo.FindCoche(idcoche);

            return View(car);
        }
    }
}
