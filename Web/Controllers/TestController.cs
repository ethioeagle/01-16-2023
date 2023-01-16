using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class TestController : Controller
    {
        public ActionResult MyFirstViewMethod()
        {
            CustomerBAL1 b = new CustomerBAL1();
            Customer1 c = b.GetCustomer1();
            ViewBag.CustomerData = c;
            return View("FirstView");
        }
    }
}
