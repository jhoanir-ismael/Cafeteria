using System;
using System.Collections.Generic;
using System.Text;

namespace Cafeteria
{
    public class Bebida
    {
        private string nombre;
        private string tamaño;
        private double precio;

        //creamos nuestro constructor
        public Bebida(string nombre, string tamaño, double precio)
        {
            this.nombre = nombre;
            this.tamaño = tamaño;
            this.precio = precio;
        }

        public void Preparar()
        {
            Console.WriteLine("Se esta preparando un " + nombre + "  de tamaño " + tamaño);
        }

        public void AplicarDescuento(double porcentaje)
        {

            double descuento = precio * (porcentaje / 100);
            precio = precio - descuento;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Esto es un " + nombre + " de tamaño " + tamaño + " con un costo de " + precio + "\n");
        }
    }
}
