using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using helloMVC.Models;

namespace helloMVC.Controllers
{
    public class HomeController : Controller
    {
        // ---------------------------------------------------------------------
        // Home
        // ---------------------------------------------------------------------
        [HttpGet("")]
        public IActionResult Index()
        {
            string hello = "PAPICHULIOS !!!";

            return View("index",hello);
        }
        // ---------------------------------------------------------------------
        // Numbers
        // ---------------------------------------------------------------------
        [HttpGet("numbers")]
        public IActionResult numbers()
        {
            int[] arr = {
                1,2,3,10,43,6
            };
            return View("numbers",arr);
        }
        // ---------------------------------------------------------------------
        // users
        // ---------------------------------------------------------------------
        [HttpGet("users")]
        public IActionResult Users()
        {
            User veso = new User()
            {
                FirstName = "Veso",
                LastName = "MladFOREVER"
            };
            User stas = new User()
            {
                FirstName = "Stas",
                LastName = "Stasi4"
            };
            User ferdi = new User()
            {
                FirstName = "Perdi",
                LastName = "Pedresito"
            };
            User hayan = new User()
            {
                FirstName = "Hayan",
                LastName = ""
            };
            List <User> all = new List<User>()
            {
                veso,stas,ferdi,hayan
            };
            return View("users",all);
        }
        // ---------------------------------------------------------------------
        // ONE USER
        // ---------------------------------------------------------------------
        [HttpGet("user")]
        public IActionResult one()
        {
            User qwe = new User()
            {
                FirstName = "Bryana",
                LastName = "The best instructur"
            };
            return View("ONE",qwe);
        }





        // ---------------------------------------------------------------------
        // Error
        // ---------------------------------------------------------------------
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
