using Microsoft.AspNetCore.Mvc;
namespace dojo_survey.Controllers
{
  public class DojoController : Controller
  {

    // -------------------------------------------------------------------------
    // Home http
    // -------------------------------------------------------------------------
    [HttpGet("")]
    public IActionResult Home()
    {
      return View("index");
    }
  // ---------------------------------------------------------------------------
  // result hhtp
  // ---------------------------------------------------------------------------
    [HttpPost("result")]
    public IActionResult Reeqwweqsult(string name, string location,string lang, string commend)
    {
      ViewBag.name = name;
      ViewBag.location = location;
      ViewBag.lang = lang;
      ViewBag.commend = commend;
      return View("result");
    }

  }
}