using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zorb.UI.Controllers
{
    public class ChamadoController : Controller
    {
        // GET: Chamado
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Novo()
        {
            return View();
        }

        public ActionResult EmAberto()
        {
            return View();
        }
    }
}