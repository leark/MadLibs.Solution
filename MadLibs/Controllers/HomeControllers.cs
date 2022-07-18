using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Madlib()
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.Noun = "Noun";
      myMadLibVariable.Adjective = "Adjective";
      myMadLibVariable.Adverb = "Adverb";
      return View(myMadLibVariable);
    }

    [Route("/madlib")]
    public ActionResult Madlib(string noun1, string adjective1, string adverb1)
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.Noun = noun1;
      myMadLibVariable.Adjective = adjective1;
      myMadLibVariable.Adverb = adverb1;
      return View(myMadLibVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }
  }
}