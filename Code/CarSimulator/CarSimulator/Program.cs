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
            CarList carList;
        

   

            car = new Car("Car Simulator");
            option = new Option("Option list");
            carList = new CarList("This is all the cars we have available");


            Console.WriteLine(car.Welcome());
            Console.WriteLine(option.HereIsOptionsList());
            

            bool firstloop = true;
        



            while (firstloop)
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
                    Console.WriteLine(carList.HereIsAllOfTheCars());


                }
                else if (answar == 2)
                {
                    Console.WriteLine(carList.HereIsAllOfTheCars());
                    firstloop = false;
                    
                }

                else if (answar == 3)
                {
                    Console.WriteLine("this works");
                }
                else if (answar > 4)
                {
                    Console.WriteLine("This is the end");
                    firstloop = false;

                }

            }
            
            Console.WriteLine("\n" + "Choose one of the cars to see all the detailes about the car");
            Console.WriteLine(carList.HereIsAllOfTheCars());

            



            Console.ReadKey();
            
        }
    }
}
