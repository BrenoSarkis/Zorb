using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zorb.Fronteiras.Executores.Chamado.CriarChamado;

namespace Zorb.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICriarChamadoExecutor criarChamadoExecutor;

        public HomeController(ICriarChamadoExecutor criarChamadoExecutor)
        {
            this.criarChamadoExecutor = criarChamadoExecutor;
        }

        public ActionResult Index()
        {
            //criarChamadoExecutor.Executar(new CriarChamadoRequisicao());
            return View();
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