using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace CourseProjectApp.Models.CSharp.CSharp6
{
    public class Static6
    {
        //Auto-Property Initializers
        //C#5 & Below
        //public string MyString { get; set; }

        //public int MyInt { get; set; }

        //public Static6()
        //{
        //    MyString = "My Value";
        //    MyInt = 6;
        //}

        //C#6 Auto-Property Initializers

        public string MyString { get; } = "My Value";

        public int MyInt { get; set; } = 6;

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

            //Null Conditional Operator and & Null Propagation

            string valuenull = "Has a value";

            // C#5 and below
            WriteLine(valuenull != null ? valuenull : "It is null");

            //C#6

            WriteLine(valuenull?.ToString() ?? "It is null");
        }
    }
}
