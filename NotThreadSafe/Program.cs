using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotThreadSafe
{
    class Program
    {
        static void Main(string[] args)
        {
           //Call Singleton's Method
            Singleton.Instance.SomeMethod();

            //Assign to another variable
            var obj = Singleton.Instance;
            obj.SomeMethod();

            //Pass as parameter
            SomeOtherMethod(Singleton.Instance);


        }

        private static void SomeOtherMethod(Singleton singleton)
        {
            singleton.SomeMethod();
        }
    }
}
