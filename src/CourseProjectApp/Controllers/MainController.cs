using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CourseProjectApp.Models.CSharp;
using static CourseProjectApp.Models.CSharp.CSharp6.Static6;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CourseProjectApp.Controllers
{
    public class MainController : Controller
    {
        // GET: /<controller>/
        // First Instance
        FirstClass _firstclass = new FirstClass();

        //Second Instance
        private readonly FirstClass _secondClass;

        private readonly AccessModifiers _accessModifier;
        public MainController(FirstClass secondClass, AccessModifiers accessModifier)
        {
            _secondClass = secondClass;
            _accessModifier = accessModifier;
        }

        public IActionResult Index()
        {
            //Static class method C#6

            FirstStaticMethod();

            ViewBag.value = "My First MVC Route";

            _firstclass.MainValue = "Main Value";
            //Third Instance
            string value = "First Value";
            FirstClass thirdClass = new FirstClass(value);

            //Methods
            _secondClass.NoReturn("Great Value");
            var boolValue =_secondClass.TrueFalse(6);


            // Accessors

                //Public

                _accessModifier.PublicString = "Value";
                _accessModifier.PublicMethod();

                //Private Not Allowed

                //_accessModifier.PrivateString;
                //_accessModifier.PrivateMethod();

                //Protected

                //_accessModifier.ProtectedMethod();


            return View();
        }
    }
}
