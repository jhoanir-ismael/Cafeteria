namespace Cafeteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estructura de Almacenamiento
            List<Bebida> pedido = new List<Bebida>();

            //5 bebidas
            pedido.Add(new Bebida_Hot("Café Americano", "Grande", 90, 45));
            pedido.Add(new Bebida_fria("Frappé de Capuchino", "Mediano", 5, 60));
            pedido.Add(new Bebida_Hot("Té de Manzanilla", "Chico", 75, 30));
            pedido.Add(new Bebida_fria("Té Helado", "Grande", 8, 40));
            pedido.Add(new Bebida_Hot("Cafe Vainilla", "Mediano", 89, 50));

            Console.WriteLine("=== TICKET DE BARRA ===\n");

            double costoTotal = 0; 

           
            foreach (Bebida b in pedido)
            {
                
                Console.WriteLine(b.Preparar());

                

                if (b is Bebida_Hot caliente)
                {
                    
                    if (caliente.Temperatura > 88)
                    {
                        Console.WriteLine("ADVERTENCIA: ¡Cuidado, bebida muy caliente!");
                    }
                }

                //Sumatoria de los prewcios
                costoTotal = costoTotal + b.GetPrecio();

                Console.WriteLine("\n");
            }

            //Mostramos el total
            Console.WriteLine("\nTotal a pagar: $" + costoTotal);

            Console.ReadLine();


        }
    }
}
