using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShop
{
    class Bunny : Animal
    {
        public string Color { get; set; }
        public string Race { get; set; }
        public bool Adult { get; set; }
        public override void PrintInfo()
        {
            base.PrintInfo();

            if (Adult == true)
            {
                Console.WriteLine($"Color: {Color}\nRace: {Race}\nAdult: Yes");
            }
            else
            {
                Console.WriteLine($"Color: {Color}\nRace: {Race}\nAdult: No");
            }
        }
    }
}
