namespace EjercicioCiclo02.Funciones;

public static class Utilidades
{
    public static int PedirEntero(string mensaje)
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