using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClassAndMethods
{
    public partial class Weapon
    {
        public void GetReload() 
        {
            Console.WriteLine("Gun is reloading after shoot!");
        }
        partial void DoSomethingElse()
        {
            Console.WriteLine("Release the bullet from the barrel ");
        }

    }
}
