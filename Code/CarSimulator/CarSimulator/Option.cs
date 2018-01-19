using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator
{
    class Option
    {
        private string ListOfOptions;

        public Option (string ListOfOptions)
        {
            this.ListOfOptions = ListOfOptions;
        }

        public string HereIsOptionsList()
        {
            return ListOfOptions + "\n" + "type 1 to see a list of all the cars"  + "\n" + "type 2 for help on how to se info about the cars" + "\n" + "Type 3 to do something";
        }

       

        public string OptionDe
        {
            get { return ListOfOptions; }
            set { ListOfOptions = value; }
        }

    }
}
