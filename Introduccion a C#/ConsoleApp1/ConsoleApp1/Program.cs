using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
       static void Main(string[] args)
       {
            Orquesta orquesta1 = new Orquesta();
          //  orquesta1.ImprimirOrquesta();
            Orquesta orquesta2 = new Orquesta("Sinfonica de San Francisco", "San Francisco", "sinfonica");
          //  orquesta2.ImprimirOrquesta();

            Instrumento instrumento1 = new Instrumento();
         //   instrumento1.ImprimirInstrumento();
            Instrumento instrumento2 = new Instrumento("Guitarra", "Cuerda");
          //  instrumento2.ImprimirInstrumento();

            Musico musicoUno = new Musico("Mike", "Loco", 30, orquesta2, instrumento2);
            musicoUno.imprimirMusico();

            ArrayList listaOrquesta = new ArrayList();
            listaOrquesta.Add(orquesta1);
            listaOrquesta.Add(orquesta2);

            foreach(Orquesta elemento in listaOrquesta)
            {
                elemento.ImprimirOrquesta();
            }
        }
    }
}
