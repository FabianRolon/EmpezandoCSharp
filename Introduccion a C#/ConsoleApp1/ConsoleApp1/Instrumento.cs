using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Instrumento
    {
        public string nombre;
        public string tipo;

        public Instrumento()
        {
            this.nombre = "no tiene nombre";
            this.tipo = "no tiene tipo asignado";
        }

        public Instrumento(string nombre, string tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
        }

        public void ImprimirInstrumento()
        {
            Console.WriteLine("Nombre {0}, tipo {1}", this.nombre, this.tipo);
            Console.ReadLine();
        }
    }

 
}
