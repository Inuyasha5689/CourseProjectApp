using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.Models.CSharp
{
    public class Variables
    {
        public Variables()
        {
            //Declared variables
            int i;
            double z;
            decimal d;
            bool f;
            string s;

            // Initialization of variables
            i = 100;
            z = 100.00;
            d = decimal.Parse(i.ToString());
            f = false;
            s = "First String";

            // Declare & Initialize
            string ss = "Second String";
            //var
            var r = 1;
        }
    }
}
