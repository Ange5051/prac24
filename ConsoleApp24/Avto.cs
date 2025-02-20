using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Avto
    {
        
            private string brand;
        private string color;
        private int skor;

        public int Skor
        {
            get { return skor; }
            set
            {
                if (value < 20)
                    skor = 20;
                else if (value > 120)
                    skor = 120;
                else skor = value;
            }

        }
        public string Brand
        {
            get
            { return brand; }
            set
            { brand = value; }

        }

        public string Color { get; internal set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Марка: {brand}, Цвет: {color}, Скорость: {skor} км/ч");
        }
    }
}
