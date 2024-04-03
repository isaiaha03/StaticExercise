namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9/5) + 32;
            return fahrenheit;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = 90;
            double celsius = 10;
            Console.WriteLine(TempConverter.FahrenheitToCelsius(fahrenheit));
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(celsius));
        }
    }
}
