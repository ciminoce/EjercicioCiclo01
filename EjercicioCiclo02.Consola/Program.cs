

using EjercicioCiclo02.Funciones;

namespace EjercicioCiclo02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tablas de Multiplicar");


            var nroIngresado = Utilidades.PedirEntero("Ingrese un número para generar su tabla de multiplicar:");
            for (int i = 1;i<=12;i++)
            {
                Console.WriteLine($"{i}*{nroIngresado}={i*nroIngresado}");
            }
            Console.ReadLine();
        }
    }
}