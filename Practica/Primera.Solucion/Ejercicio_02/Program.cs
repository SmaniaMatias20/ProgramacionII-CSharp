internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio Nro 02";

        Console.Write("Ingresar un numero: ");
        float numeroIngresado = float.Parse(Console.ReadLine());

        while (numeroIngresado <= 0)
        {
            Console.Write("Error! Ingresar un numero mayor a 0 (cero): ");
            numeroIngresado = int.Parse(Console.ReadLine());
        }

        double cuadrado = Math.Pow(numeroIngresado, 2);
        double cubo = Math.Pow(numeroIngresado, 3);

        Console.WriteLine("El cuadrado del numero ingresado es: {0:#,###.00}", cuadrado);
        Console.WriteLine("El cubo del numero ingresado es: {0:#,###.00}", cubo);
    }
}