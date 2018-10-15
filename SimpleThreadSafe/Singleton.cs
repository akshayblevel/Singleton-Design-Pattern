using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleThreadSafe
{
    public sealed class Singleton
    {
        private static volatile Singleton instance;
        private static object syncRoot = new Object();

        private Singleton() 
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }

                return instance;
            }
        }
    }

}
