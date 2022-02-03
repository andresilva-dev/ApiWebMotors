using Facade.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using WebMotors.Facade;

namespace WebMotors.Controllers
{
    public class HomeController : Controller
    {
        FachadaDeVeiculos _fachadaDeVeiculos = new FachadaDeVeiculos();
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Index(int page = 1)
        {
            var carrosModel = _fachadaDeVeiculos.ObtenhaVeiculosWebMotors(page);
            CatalogoModel catalogo = new CatalogoModel { Carros = carrosModel, Pagina = page };
            return View(catalogo);
        }

        public ActionResult About()
        {
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