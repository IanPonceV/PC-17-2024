using System;

class Laboratoriopc_02_b
{
    static void Main(string[] args)
    {
        // Arreglos para almacenar las denominaciones de billetes y monedas
        int[] billetes = { 100, 50, 20, 10, 5 };
        int[] monedas = { 1, 25, 1 };

        // Pedir al usuario que ingrese la cantidad en quetzales
        Console.WriteLine("Ingrese la cantidad en quetzales (entre 0 y 999.99): ");
        double cantidad = double.Parse(Console.ReadLine());

        // Validar la cantidad ingresada
        if (cantidad < 0 || cantidad > 999.99)
        {
            Console.WriteLine("Cantidad inválida. Debe estar entre 0 y 999.99");
            return;
        }

        // Convertir la cantidad a entero para trabajar con las monedas
        int cantidadEntera = (int)Math.Truncate(cantidad * 100);

        // Descomponer la cantidad en billetes y monedas
        int[] cantidadBilletes = new int[billetes.Length];
        int[] cantidadMonedas = new int[monedas.Length];

        for (int i = 0; i < billetes.Length; i++)
        {
            cantidadBilletes[i] = cantidadEntera / billetes[i];
            cantidadEntera %= billetes[i];
        }

        for (int i = 0; i < monedas.Length; i++)
        {
            cantidadMonedas[i] = cantidadEntera / monedas[i];
            cantidadEntera %= monedas[i];
        }

        // Mostrar los resultados
        Console.WriteLine("\nEquivalencia en billetes y monedas:");
        for (int i = 0; i < billetes.Length; i++)
        {
            if (cantidadBilletes[i] > 0)
            {
                Console.WriteLine("{0} billetes de Q{1}", cantidadBilletes[i], billetes[i]);
            }
        }

        for (int i = 0; i < monedas.Length; i++)
        {
            if (cantidadMonedas[i] > 0)
            {
                if (monedas[i] == 1)
                {
                    Console.WriteLine("{0} moneda de Q{1}", cantidadMonedas[i], monedas[i]);
                }
                else
                {
                    Console.WriteLine("{0} monedas de Q{1}", cantidadMonedas[i], monedas[i] / 100);
                }
            }
        }

        // Mostrar la cantidad en centavos
        Console.WriteLine("\nCantidad en centavos: {0}", cantidadEntera);
    }
}