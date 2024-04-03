namespace StaticExercise
{
    
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
