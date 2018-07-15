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
      RepeatCounter newUserWriting = new RepeatCounter(Request.Form["user-writing"]);
      RepeatCounter newUserWord = new RepeatCounter(Request.Form["user-word"]);
      return View(model);
    }
  }
}
