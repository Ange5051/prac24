using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Avto car1 = new Avto();
            car1.PrintInfo();

            car1.Brand = "Toyota LandCruser 400";
            car1.Color = "Черный";
            car1.Skor = 100;
            car1.PrintInfo();

      
            Console.ReadKey();

        }
    }
}
