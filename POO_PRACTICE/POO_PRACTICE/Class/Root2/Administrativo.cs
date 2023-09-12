using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_PRACTICE.Class.Root1;

namespace POO_PRACTICE.Class.Root2
{
    internal class Administrativo : Empleado
    {
        public string NombreAgencia { get; set; }

        public Administrativo(string nombre) 
        {
            Nombre = nombre;
        }

        public override void Saludar()
        {
            Console.WriteLine($@"Saludos mi nombres es {Nombre} y soy un administrativo"); ;
        }
    }
}
