using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator
{
   public class Vehicle
    {
        public int engine;
        public int wheels;
        public int windows;
        public int doors;
        


        public void Audi()
        {
            wheels = 4;
            doors = 4;
            engine = 1;
            windows = 5;

            Console.WriteLine(wheels + doors + engine + windows);
        }
    }
}
