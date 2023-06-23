using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_IntroduccionCSharp.Ejemplos
{
    internal class Calculadora
    {
        public Calculadora()
        {
            Console.WriteLine("Calculadora Básica");

            Console.WriteLine("Ingrese el primer numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            double num2  = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Selecciones una operacion:");
            Console.WriteLine("1. Suma (+)");
            Console.WriteLine("2. Resta (-)");
            Console.WriteLine("3. Multiplicacion (*)");
            Console.WriteLine("4. Division (/)");

            Console.Write("Ingrese el numero que corresponde a la operacion: ");
            int op = Convert.ToInt32(Console.ReadLine());

            double resultado = 0;

            switch (op)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"El resultado de la suma es: {resultado}"); //inyectar string
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"El resultado de la resta es: {resultado}");
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"El resultado de la multiplicacion es: {resultado}");
                    break;
                case 4:
                    
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"El resultado de la division es: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre 0");
                    }

                    
                    break;
                default:
                    Console.WriteLine("Operacion no valida");
                    break;
            }
        }
    }
}
