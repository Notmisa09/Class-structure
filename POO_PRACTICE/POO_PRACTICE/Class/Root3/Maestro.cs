using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_PRACTICE.Class.Root2;

namespace POO_PRACTICE.Class.Root3
{
    public class Maestro : Docente
    {
        public Maestro(string nombre)
        {
            Nombre = nombre;
        }
        public override void Saludar()
        {
            Console.WriteLine(@$"Saludos mi nommbre es {Nombre} y soy un Mestro"); ;
        }
    }
}
