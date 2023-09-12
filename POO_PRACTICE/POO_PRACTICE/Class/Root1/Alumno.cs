using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PRACTICE.Class.Root1
{
    public class Alumno : MiembroDeLaComunidad
    {
        public string id_estudiante { get; set; }
        public List<int> Calificaciones { get; set; }
        public List<string> Materias { get; set; }

        public Alumno(string nombre)
        {
            Nombre = nombre;
        }

        public override void Saludar()
        {
            Console.WriteLine(@$"Hola mi nombre es {Nombre} y soy un Alumno"); ;
        }
    }
}
