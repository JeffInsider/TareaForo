using SalarioEmpleado.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioEmpleado.app
{
    public class AppEmpleado
    {
        List<EmpleadoComision> empleadoComision = new List<EmpleadoComision>();
        List<EmpleadoPorHora> xhora = new List<EmpleadoPorHora>();


        public AppEmpleado()
        {
            empleadoComision.Add(new EmpleadoComision("Jeff", "Mejia", 21, 1000, 50000, 5));
            empleadoComision.Add(new EmpleadoComision("Mario", "Bros", 18, 4555, 10000, 4));
            empleadoComision.Add(new EmpleadoComision("Tiburcio", "Perez", 55, 2000, 40000, 2));

            xhora.Add(new EmpleadoPorHora("Roberto", "Calderon", 21, 200, 12));
            xhora.Add(new EmpleadoPorHora("Carlos", "Linterna", 45, 50, 24));
            xhora.Add(new EmpleadoPorHora("Jayme", "Alcachofa", 15, 500, 6));

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("Menu de opciones");
                Console.WriteLine("1. Agregar empleado");
                Console.WriteLine("2. Mostrar empleados");
                Console.WriteLine("3. Eliminar empleados");
                Console.WriteLine("4. Maximo sueldo");
                Console.WriteLine("5. Salir");

                Console.WriteLine("Ingrese la opcion: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        AgregarEmpleado();
                        break;
                    case 2:
                        MostrarEmpleados();
                        break;
                    case 3:
                        EliminarEmpleados();
                        break;
                    case 4:
                        MayorSueldo();
                        break;
                    case 5:
                        salir = true;
                        break;
                    
                    default:
                        Console.WriteLine("Opcion no valida. ");
                        break;
                }
            }
            


        }
        private void MayorSueldo()
        {
            MostrarEmpleados();

            double salarioMaximo = 0;
            Empleado empleadoSalarioMaximo = null;

            
            foreach (var empleado in empleadoComision)
            {
                double salario = empleado.Salario;
                if (salario > salarioMaximo)
                {
                    salarioMaximo = salario;
                    empleadoSalarioMaximo = empleado;
                }
            }
            

            double salarioMaximo2 = 0;
            Empleado empleadoSalarioMaximo2 = null;


            foreach (var empleado2 in xhora)
            {
                double salario = empleado2.Salario;
                if (salario > salarioMaximo2)
                {
                    salarioMaximo2 = salario;
                    empleadoSalarioMaximo2 = empleado2;
                }
            }
            if (empleadoSalarioMaximo != null || empleadoSalarioMaximo2 != null)
            {
                if (salarioMaximo>salarioMaximo2)
                {
                    Console.WriteLine($"\nEl empleado con el salario más alto es: {empleadoSalarioMaximo.Nombre}");
                    Console.WriteLine($"Salario: {salarioMaximo}\n");
                }
                else
                {
                    Console.WriteLine($"\nEl empleado con el salario más alto es: {empleadoSalarioMaximo2.Nombre}");
                    Console.WriteLine($"Salario: {salarioMaximo2}\n");
                }
            }
            else
            {
                Console.WriteLine("No se encontraron empleados");
            }
        }

        private void EliminarEmpleados()
        {
            Console.WriteLine("Ingrese el nombre del empleado a eliminar");
            string nombre = Console.ReadLine();

            bool empCom = false;
            bool empXhora = false;

            for (int i = 0; i < empleadoComision.Count; i++)
            {
                if (empleadoComision[i].Nombre == nombre)
                {
                    empleadoComision.RemoveAt(i);
                    empCom = true; // false * true
                    Console.WriteLine("Empleado por comision eliminado");
                    break;
                }
            }
            for (int i = 0; i < xhora.Count; i++)
            {
                if (xhora[i].Nombre == nombre)
                {
                    xhora.RemoveAt(i);
                    empXhora = true; // false * true
                    Console.WriteLine("Empleado por hora eliminado");
                    break;
                }
            }

            if (!empCom && !empXhora) // false * false -- entra al if
            {
                Console.WriteLine("No se encontro el empleado");
            }

        }

        private void MostrarEmpleados()
        {
            
            if (empleadoComision.Count == 0)
            {
                Console.WriteLine("\nNo hay empleados asalariados en la lista \n");
            }
            else
            {
                Console.WriteLine("\nEmpleados por Comision: ");

                foreach (var empleados in empleadoComision) 
                {
                    Console.WriteLine($"Nombre: {empleados.Nombre}, Apellido: {empleados.Apellido}," +
                        $"Edad: {empleados.Edad}, Salario Base: {empleados.SalarioBase}, Comision: {empleados.Comision}%, " +
                        $"Ventas: {empleados.Ventas}, Salario: {empleados.Salario}");
                }
            }

            if (xhora.Count == 0)
            {
                Console.WriteLine("\nNo hay empleados por horas en la lista\n");
            }
            else
            {
                Console.WriteLine("\nEmpleados por hora: ");

                foreach (var empleados in xhora)
                {
                    Console.WriteLine($"Nombre: {empleados.Nombre}, Apellido: {empleados.Apellido}," +
                        $"Edad: {empleados.Edad}, Horas trabajadas: {empleados.HorasTrabajadas}, " +
                        $"Valor hora: {empleados.ValorHora}, Salario: {empleados.Salario}");
                }
            }
        }

        private void AgregarEmpleado()
        {
            Console.WriteLine("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del empleado: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese la edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Es empleado por comision o por hora? 1.Comision 2.por hora: ");
            int opcionS = Convert.ToInt32(Console.ReadLine());

            if (opcionS == 1)
            {
                Console.WriteLine("Ingrese el salario base del empleado: ");
                double salarioBase = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el porsentaje de comision del empleado: ");
                double comision = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el total de ventas del empleado: ");
                double ventas = Convert.ToDouble(Console.ReadLine());

                empleadoComision.Add(new EmpleadoComision(nombre, apellido, edad, salarioBase, ventas, comision));
            }
            else
            {
                Console.WriteLine("Ingrese las horas trabajadas: ");
                double horasTrabajadas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el valor por hora: ");
                double valorHora = Convert.ToDouble(Console.ReadLine());

                xhora.Add(new EmpleadoPorHora(nombre, apellido, edad, valorHora, horasTrabajadas));
            }
        }
    }
}
