using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero = 0;
        int acumulador = 0;
        int contadorNumerosPerfectos = 0;
        List<int> numerosPerfectos = new List<int>();


        while (true) {
            numero++;

            // Recorrer desde el 1 al numero
            for (int i = 1; i < numero; i++)
            {
                // Verificar los divisores
                if (numero%i == 0)
                {
                    acumulador += i;
                }
            }

            // Si numero es igual a acumulador (es perfecto), lo agrego a la lista.
            if (numero == acumulador)
            {
                numerosPerfectos.Add(numero);   
                contadorNumerosPerfectos++;
            }
            else if (contadorNumerosPerfectos == 4) {
                break;
            }

            acumulador = 0;
        }

        
        Console.WriteLine("Los primeros cuatro numeros perfectos son: {0}, {1}, {2}, {3}", numerosPerfectos[0], numerosPerfectos[1], numerosPerfectos[2], numerosPerfectos[3]);


    }
}