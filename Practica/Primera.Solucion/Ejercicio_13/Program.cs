using Ejercicio_13;

internal class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("-------Convertir de Decimal a Binario--------\n");
        Console.Write("Ingrese un numero: ");
        if (int.TryParse(Console.ReadLine(), out int numeroDecimal))
        {
            string resultadoBinario = Conversor.ConvertirDecimalABinario(numeroDecimal);
            Console.Write("El numero en Binario es: {0}\n", resultadoBinario);
        }
        else
        {
            Console.WriteLine("Error! Debe ingresar un numero\n");
        }

        Console.WriteLine("\n-------Convertir de Binario a Decimal--------\n");
        Console.Write("Ingrese un numero: ");
        if (int.TryParse(Console.ReadLine(), out int numeroBinario))
        {
            int resultadoDecimal = Conversor.ConvertirBinarioADecimal(numeroBinario);
            Console.Write("El numero en Decimal es: {0}", resultadoDecimal);
        }
        else
        {
            Console.WriteLine("Error! Debe ingresar un numero");
        }

    }
}