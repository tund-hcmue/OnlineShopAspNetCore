using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Online_Shop.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        [Route("myaccount")]
        public IActionResult MyAccount()
        {
            return View("myaccount");
        }

        [Route("register")]
        public IActionResult Register()
        {
            return View("Register");
        }
    }
}