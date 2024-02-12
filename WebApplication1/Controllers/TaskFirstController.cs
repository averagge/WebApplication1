using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class TaskFirstController : Controller
    {
/*        public IActionResult TaskFirst()
        {
            return View();
        }*/
        public IActionResult TaskFirst()
        {
            Random rand = new Random();
            ViewBag.arr = new int[15];
            int sum = 0;
            int count = 0;
            for (int i = 0; i < 15; i++)
            {
                ViewBag.arr[i] = rand.Next(-10, 31);
                if (ViewBag.arr[i] > 0)
                {
                    sum += ViewBag.arr[i];
                    count++;
                }

            }
            ViewBag.avg = sum / count;
            return View();
        }
    }
}

