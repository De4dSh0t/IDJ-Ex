using System.Runtime.Serialization;

namespace Ex_BasicMath
{
    public class MathUtil
    {
        public static float Sum(float n1, float n2)
        {
            return n1 + n2;
        }

        public static float Subtract(float n1, float n2)
        {
            return n1 - n2;
        }

        public static float Multiply(float n1, float n2)
        {
            return n1 * n2;
        }

        public static float Divide(float dividend, float divisor)
        {
            return dividend/ divisor;
        }

        public static float Percentage(float n, float percent)
        {
            return percent/100 * n;
        }
    }
}