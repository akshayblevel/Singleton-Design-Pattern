using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotThreadSafe
{
    public class Singleton
    {
        private static Singleton _instance;

        public Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        public void SomeMethod()
        {
        }
    }
}
