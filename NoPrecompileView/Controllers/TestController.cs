using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NoPrecompileView.Controllers
{
    [Area("TestArea")]
    public class TestController : Controller
    {
        public IActionResult TestPage()
        {
            return View();
        }
    }
}