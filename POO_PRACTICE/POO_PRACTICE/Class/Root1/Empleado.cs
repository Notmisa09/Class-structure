using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PRACTICE.Class.Root1
{
    public abstract class Empleado : MiembroDeLaComunidad
    {
        public int Id_emp { get; set; }
        public string sueldo { get; set; }
        public int Cuenta { get; set; }
        public Empleado() { }
        public Empleado(string nombre)
        {
            Nombre = nombre;
        }
        public override void Saludar()
        {
            Console.WriteLine(@$"Hola mi Nombre es {Nombre} y soy un Empleado");
        }

    }
}
