using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_1_hw
{
    internal class ClassBag
    {
       public int PizzaPieces; //кол-во кусков пиццы
       public int BeerBottles; //кол-во бутылок пива
       public double Capacity; //максимальный объем рюкзака
       public double CapacityThisBag; // Объем рюкзака на данный момент
       public double CapacityPizzaPieces = 0.3; //объем куска пиццы
       public double CapacityBeerBottles = 0.5; //объем бутылки пива
       
      
       public ClassBag(int PizzaPieces, int BeerBottles, double Capacity) 
        { 
            this.PizzaPieces=PizzaPieces;
            this.BeerBottles=BeerBottles;
            this.Capacity=Capacity;
        }
        
       public double SumCapacity(int SomePieces,double CapacityPieces)
        {
            double Sum = SomePieces * CapacityPieces;
            return Sum;
        }

       public bool AddPizza(int AddPizzaPieces)
        {
            double CapacityCount = SumCapacity(AddPizzaPieces, this.CapacityPizzaPieces);
            if (CapacityCount <= this.CapacityThisBag)
            {
                Console.WriteLine($"У тебя уже все забито, сам посмотри! Состояние рюкзака = {this.CapacityThisBag}");
                return false;
            }
            else
            {
                Console.WriteLine($"У тебя еще влезет многа! Состояние рюкзака = {this.CapacityThisBag}");
                return true;
            }


          
        }
    }
}
