using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PRACTICE.Class.Root1
{
    public class Ex_alumno : MiembroDeLaComunidad
    {
        public List<int> Calificaciones { get; set; }
        public List<string> Materias { get; set; }
        public int IdEstudiante { get; set; }

        public Ex_alumno() { }

        public override void Saludar()
        {
            Console.WriteLine(@$"Hola mi nombre es {Nombre} y soy un exalumno"); ;
        }
    }
}
