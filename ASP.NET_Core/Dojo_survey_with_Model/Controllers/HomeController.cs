using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dojo_survey_with_Model.Models;

namespace Dojo_survey_with_Model.Controllers
{
    public class HomeController : Controller
    {
        // ---------------------------------------------------------------------
        // Home Page
        // ---------------------------------------------------------------------
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }



// -----------------------------------------------------------------------------
// Survey HTTP
// -----------------------------------------------------------------------------
        [HttpPost("survey")]
        public IActionResult Submission(Survey yo)
        {

            return View("result",yo);
        }









        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
