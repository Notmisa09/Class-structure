using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_PRACTICE.Class.Root1;

namespace POO_PRACTICE.Class.Root2
{
    public class Docente : Empleado
    {
        public int Id_docente { get; set; }
        public string Materias { get; set; }
        public Docente() { }
        public override void Saludar()
        {
            Console.WriteLine(@$"Hola mi nombre es {Nombre} y soy un Docente"); ;
        }
    }
}
