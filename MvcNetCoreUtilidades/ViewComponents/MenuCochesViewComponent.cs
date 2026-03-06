using Microsoft.AspNetCore.Mvc;
using MvcNetCoreUtilidades.Models;
using MvcNetCoreUtilidades.Repositories;

namespace MvcNetCoreUtilidades.ViewComponents
{
    public class MenuCochesViewComponent : ViewComponent
    {
        private RepositoryCoches repo;

        public MenuCochesViewComponent()
        {
            this.repo = new RepositoryCoches();
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Coche> cars = this.repo.GetCoches();
            return View(cars);
        }
    }
}