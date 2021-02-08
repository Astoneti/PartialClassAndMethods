using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PartialClassAndMethods
{
    public partial class Weapon 
    {
        public void GetShoot() 
        {
            Console.WriteLine("Gun is shooting - boom,boom!");
        }
        partial void DoSomethingElse(); // Частичные методы всегда void и только Private!
                                        //И также они не могут иметь out-параметров.
        public void DoSomething()
        {
            Console.WriteLine("Start shooting");
            DoSomethingElse();
            Console.WriteLine("Finish shooting");
        }
    }
}
