internal class Program
{
    private static void Main(string[] args)
    {
        int numeroEntero;
        int acumulador = 0; 
        int centroNumerico = 0; 
        Console.Write("Ingrese un numero entero: ");
        string datoIngresado = Console.ReadLine();

        while (!int.TryParse(datoIngresado, out numeroEntero)) {
            Console.Write("Error! Debe ingresar un numero entero: ");
            datoIngresado = Console.ReadLine();
        }

        numeroEntero = int.Parse(datoIngresado);


        for (double i = 1; i <= numeroEntero; i++)
        {
            for (int j = 1; j <= numeroEntero; j++)
            {
                acumulador += j; 
            }

            if (acumulador / i == i) { 
                centroNumerico = (int)i;
            }
            acumulador = 0;
        }

        if (centroNumerico != 0)
        {
            Console.WriteLine("El centro numerico del 1 al {0} es: {1}", numeroEntero, centroNumerico);
        }
        else 
        { 
            Console.WriteLine("No hay un centro numerico");
        }

    }
}