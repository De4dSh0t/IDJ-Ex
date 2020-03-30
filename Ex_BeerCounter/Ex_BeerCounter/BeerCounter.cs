namespace Ex_BeerCounter
{
    public static class BeerCounter
    {
        public static int beerInStock;
        public static int beersDrankCount;

        public static void BeerInStock(int bottlesCount)
        {
            beerInStock += bottlesCount;
        }

        public static void DrinkBeer(int bottlesCount)
        {
            beerInStock -= bottlesCount;
            beersDrankCount += bottlesCount;
        }
    }
}