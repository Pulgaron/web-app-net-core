using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SistemasWeb.Areas.Principal.Controllers
{
    //Indico al controlador que se encuentra en el area principal
    [Area("Principal")]
    public class PrincipalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
