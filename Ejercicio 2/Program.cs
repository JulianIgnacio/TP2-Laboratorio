using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Persona
    {
        public int edad;
        public string nombre;
        public void Mostrar(string nombre, int edad)
        {
            Console.WriteLine("El nombre de la persona es:{0}", nombre);
            Console.WriteLine("El nombre de la persona es:{0}", edad);
        }
        public void Comparar()
        {
            if (edad >= 18)
            {
                Console.WriteLine("{0} Es mayor de edad", nombre);

            }
            else
            {
                Console.WriteLine("{0} Es menor de edad", nombre);

            }
        }

    }
    internal class Program
    {
        static void Main()
        {
            Persona individuo1 = new Persona();
            Console.Write("Ingrese el nombre de la Persona:");
            individuo1.nombre = Console.ReadLine();
            Console.Write("Ingrese la edad del individuo:");
            individuo1.edad = Convert.ToInt32(Console.ReadLine());
            individuo1.Mostrar(individuo1.nombre, individuo1.edad);
            individuo1.Comparar();
            Console.ReadKey();
        }
    }
}
