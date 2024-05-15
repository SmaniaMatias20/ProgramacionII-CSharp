
internal class Program
{

    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio Nro 03";


        Console.Write("Ingresar un numero entero: ");

        string datoIngresado = Console.ReadLine();
        int numeroEntero;

        while (datoIngresado != "salir")
        {
            int contador = 0;

            while (!int.TryParse(datoIngresado, out numeroEntero))
            {
                Console.Write("Error! Debe ingresar un numero entero: ");
                datoIngresado = Console.ReadLine();
            }

            numeroEntero = int.Parse(datoIngresado);

            for (int i = 1; i <= numeroEntero; i++)
            {
                if (numeroEntero % i == 0)
                {
                    contador++;
                }
            }

            if (contador == 2)
            {
                Console.WriteLine("El {0} es Primo", numeroEntero);
            }
            else
            {
                Console.WriteLine("El {0} no es Primo", numeroEntero);
            }

            Console.Write("Ingresar un numero entero: ");
            datoIngresado = Console.ReadLine();




        }

        Console.WriteLine("Finalizo el programa");
    }
}