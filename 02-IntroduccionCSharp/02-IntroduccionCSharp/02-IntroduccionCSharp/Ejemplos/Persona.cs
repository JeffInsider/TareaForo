using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_IntroduccionCSharp.Ejemplos
{
    public class Persona
    {
        public string Nombres { get; set; }

        public string Apellidos { get; set; }
        public int Edad { get; set; }

        public Persona()
        {
            
        }
        public Persona(string nombres, string apellidos, int edad)
        {
            this.Nombres = nombres;
            this.Edad = edad;
            this.Apellidos = apellidos;
        }


        public void Saludar()
        {
            Console.WriteLine($"Hola mi nombre es {this.Nombres} {this.Apellidos} y tengo {Edad} años.");
        }
    }
}
