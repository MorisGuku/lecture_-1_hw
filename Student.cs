using lecture_1_hw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture__1_hw
{
    internal class Student
    {
        private const int CoefficientEatDrunk = 10;
        public string Name { get; set; }
        public int Age { get; set; }

        public string CountSatiety(Bag bag)
        {
            if (bag.PizzaPieces / (Age / CoefficientEatDrunk) < 1)
                return "Голоден";
            else if (bag.PizzaPieces / (Age / CoefficientEatDrunk) == 1)
                return "В самый раз";
            else 
                return "Переел";
        }

        public string CountDrunk(Bag bag)
        {
            if (bag.BeerBottles / (Age/ CoefficientEatDrunk) < 1)
            {
                return "Как стеклышко";
            }
            else if ((bag.BeerBottles / (Age / CoefficientEatDrunk)) == 1)
            {
                return "На веселе";
            }

            else
            {
                return "Домой на автопилоте";
            }
        
        }

    }
}
