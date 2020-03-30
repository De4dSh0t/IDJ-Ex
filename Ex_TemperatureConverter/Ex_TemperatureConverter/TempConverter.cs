namespace Ex_TemperatureConverter
{
    public static class TempConverter
    {
        public static double ToFahrenheit(double celsius)
        {
            return celsius * 9/5 + 32;
        }

        public static double ToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5/9;
        }
    }
}