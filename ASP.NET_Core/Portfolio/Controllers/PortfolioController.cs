using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers
{
  public class PortfolioController : Controller
  {

    // ==== Home =====
    [HttpGet("")]
    public IActionResult Home()
    {
      return View("index");
    }
    //=========== Projects =========
    [HttpGet("projects")]
    public IActionResult Projects()
    {
      return View("projects");
    }
    //============= Contacts ===========
    [HttpGet("contacts")]
    public IActionResult Contacts()
    {
      return View("contacts");
    }





  }
}