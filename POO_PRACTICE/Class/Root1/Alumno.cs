using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PRACTICE.Class.Root1
{
    public class Alumno : MiembroDeLaComunidad
    {
        public string IdEstudiante { get; set; }
        public List<int> Calificaciones { get; set; }
        public List<string> Materias { get; set; }

        public Alumno() { }
        public Alumno(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public override void Saludar()
        {
            Console.WriteLine(@$"Hola mi nombre es {Nombre} y soy un Alumno"); ;
        }
    }
}
