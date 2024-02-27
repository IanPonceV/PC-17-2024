namespace Laboratoriopc_01
{
    class Laboratoriopc_01
    {
        static void Main(string[] args) 
        {
            string nombre;
            string edad;
            string carnet;
            string carrera;

            Console.WriteLine("Ingrese su nombre");
            nombre=Console.ReadLine();

            Console.WriteLine("Ingrese su edad");
            edad=Console.ReadLine();

            Console.WriteLine("Ingrese su carnet");
            carnet=Console.ReadLine();

            Console.WriteLine("Ingrese su carrera");
            carrera=Console.ReadLine();

            Console.WriteLine("Soy"+nombre+"tengo"+edad+"estudio la carrera de"+carrera+"mi carnet es"+carnet);
            Console.ReadKey();
        

        }
    }
 
}
