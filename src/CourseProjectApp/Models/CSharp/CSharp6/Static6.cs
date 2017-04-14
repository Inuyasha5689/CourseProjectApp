using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace CourseProjectApp.Models.CSharp.CSharp6
{
    public class Static6
    {
        public static void FirstStaticMethod()
        {
            // C# 5 & below Statics

            //Console.WriteLine("Text");

            // C# 6 Statics
            WriteLine("Text");

            //String Interpolation!!!!
            string first = "My First";
            string second = "My Second";
            //C#5 and below String Placeholders
            WriteLine("{0} is my first value. {1} is my second value", first, second);


            //C#6 String Interpolation

            WriteLine($"{first} is my first value. {second} is my second value");
        }
    }
}
