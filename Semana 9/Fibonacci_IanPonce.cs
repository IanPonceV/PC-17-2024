using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 0;

        // Bucle para solicitar un número entero positivo
        while (n <= 0)
        {
            try
            {
                Console.Write("Ingrese un número entero mayor que 0: ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                {
                    Console.WriteLine("El número debe ser mayor que 0.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada no válida. Debe ingresar un número entero.");
            }
        }

        // Calcular la sucesión de Fibonacci
        int a = 0, b = 1, aux;
        Console.WriteLine("Sucesión de Fibonacci hasta el término {0}:", n);
        Console.WriteLine("{0}", a);
        Console.WriteLine("{0}", b);

        for (int i = 3; i <= n; i++)
        {
            aux = a + b;
            Console.WriteLine("{0}", aux);
            a = b;
            b = aux;
        }
    }
}