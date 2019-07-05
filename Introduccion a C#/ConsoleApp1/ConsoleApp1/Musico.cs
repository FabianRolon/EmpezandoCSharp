using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Musico
    {
        public string nombre;
        public string apellido;
        public int edad;
        public Orquesta orquesta;
        public Instrumento instrumento;

        public Musico()
        {
            this.nombre = "No tiene nombre";
            this.apellido = "no tiene apellido";
            this.edad = 0;
        }

        public Musico(string nombre, string apellido, int edad, Orquesta orquesta, Instrumento instrumento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.orquesta = orquesta;
            this.instrumento = instrumento;
        }

        public void imprimirMusico()
        {
            Console.WriteLine("Nombre del musico: {0}, Apellido del musico: {1}, Edad del musico: {2}, Nombre de Orquesta: {3}, Nombre Instrumento: {4}", this.nombre, this.apellido, this.edad.ToString(), this.orquesta.nombre, this.instrumento.nombre);
            Console.ReadLine();
        }
    }
}
