using Ejercicio_14;

public class Program
{
    public static void Main(string[] args)
    {
        double primerNumero = 0;
        double segundoNumero = 0;

        Console.Write("Ingrese el primer numero: ");
        while (!double.TryParse(Console.ReadLine(), out primerNumero)) 
        {
            Console.Write("Error! Ingrese un numero: ");
        }

        Console.Write("Ingrese el segundo numero: ");
        while (!double.TryParse(Console.ReadLine(), out segundoNumero))
        {
            Console.Write("Error! Ingrese un numero: ");
        }

        Console.Write("Ingrese el operador: ");
        /*Error aca: Si no ingreso nada tiene que funcionar igual*/
        string operador = Console.ReadLine();



        double resultado = Calculadora.Calcular(primerNumero, segundoNumero, operador);
        Console.WriteLine("El resultado de {0} {2} {1} es: {3}", primerNumero, segundoNumero, operador, resultado);
    }
}