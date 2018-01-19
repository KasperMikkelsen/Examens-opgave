using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator
{
    class Audi
    {

        private string InfoAboutAudi;

        public Audi (string InfoAboutAudi)
        {
            this.InfoAboutAudi = InfoAboutAudi;
        }

        public string InfomationAudi()
        {
            return InfoAboutAudi  + "\n Audi" + "\n it has \n 5 doors \n 1 engine \n 5 seats \n 2 headlights \n 2 backlights \n reverse camera \n and the price of this car is \n 750000kr.";
        }


        public string AudiDe
        {
            get { return InfoAboutAudi; }
            set { InfoAboutAudi = value; }
        }
    }        
    
}
