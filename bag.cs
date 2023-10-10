namespace lecture_1_hw
{
    internal class Bag
    {
        
        public int PizzaPieces { get; set; }
        public int BeerBottles { get; set; }
        public double Capacity { get; set; }

        private const double PizzaCapacity = 0.3;
        private const double BeerCapacity = 0.5; 
        public bool AddPizza(int AddPizzaPieces, Bag bag)
        {
            if (PizzaCapacity * AddPizzaPieces + bag.PizzaPieces * PizzaCapacity + bag.BeerBottles * BeerCapacity <= bag.Capacity)
            {
                bag.PizzaPieces += AddPizzaPieces;
                return true;
            }
            return false;
        }

        public bool AddBeer(int AddBearBottles, Bag bag)
        {
            if (BeerCapacity * AddBearBottles + bag.PizzaPieces * PizzaCapacity + bag.BeerBottles * BeerCapacity <= bag.Capacity)
            {
                bag.BeerBottles += AddBearBottles;
                return true;
            }
            return false;
        }
    }

}
