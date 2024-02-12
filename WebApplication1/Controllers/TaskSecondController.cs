using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class TaskSecondController : Controller
    {
        public IActionResult TaskSecond()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TaskSecond(string str) 
        {
            int countplus = 0;
            int count_= 0;
            for(int i = 0; i<str.Length;i++) 
            {
                if (str[i] =='+')
                {
                    countplus++;
                }
                if (str[i]=='_')
                {
                    count_++;
                }
            }
            ViewBag.countplus = countplus;
            ViewBag.count=count_;
            return View();        
        }
    }
}
