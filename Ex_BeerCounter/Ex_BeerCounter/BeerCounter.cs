namespace Ex_BeerCounter
{
    public static class BeerCounter
    {
        private static int beerInStock;
        private static int beersDrankCount;

        public static void BeerInStock(int bottlesCount)
        {
            beerInStock += bottlesCount;
        }

        public static void DrinkBeer(int bottlesCount)
        {
            beersDrankCount -= bottlesCount;
        }
    }
}