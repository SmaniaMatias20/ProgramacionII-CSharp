using Ejercicio_11;

public class Program
{
    public static void Main(string[] args)
    {
        bool validacion = false;
        int numeroMaximo = 0;
        int numeroMinimo = 0;
        int acumulador = 0; 
        float promedio = 0;


        for (int i = 0; i < 10; i++)
        {
            Console.Write("Ingrese un numero entero: ");
            if (int.TryParse(Console.ReadLine(), out int numeroIngresado))
            {
                validacion = Validador.Validar(numeroIngresado, -100, 100);
                acumulador += numeroIngresado;
            }
            else
            {
                Console.WriteLine("Debe ingresar un numero entero");
                i--;
            }

            if (validacion) {
                Console.WriteLine("El {0} está dentro del rango", numeroIngresado);
            }

            if (i == 0)
            {
                numeroMaximo = numeroIngresado;
                numeroMinimo = numeroIngresado;
            }
            else if (numeroIngresado > numeroMaximo)
            {
                numeroMaximo = numeroIngresado;
            }
            else if (numeroIngresado < numeroMinimo) 
            {
                numeroMinimo = numeroIngresado;
            }
        }

        promedio = (float)acumulador / 10;

        Console.WriteLine("El {0} es el numero maximo y el {1} es el numero minimo", numeroMaximo, numeroMinimo);
        Console.WriteLine("El promedio es: {0}", promedio);
    }



}