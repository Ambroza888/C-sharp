using Microsoft.AspNetCore.Mvc;
namespace dojo_survey.Controllers
{
  public class DojoController : Controller
  {

    // ==== Home =====
    [HttpGet("")]
    public IActionResult Home()
    {
      return View("index");
    }



  }
}