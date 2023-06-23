using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioEmpleado.modelos
{
    internal class EmpleadoComision : Empleado
    {
        public double SalarioBase { get; set; }
        public double Ventas { get; set; }
        public double Comision { get; set; }
        private double salario;
        public double Salario {
            get { return salario; }
            set { salario = (this.Ventas * this.Comision)+this.SalarioBase; }
        }

        public EmpleadoComision(string nombre, string apellido, int edad,
            double salBase, double ventas, double comision) : base(nombre, apellido, edad)
        {
            this.SalarioBase = salBase;
            this.Ventas = ventas;
            this.Comision = (comision/100);
            this.Salario = (ventas*comision)+salBase;
        }
    }
}
