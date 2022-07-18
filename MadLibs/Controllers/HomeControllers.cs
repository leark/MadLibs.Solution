using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Homepage()
    {
      // MadLibVariable myMadLibVariable = new MadLibVariable();
      // myMadLibVariable.Noun1 = "Noun";
      // myMadLibVariable.Adjective1 = "Adjective";
      // myMadLibVariable.Adverb1 = "Adverb";
      // return View(myMadLibVariable);
      return View();
    }

    [Route("/madlib")]
    public ActionResult Madlib(string noun1, string adjective1, string adverb1, string noun2, string adjective2, string adverb2, int number1)
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.Noun1 = noun1;
      myMadLibVariable.Adjective1 = adjective1;
      myMadLibVariable.Adverb1 = adverb1;
      myMadLibVariable.Noun2 = noun2;
      myMadLibVariable.Adjective2 = adjective2;
      myMadLibVariable.Adverb2 = adverb2;
      myMadLibVariable.Number1 = number1;

      return View(myMadLibVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/form2")]
    public ActionResult Form2() { return View(); }

    [Route("/madlib2")]
    public ActionResult Madlib2(string noun1, string adjective1, string adverb1, string noun2, string adjective2, string adverb2, int number1)
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.Noun1 = noun1;
      myMadLibVariable.Adjective1 = adjective1;
      myMadLibVariable.Adverb1 = adverb1;
      myMadLibVariable.Noun2 = noun2;
      myMadLibVariable.Adjective2 = adjective2;
      myMadLibVariable.Adverb2 = adverb2;
      myMadLibVariable.Number1 = number1;

      return View(myMadLibVariable);
    }
  }
}