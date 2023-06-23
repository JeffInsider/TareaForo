using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_IntroduccionCSharp.Ejemplos
{
    internal class Palindromas
    {
        public Palindromas()
        {
            Console.WriteLine("Detector de frases palindromas");
            Console.WriteLine("Ingrese la frase a evaluar:");
            string frase = Console.ReadLine();
            

            if (EsPalindroma(frase))
            {
                Console.WriteLine("La frase que ingreso es palindroma :)");
            }
            else
            {
                Console.WriteLine("La frase no es palindroma :(");
            }

        }

        private Boolean EsPalindroma(string frase)
        {
            frase = frase.Replace(" ", ""); //eliminar espacios en blanco
            frase = Regex.Replace(frase, "[^a-zA-Z]+", "");//eliminar caracteres especiales excepto minusculas y mayusculas
            frase = frase.ToLower();//eliminar mayusculas


            for (int i = 0; i < frase.Length; i++) { 
                char temp = frase[i];
                char tempFinal = frase[frase.Length-(i+1)];

                if (temp != tempFinal)
                {
                    return false; 
                }
            }

            return true;
        }
    }
}
