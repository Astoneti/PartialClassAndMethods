using System;

namespace PartialClassAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon gun = new Weapon();
            gun.GetShoot();   // Таким образом, два файла в проекте содержит определение одного и того же частичного класса Weapon!
            gun.GetReload(); // И содержит два разных метода.Для этого они определяются с ключевым словом partial.

            gun.DoSomething(); // вызываем partial метод 2 в 1)))
            Console.ReadKey();   //мы не можем вызвать partial методы напрямую в программе вне классов, где они определены. Поэтому обычно они вызываются через другие доступные методы как в случае выше через метод DoSomething:
        }
    }
}
