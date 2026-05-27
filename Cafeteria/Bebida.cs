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

        public Bebida(string nombre, string tamaño, double precio)
        {
            this.nombre = nombre;
            this.tamaño = tamaño;
            this.precio = precio;
        }

        // Métodos Get tradicionales que ya usábamos
        public string GetNombre() { return nombre; }
        public string GetTamaño() { return tamaño; }
        public double GetPrecio() { return precio; }

        
        public virtual string Preparar()
        {
            return "Preparando bebida:  ";
        }
    }
}
