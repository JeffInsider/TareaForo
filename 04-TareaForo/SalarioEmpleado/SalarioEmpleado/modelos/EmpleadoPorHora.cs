using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioEmpleado.modelos
{
    internal class EmpleadoPorHora : Empleado //heredar
    {
        public double ValorHora { get; set; }
        public double HorasTrabajadas { get; set; }

        private double salario;
        public double Salario 
        {
            get { return salario; }
            set { salario = this.HorasTrabajadas * this.ValorHora; }
        }

        public EmpleadoPorHora(string nombre, string apellido, 
            int edad, double valorHora, double horasTrabajadas) : base(nombre, apellido, edad)
        {
            this.ValorHora = valorHora;
            this.HorasTrabajadas = horasTrabajadas;
            this.Salario = valorHora * horasTrabajadas;
        }
        
    }
}
