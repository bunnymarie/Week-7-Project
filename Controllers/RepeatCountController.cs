using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordSearch.Models;

namespace WordSearch.Controllers
{
  public class RepeatCountController : Controller
  {
    [HttpGet("/form")]
    public ActionResult Form()
    {
      return View();
    }
    [HttpPost("/form/result")]
    public ActionResult RepeatCount()
    {
      RepeatCounter newUserWord = new RepeatCounter(Request.Form["newUserWord"], Request.Form["newUserWriting"]);
      return View(newUserWord);
    }
    [HttpGet("/form/result")]
      public ActionResult RepeatCount(RepeatCounter model)
      {
        return View(model);
      }
  }
}
