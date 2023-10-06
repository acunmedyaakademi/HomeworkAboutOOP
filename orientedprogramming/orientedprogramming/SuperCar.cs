using System;
using ConsoleApp1;

namespace orientedprogramming
{
    internal class SuperCar : Car  // car sınıfından kalıtım alan bir supercar sınıfı oluşturdum.
    {
       public SuperCar(string color, int maxSpeed, int modelYear, string modelName, int nosCount) : base(color, maxSpeed, modelYear, modelName)
       {
            Console.WriteLine(nosCount);  // car class da olmayan constractor değeri tanımlar 
        }
    }
    
}

