using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers
{
  public class HomeController : Controller
  {

    // ==== Home =====
    [HttpGet("")]
    public IActionResult Home()
    {
      return View("index");
    }

  }
}