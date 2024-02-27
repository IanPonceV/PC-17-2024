using System;

class Laboratoriopc_02
{
    static void Main()
    {
        Console.WriteLine("Ingrese la velocidad inicial, aceleración y tiempo, o presione 'q' para salir.");
        Console.WriteLine("Ingrese la velocidad inicial (m/s):");
        string inputV0 = Console.ReadLine();
        double v0;
        if (inputV0.ToLower() == "q")
        {
            return;
        }
        else if (double.TryParse(inputV0, out v0))
        {
            Console.WriteLine("Ingrese la aceleración (m/s²):");
            string inputA = Console.ReadLine();
            double a;
            if (inputA.ToLower() == "q")
            {
                return;
            }
            else if (double.TryParse(inputA, out a))
            {
                Console.WriteLine("Ingrese el tiempo (s):");
                string inputT = Console.ReadLine();
                double t;
                if (inputT.ToLower() == "q")
                {
                    return;
                }
                else if (double.TryParse(inputT, out t))
                {
                    double vf = CalcularVelocidadFinal(v0, a, t);
                    Console.WriteLine($"La velocidad final es: {vf} m/s");
                }
                else
                {
                    Console.WriteLine("Error: Tiempo ingresado no es válido.");
                }
            }
            else
            {
                Console.WriteLine("Error: Aceleración ingresada no es válida.");
            }
        }
        else
        {
            Console.WriteLine("Error: Velocidad inicial ingresada no es válida.");
        }
    }

    static double CalcularVelocidadFinal(double v0, double a, double t)
    {
        double vf = v0 + a * t;
        return vf;
    }
}