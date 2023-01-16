using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class studentController : Controller
    {
        //public string GetByID()
        //{
        //    return "MY Best student";
        //}

        //public ActionResult firstviewmethod()
        //{
        //    return View("Myaction");
        //}

        public ActionResult firstviewmethod()
        {
            string studentname = "Soleyana Fante";
            ViewBag.studentdata = studentname;
            return View("Myaction");

        }
    }
}
