using EjercicioCiclo02.Funciones;

namespace EjercicioCiclo50.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabla Conversiones de Temperaturas");
            int celsiusInicial = Utilidades.PedirEntero("Ingrese el valor inicial de temperatura:");
            int celsiusFinal = Utilidades.PedirEntero("Ingrese el valor final de temperatura:");
            if (celsiusInicial < celsiusFinal)
            {
                for (int tempCelsius = celsiusInicial;tempCelsius<= celsiusFinal;tempCelsius++)
                {
                    var fahrenheit = ConvertirCelsiusFahrenheit(tempCelsius);
                    Console.WriteLine($"{tempCelsius}-{fahrenheit}");
                }

            }
            else
            {
                for (int tempCelsius = celsiusInicial; tempCelsius >= celsiusFinal; tempCelsius--)
                {
                    var fahrenheit = ConvertirCelsiusFahrenheit(tempCelsius);
                    Console.WriteLine($"{tempCelsius}-{fahrenheit}");
                }

            }
            Console.WriteLine("Conversión finalizada");
            Console.ReadLine();
        }

        private static double ConvertirCelsiusFahrenheit(int celsius) => 1.8 * celsius + 32;
        
    }
}