using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_HW04_Brizhak_01
{
   public class Singleton
    {
        private static Singleton inst;
        private static object objLock = new Object();

        private Singleton() { }
        public static Singleton Inst
        {
            get
            {
                if (inst == null)
                {
                    lock (objLock)
                    {
                        if (inst == null)
                            inst = new Singleton();
                    }
                }
                return inst;
            }
        }
    }
}
