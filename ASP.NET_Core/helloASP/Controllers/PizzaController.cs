using Microsoft.AspNetCore.Mvc;
namespace helloASP.Controllers
{
  public class PizzaController : Controller
  {
    //Portfolio assigmment
    [HttpGet("")]
    public string Pizza()
    {
      return "This is my Pizza";
    }

    //Portfolio assigments II
    [HttpGet("{projects}")]
    public string hello(string projects)
    {
      return $"Hello From {projects}";
    }

    // Portfolio Assigments III
    [HttpGet("users/{username}/{papi}")]
    public string HelloUser(string username,string papi)
    {
      return $"Hello {username} and you live in {papi}"; 
    }
    // ================= Views introductions ===============
    
    [HttpGet("vvv")]
    public ViewResult index()
    {
      return View("index");
    }
    // Redirect from vvv --- go ---- > bra
    [HttpGet("go")]
    public RedirectToActionResult go()
    {
      return RedirectToAction("bra");
    }
    // render View("BRA")
    [HttpGet("bra")]
    public ViewResult bra()
    {
      return View("bra");
    }

  [HttpGet("users/{username}/{location}")]
  public JsonResult Hi(string username,string location)
  {
    var response = new {user = username,place=location};
    var stringarray = new string[]
    {
      "veso","This","papi"
    };
    bool isCool = true;
    return Json(response);
  }

  }
}