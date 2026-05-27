using System;
using System.Collections.Generic;
using System.Text;

namespace Cafeteria
{
    public class Bebida_Hot:Bebida
    {
        private double temperatura;

        public double Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }

        public Bebida_Hot(string nombre, string tamaño, double temperatura, double precio)
            : base(nombre, tamaño, precio)
        {
            this.temperatura = temperatura;
        }

        public override string Preparar()
        {
            return "Estamos preparando un: " + GetNombre() + " caliente a: " + temperatura + " grados, de tamaño: " + GetTamaño();
        }
    }
}
