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
            return ListOfOptions + "\n" + "type 1 to do something"  + "\n" + "Type 2 to do something" + "\n" + "Type 3 to do something";
        }

       

        public string OptionDe
        {
            get { return ListOfOptions; }
            set { ListOfOptions = value; }
        }

    }
}
