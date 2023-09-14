using POO_PRACTICE.Class.Root1;
using POO_PRACTICE.Class.Root2;
using POO_PRACTICE.Class.Root3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PRACTICE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Alumno alum1 = new Alumno("Russel Briant");
            alum1.Saludar();

            Maestro JuanPerez = new Maestro("Juan Perez");
            JuanPerez.Saludar();

            Administrador Nose = new Administrador("Edwind");
            Nose.Saludar();

            Console.ReadKey();
        }
    }
}
