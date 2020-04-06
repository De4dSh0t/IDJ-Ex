namespace Ex_PlanckConstant
{
    public class Calculation
    {
        private static double plackConstant = 6.62606896e-34;
        private static double pi = 3.14159;

        public static double ReducedPlanck()
        {
            return plackConstant / (2 * pi);
        }
    }
}