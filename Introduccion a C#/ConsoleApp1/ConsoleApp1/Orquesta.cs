using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Orquesta
    {
        public string nombre;
        public string lugar;
        public string tipoOrquesta;

        public Orquesta()
        {
            this.nombre = "no tiene nombre";
            this.lugar = "no tiene lugar asignado";
            this.tipoOrquesta = "no tiene cargado ningun tipo";
        }

        public Orquesta(string nombre, string lugar, string tipoOrquesta)
        {
            this.nombre = nombre;
            this.lugar = lugar;
            this.tipoOrquesta = tipoOrquesta;
        }

        public void ImprimirOrquesta()
        {
            Console.WriteLine("Nombre {0}, lugar {1}, Tipo {2}", this.nombre, this.lugar, this.tipoOrquesta);
            Console.ReadLine();
        }
    }
}
