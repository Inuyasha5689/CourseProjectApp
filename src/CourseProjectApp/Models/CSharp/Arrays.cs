using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.Models.CSharp
{
    public class Arrays
    {
        // Declare Array

        string[] firstArray;

        // Declare and Initialize Array
        string[] secondArray = new string[2];

        // Declare and Initialize Array Inline
        private string[] thirdArray = {"FirstElement", "SecondElement","ThirdElement"};

        public void ArrayMethod()
        {
            secondArray[0] = "first";
            secondArray[1] = "second";

            foreach (var myElement in thirdArray)
            {
                Console.WriteLine(myElement);
            }
        }

    }
}
