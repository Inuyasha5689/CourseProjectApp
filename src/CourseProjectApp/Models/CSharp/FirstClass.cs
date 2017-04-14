using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.Models.CSharp
{
    public class FirstClass
    {
        public string Value;

        private string _value;
        //Properties

        public string MainValue {
            get {
                return _value;

            }
            set {
                _value = value;
            }
        }

        public FirstClass(string value)
        {
            Value = value;
        }

        public FirstClass()
        {

        }
    }
}
