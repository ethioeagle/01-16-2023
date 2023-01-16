using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class TestController : Controller
    {
        //public string MyFirstMethod()
        //{
        //    return "Welcome to David!!";
        //}

        //public string mybest()
        //{
        //    return "Soleyana is the best";
        //}

        //public ActionResult MyFirstViewMethod()
        //{
        //    return View("MyFirstView");
        //}

        //public ActionResult MyFirstViewMethod()
        //{
        //    string CustomerName = "Mr.Dave";
        //    ViewData["CustomerData"] = CustomerName;
        //    return View("MyFirstView");
        //}

        public ActionResult MyFirstViewMethod()
        {
            CustomerBAL b = new CustomerBAL();
            Customer c = b.GetCustomer();
            ViewBag.CustomerData = c;
            return View("MyFirstView");
        }
    }
}
