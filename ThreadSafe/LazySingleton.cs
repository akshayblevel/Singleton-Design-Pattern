using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafe
{
    public class LazySingleton
    {
        private LazySingleton()
        { }

        public static LazySingleton Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested
        {
            static Nested()
            { }

            internal static readonly LazySingleton instance = new LazySingleton();
        }

        public void SomeMethod()
        { }
    }
}
