namespace Cafeteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bebida 1
            Console.Write("Escribe el nombre de la Bebida 1: ");
            string nombre1 = Console.ReadLine();

            Console.Write("Escribe el tamaño: ");
            string tamaño1 = Console.ReadLine();

            Console.Write("Escribe el precio: ");
            double precio1 = Convert.ToDouble(Console.ReadLine());

            Bebida bebida1 = new Bebida(nombre1, tamaño1, precio1);

            //Bebida 2
            Console.Write("Escribe el nombre de la Bebida 2: ");
            string nombre2 = Console.ReadLine();

            Console.Write("Escribe el tamaño: ");
            string tamaño2 = Console.ReadLine();

            Console.Write("Escribe el precio: ");
            double precio2 = Convert.ToDouble(Console.ReadLine());

            Bebida bebida2 = new Bebida(nombre2, tamaño2, precio2);

            //Bebida 3
            Console.Write("Escribe el nombre de la Bebida 3: ");
            string nombre3 = Console.ReadLine();

            Console.Write("Escribe el tamaño: ");
            string tamaño3 = Console.ReadLine();

            Console.Write("Escribe el precio: ");
            double precio3 = Convert.ToDouble(Console.ReadLine());

            Bebida bebida3 = new Bebida(nombre3, tamaño3, precio3);

            Console.WriteLine("\nAplicando un 15% de descuento a la Bebida 2 \n");
            bebida2.AplicarDescuento(15);

            Console.WriteLine("Resumen del Pedido\n");

            // bebida 1
            bebida1.Preparar();
            bebida1.MostrarDatos();

            //bebida 2
            bebida2.Preparar();
            bebida2.MostrarDatos();

            //bebida 3
            bebida3.Preparar();
            bebida3.MostrarDatos();
        }
    }
}
