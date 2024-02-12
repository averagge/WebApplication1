using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class TaskThirdController : Controller
    {
        public IActionResult TaskThird()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TaskThird(string word) 
        {
            if (word.Length > 0 && word[0] == word[word.Length - 1])
            {
                ViewBag.mes = "Первая и последняя буквы совпадают";
            }
            else { ViewBag.mes = "Первая и последняя буквы не совпадают"; }  
            return View();
        }
    }
}
