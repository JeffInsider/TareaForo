using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioEmpleado.modelos
{
    internal class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public int Edad { get; set; }

        public Empleado(string nombre, string apellido, int edad) {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
        }
    }
}
