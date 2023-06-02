namespace EjercicioCiclo01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sumar Números");
            int suma = 0;
            int contador = 0;
            do
            {
                var numeroIngresado = PedirEntero($"Ingrese el {contador + 1}º número:");
                suma += numeroIngresado;
                contador++;
            } while (contador<5);
            Console.WriteLine($"La suma de los 5 números es {suma}");
        }
        private static int PedirEntero(string mensaje)
        {
            
            int numeroIngresado;
            do
            {
                Console.Write(mensaje);
                var numero = Console.ReadLine();
                if (int.TryParse(numero, out numeroIngresado))
                {
                    break;
                }
                
                Console.WriteLine("Número mal ingresado... reintentar!!!");
               

            } while (true);
            return numeroIngresado;
        }
    }
}