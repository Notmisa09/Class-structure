using POO_PRACTICE.Class.Root2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PRACTICE.Class.Root3
{
    public class Administrador : Docente
    {
        public Administrador(string nombre) 
        {
            Nombre = nombre;
        }

        public override void Saludar()
        {
            Console.WriteLine(@$"Saludos mi nombre es {Nombre} y soy un Administrador"); 
        }
    }
}
