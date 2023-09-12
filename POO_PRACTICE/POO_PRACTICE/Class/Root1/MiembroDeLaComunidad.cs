using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POO_PRACTICE.Class.Root1
{
    public abstract class MiembroDeLaComunidad
    {
        public string Nombre { set; get; }
        public string Apellido { get; set; }
        public int edad { get; set; }

        public virtual void Saludar()
        {
            Console.WriteLine(@$"Saludos, el nombre de nuestra comunidad es {Nombre}");
        }

    }
}
