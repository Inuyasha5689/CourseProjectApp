using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CourseProjectApp.Models.CSharp;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CourseProjectApp.Controllers
{
    public class MainController : Controller
    {
        // GET: /<controller>/
        // First Instance
        FirstClass firstclass = new FirstClass();

        //Second Instance
        private readonly FirstClass _secondClass;
        public MainController(FirstClass secondClass)
        {
            _secondClass = secondClass;
        }

        public IActionResult Index()
        {
            ViewBag.value = "My First MVC Route";

            //Third Instance
            string value = "First Value";
            FirstClass thirdClass = new FirstClass(value);

            return View();
        }
    }
}
