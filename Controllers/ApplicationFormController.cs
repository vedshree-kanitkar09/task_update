using ApplicationForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationForm.Controllers
{
    public class ApplicationFormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult PersonalInfo()
        {
            return View();
        }
       public IActionResult Success()
        {
            return View();
        }


    }
}

