using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator
{
    class Program
    {
        public static int answar;

        static void Main(string[] args)
        {
            Car car;
            Option option;
            
        

   

            car = new Car("Car Simulator");
            option = new Option("Option list");

            Console.WriteLine(car.Welcome());
            Console.WriteLine(option.HereIsOptionsList());


            bool firstloop = true;
            
            while(firstloop)
            {
                try
                {
                    answar = int.Parse(Console.ReadLine().ToLower().Trim());
                }
                catch
                {

                }
                if (answar == 1)
                {
                    Console.WriteLine("this works");
                } 
                else if (answar == 2)
                {
                    Console.WriteLine("this works");
                }
                else if (answar == 3)
                {
                    Console.WriteLine("this works");
                }
                else if (answar == 123)
                {
                    firstloop = false;
                }
            }

            Console.ReadKey();
        }
    }
}
