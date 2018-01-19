using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator
{
    class Ferrari
    {
        private string InfoAboutFerrari;

        public Ferrari(string InfoAboutFerrari)
        {
            this.InfoAboutFerrari = InfoAboutFerrari;
        }

        public string InfomationFerrari()
        {
            return InfoAboutFerrari + "\n Ferrari" + "\n it has \n 3 doors \n 1 engine \n 2 seats \n 2 headlights \n 2 backlights \n reverse camera \n and the price of this car is \n 1.750.000kr.";
        }


        public string FerraieDe
        {
            get { return InfoAboutFerrari; }
            set { InfoAboutFerrari = value; }
        }
    }

}

