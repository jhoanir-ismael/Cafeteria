using System;
using System.Collections.Generic;
using System.Text;

namespace Cafeteria
{
    public class Bebida_fria:Bebida
    {
        
        private int canthielo;

        public int CantidadHielo
        {
            get { return canthielo; }
            set { canthielo = value; }
        }

        // Constructor
        public Bebida_fria(string nombre, string tamaño, int canthielo, double precio)
            : base(nombre, tamaño, precio)
        {
            
            this.canthielo = canthielo;
        }

        //Overrride
        public override string Preparar()
        {
            return "Estamos preparando un: " + GetNombre() + " Helado, Con: " + canthielo + " cubos de hielo, de tamaño: " + GetTamaño();
        }
    }
}
