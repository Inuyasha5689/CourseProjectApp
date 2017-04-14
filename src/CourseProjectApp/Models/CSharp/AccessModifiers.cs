using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.Models.CSharp
{
    public class AccessModifiers
    {
        //Public Modifier

        public string PublicString { get; set; }

        public void PublicMethod()
        {

        }

        // Private Modifier

        string PrivateString1 { get; set; }

        private string PrivateString { get; set; }

        private void PrivateMethod()
        {

        }

        // Protected Modifier

        protected int Number { get; set; }

        protected void ProtectedMethod()
        {

        }
    }

    public class Access: AccessModifiers
    {
        public Access()
        {
            Number = 15;
            ProtectedMethod();
        }
    }
}
