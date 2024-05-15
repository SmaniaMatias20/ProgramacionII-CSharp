internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio Nro 01";

        int numeroIngresado = 0;
        int numeroMayor = 0;
        int numeroMenor = 0;
        float promedio;
        int total = 0;


        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingresar un numero:");
            numeroIngresado = int.Parse(Console.ReadLine());
            total += numeroIngresado;

            if (i == 0)
            {
                numeroMayor = numeroIngresado;
                numeroMenor = numeroIngresado;
            }
            else
            {
                if (numeroIngresado > numeroMayor)
                {
                    numeroMayor = numeroIngresado;
                }
                if (numeroIngresado < numeroMenor)
                {
                    numeroMenor = numeroIngresado;
                }
            }
        }

        promedio = (float)total / 5;

        Console.WriteLine("El numero mayor es: {0}", numeroMayor);
        Console.WriteLine("El numero menor es: {0}", numeroMenor);
        Console.WriteLine("El promedio es: {0}", promedio);

        Console.ReadKey();
    }
}