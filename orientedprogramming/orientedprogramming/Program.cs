using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using orientedprogramming;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car corolla = new Car("kırmızı" , 600 ,2023, "corolla");  // car sınıfında corolla adında bir nesne ürettim ve özelliklerini ekledim
            Car mercedes = new Car("siyah" ,600, 2022, "mercedes");    // car sınıfında mercedes adında bir nesne ürettim ve özelliklerini ekledim


            Console.WriteLine(corolla.Color);
            Console.WriteLine(corolla.MaxSpeed);  
            Console.WriteLine(corolla.Year);


            Console.WriteLine(mercedes.Color);
            Console.WriteLine(mercedes.MaxSpeed);
            Console.WriteLine(corolla.Year);

            corolla.CurrentSpeed = 180;  // corolla nesnesinin sabit hızını belirttim 
            mercedes.CurrentSpeed = 280;  // mercedes nesnesinin sabit hızını belirttim 

            corolla.isSpeedLimit();
            mercedes.isSpeedLimit();

            corolla.MaxSpeed = 750;    // corolla nesnesinin max hızını belirttim 
            mercedes.MaxSpeed = 900;   // mercedes nesnesinin sabit hızını belirttim 

            corolla.VehicleIdentificationNumber = "864563298011033";   // corolla nesnesinin saşe numarasını belirttim
            mercedes.VehicleIdentificationNumber = "7855434";          // mercedes nesnesinin saşe numarasını belirttim

            Console.WriteLine(corolla.VehicleIdentificationNumber);
            Console.WriteLine(mercedes.VehicleIdentificationNumber);

            SuperCar superCar = new SuperCar("kırmızı", 900, 2023, "Bugatti", 555);   //supercar sınıfında bugatti adında bir nesne ürettim ve özelliklerini ekledim
            Console.WriteLine(superCar.MaxSpeed);


            Console.ReadLine();
        } 
    }
}