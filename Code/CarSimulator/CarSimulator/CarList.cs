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
            return ListOfcars + "\n" + "Audi" + "\n" + "Ferrari" + "\n" + "Lamborghini";
        }


        public string CarsDe
        {
            get { return ListOfcars; }
            set { ListOfcars = value; }
        }

    }
}
