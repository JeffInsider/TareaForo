using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_IntroduccionCSharp.Ejemplos.Frutas
{
    public class AppFrutas
    {
        List<Fruta> frutas = new(); //lista
        public AppFrutas()
        {
            Console.WriteLine("Bienvenido");
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n ¿Que accion desea realizar?");
                Console.WriteLine("1. Agregar fruta");
                Console.WriteLine("2. Mostrar frutas");
                Console.WriteLine("3. Eliminar frutas");
                Console.WriteLine("4. Vaciar lista de frutas");
                Console.WriteLine("5. Salir");

                Console.WriteLine("Ingrese el numero de la opcion:");
                int opcion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        AgregarFruta();
                        break;
                    case 2:
                        MostrarFrutas();
                        break;
                    case 3:
                        EliminarFruta();
                        break;
                    case 4:
                        VaciarLista();
                        break;
                    case 5:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida. ");
                        break;
;
                }

            }
        }

        private void VaciarLista()
        {
            frutas.Clear();
            Console.WriteLine("Lista de frutas borrada");
        }

        private void EliminarFruta()
        {
            Console.WriteLine("Ingrese la fruta que quiere borrar");
            string nombre = Console.ReadLine();

            bool frutaEncontrada = false;

            for (int i = 0; i < frutas.Count; i++)
            {
                if (frutas[i].Nombre == nombre)
                {
                    frutas.RemoveAt(i);
                    frutaEncontrada = true; // false * true
                    Console.WriteLine("Fruta eliminada");
                    break;
                }
            }

            if (!frutaEncontrada) // false * false -- entra al if
            {
                Console.WriteLine("No se encontro la fruta en la lista");
            }
        }

        private void MostrarFrutas()
        {
            if (frutas.Count == 0)
            {
                Console.WriteLine("No hay frutas en la lista");
            }
            else
            {
                Console.WriteLine("Lista de Frutas");

                foreach (var fruta in frutas) //quedara guardada en var fruta cada elemento de la lista
                {
                    Console.WriteLine($"Nombre: {fruta.Nombre}, Color: {fruta.Color}");
                }
            }
        }

        private void AgregarFruta()
        {
            Console.Write("Ingrese el nombre de la fruta: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el color de la fruta: ");
            string color = Console.ReadLine();

            frutas.Add(new Fruta(nombre, color));
            Console.WriteLine("Fruta agregada exitosamente");
        }
    }
}
