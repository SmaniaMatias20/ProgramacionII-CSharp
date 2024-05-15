using Ejercicio_12;

internal class Program
{
    public static void Main(string[] args)
    {
        bool respuesta = true;
        string respuestaIngresada;
        int resultado = 0;



        Console.WriteLine("Programa que suma numeros enteros");
        while (respuesta)
        {

            Console.Write("Ingrese un numero entero: ");
            if (int.TryParse(Console.ReadLine(), out int numeroIngresado))
            {
                resultado += numeroIngresado;
                Console.WriteLine("El resultado parcial es: {0}", resultado);
            }

            Console.Write("¿Desea continuar? S/N: ");
            respuestaIngresada = Console.ReadLine();

            if (respuestaIngresada != null)
            {
                respuesta = Validador.ValidarRespuesta(respuestaIngresada);
            }
            else 
            { 
                respuesta = false;
            }
            
        }
        Console.WriteLine("El resultado final es: {0}", resultado);
    }


}