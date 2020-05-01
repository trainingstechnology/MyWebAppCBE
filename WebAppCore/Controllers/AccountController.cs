using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppCore.Models;

namespace WebAppCore.Controllers
{
    public class AccountController : Controller
    {
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                //TODO:
                return RedirectToAction("Message");
            }
            else
            { 
                return View();
            }
        }

        [NonAction]
        protected object Add(int x, int y)
        {
            return x + y;
        }
    }
}