using Microsoft.AspNetCore.Mvc;

namespace WordSearch.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
