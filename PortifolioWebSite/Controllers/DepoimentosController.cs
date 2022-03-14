using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortifolioWebSite.Controllers
{
    public class DepoimentosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
