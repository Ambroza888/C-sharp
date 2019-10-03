using Microsoft.AspNetCore.Mvc;
namespace helloASP.Controllers
{
  public class PizzaController : Controller
  {
    //home
    [HttpGet("")]
    public string Pizza()
    {
      return "This is my Pizza";
    }
    ///Pizza
    [HttpGet("{projects}")]
    public string hello(string projects)
    {
      return $"Hello From {projects}";
    }
    // id passing params localhost:5000/users/???
    [HttpGet("users/{username}/{papi}")]
    public string HelloUser(string username,string papi)
    {
      return $"Hello {username} and you live in {papi}"; 
    }



  }
}