using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Online_Shop.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        [Route("category")]
        public IActionResult Category()
        {
            return View("Category");
        }

        [Route("specials")]
        public IActionResult Specials()
        {
            return View("Specials");
        }

        [Route("details")]
        public IActionResult Details()
        {
            return View("Details");
        }
    }
}