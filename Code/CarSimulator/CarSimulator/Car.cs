﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator
{
    class Car
    {

        private string ShopName;


        public Car(string ShopName)
        {
            this.ShopName = ShopName;
        }



        public string Welcome()
        {
            return "Hello and Welcome to " + ShopName + " Here is the list of options you can choose \n each option has a number \n type it to use that option";
            
        }

        public string ShopDe
        {
            get { return ShopName; }
            set { ShopName = value; }
        }

    }
}
