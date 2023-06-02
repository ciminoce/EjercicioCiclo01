using EjercicioCiclo02.Funciones;

namespace EjercicioCiclo03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar números a morir!!!");
            int cantidadNumeros = 0;
            int suma = 0;
            while (suma<=60) {
                int nroIngresado = Utilidades.PedirEntero("Ingrese un número entero:");
                cantidadNumeros++;
                suma += nroIngresado;
            }
            Console.WriteLine($"Se ingresaron {cantidadNumeros}");
            Console.WriteLine($"La suma final fue {suma}");
        }
    }
}