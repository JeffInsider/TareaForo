using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_IntroduccionCSharp.Ejemplos
{
    public class GeneradorPassword
    {
        public GeneradorPassword()
        {
            Console.WriteLine("Generador de contraseñas");
            Console.WriteLine("Ingrese la longitud que espera de la contraseña");

            int longitud = Convert.ToInt32(Console.ReadLine());

            string password = GenerarClave(longitud);

            Console.WriteLine("Contraseña generada: " + password);

            Console.ReadLine();
        }

        private string GenerarClave(int longitud)
        {
            const string caracteresMayusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string caracteresMinusculas = "abcdefghijklmnopqrstuvwxyz";
            const string numeros = "0123456789";
            const string caracteresEspeciales = "~|@#~€¬!·%&/()=?¿+-,._-;:Ç`ç^*";

            StringBuilder password = new StringBuilder();

            Random random = new Random();

            password.Append(caracteresMayusculas[random.Next(caracteresMayusculas.Length)]); //genera un aleatorio desde 0 hasta el numero que tiene la variable
            password.Append(caracteresMinusculas[random.Next(caracteresMinusculas.Length)]);
            password.Append(numeros[random.Next(numeros.Length)]);
            password.Append(caracteresEspeciales[random.Next(caracteresEspeciales.Length)]);

            for (int i = 4; i<=longitud; i++) //empiez el 4 por que ya se asiganron los 0,1,2,3
            {
                string caracteresDisponibles = caracteresMayusculas + caracteresMinusculas 
                    + numeros + caracteresEspeciales;

                password.Append(caracteresDisponibles[random.Next(caracteresDisponibles.Length)]);
            }

            //mezclar la contraseña
            for (int i = 0; i < password.Length; i++)
            {
                int posicionAleatoria = random.Next(password.Length); // un random dentro de el numero que tiene la contra
                char temporal = password[i];
                password[i] = password[posicionAleatoria];
                password[posicionAleatoria] = temporal;
            }

            return password.ToString();
        }
    }
}
