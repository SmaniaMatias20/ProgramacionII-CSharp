using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        int numeroIngresado;
        string tabla;

        Console.Write("Ingrese un numero entero: ");

        while (!int.TryParse(Console.ReadLine(), out numeroIngresado)) 
        { 
            Console.Write("Error! Ingrese un numero entero: "); 
        }

        tabla = GenerarTabla(numeroIngresado);
        Console.Write(tabla);

    }

    public static string GenerarTabla(int numeroIngresado)
    {
        StringBuilder stringBuilder = new StringBuilder("Tabla de multiplicar del numero " + numeroIngresado + " es: \n");
        int resultado = 0;

        for (int i = 1; i <= 10; i++) 
        {
            resultado = numeroIngresado * i;
            stringBuilder.Append(numeroIngresado.ToString() + " x " + i.ToString()+ " = " + resultado.ToString() + "\n");

        }

        return stringBuilder.ToString();
    }
}