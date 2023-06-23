﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_IntroduccionCSharp.Ejemplos
{
    internal class Dados
    {
        public Dados()
        {
            Console.WriteLine("Simulador de dado");

            Console.WriteLine("Ingese la cantidad de lanzamientos:");
            int cantidadLanzamentos = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();

            Console.WriteLine("Resultados de los lanzamientos");

            for (int i = 1; i <= cantidadLanzamentos; i++)
            {
                int resultado = random.Next(1,7);
                Console.WriteLine($"Lanzamiento {i} {resultado}");
            }

            Console.ReadLine();
        }
    }
}
