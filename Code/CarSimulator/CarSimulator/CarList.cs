using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator
{
    class CarList
    {
        private string ListOfcars;

        public CarList (string ListOfCars)
        {
            this.ListOfcars = ListOfCars;
        }

        public string HereIsAllOfTheCars()
        {
            Console.WriteLine("You have to type the number that represent the car in order to see infomation about the car");
            return ListOfcars + "\n" + "5 Audi" + "\n" + "6 Ferrari" + "\n" + "7 Lamborghini";
        }


        public string CarsDe
        {
            get { return ListOfcars; }
            set { ListOfcars = value; }
        }

    }
}
