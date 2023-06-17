using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        class Cuadrado
        {
            public int lado;
           public void Perimetro(int lado)
            {
                int perimetro;
                perimetro = lado * 4;
                Console.WriteLine("El valor del perimetro es: {0}",perimetro);
            }
            public void Area(int lado)
            {
                int area;
                area = lado * lado;
                Console.WriteLine("El valor del area es:{0}",area);
            }
        }
        static void Main()
        {
            Cuadrado cuadrado1 = new Cuadrado();
            Console.WriteLine("Ingrese el valor de los lados del cuadrado");
            cuadrado1.lado = Convert.ToInt32(Console.ReadLine());
            cuadrado1.Perimetro(cuadrado1.lado);
            cuadrado1.Area(cuadrado1.lado);
            Console.ReadKey();
        }
    }
}
