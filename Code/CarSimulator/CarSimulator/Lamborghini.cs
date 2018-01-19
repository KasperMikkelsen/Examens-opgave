using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator
{
    class Lamborghini
    {
        private string InfoAboutLamborghini;

        public Lamborghini(string InfoAboutLamborghini)
        {
            this.InfoAboutLamborghini = InfoAboutLamborghini;
        }

        public string Infomationlamborghini()
        {
            return InfoAboutLamborghini + "\n Lamborghini" + "\n it has \n 3 doors \n 1 engine \n 2 seats \n 2 headlights \n 2 backlights \n reverse camera \n and the price of this car is \n 2.500.000kr.";
        }


        public string AudiDe
        {
            get { return InfoAboutLamborghini; }
            set { InfoAboutLamborghini = value; }
        }
    }

}