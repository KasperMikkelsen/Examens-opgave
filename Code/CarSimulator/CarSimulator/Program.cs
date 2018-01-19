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
            Audi audi;
            Lamborghini lamborghini;

   

            car = new Car("Car Simulator");
            option = new Option("Option list");
            carList = new CarList("This is all the cars we have available");
            audi = new Audi("Here is all the info about the car audi");
            lamborghini = new Lamborghini("Here is all the info about the car Lamborghini");


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
                    
                    
                }

                else if (answar == 3)
                {
                    Console.WriteLine("this works");
                }
                else if (answar > 100)
                {
                    Console.WriteLine("This is the end");
                    firstloop = false;

                }
                else if (answar == 5)
                {
                    Console.WriteLine(audi.InfomationAudi());
                }
                else if (answar == 6)
                {
                    Console.WriteLine(lamborghini.Infomationlamborghini());
                }
                else if (answar == 7)
                {
                    Console.WriteLine();
                }


            }
            
            

            



            Console.ReadKey();
            
        }

        
    }
}
