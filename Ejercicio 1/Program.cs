using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Numeros
    {
        public int n1;
        public int n2;
        public int op;

        public void Operar(int op,int n1,int n2)
        {
            int resultado;
           switch (op)
            {
                case 1:
                    resultado = n1 + n2;
                    Console.WriteLine("El resultado de la suma es:{0}",resultado);
                    break; 
                case 2:
                    resultado = n1 - n2;
                    Console.WriteLine("El resultado de la resta es:{0}", resultado);
                    break;
                default:
                    Console.WriteLine("No se puede realizar ninguna operacion");
                    break;
            }
        }
    }
    internal class Program
    {
        static void Main()
        {
            Numeros operacion1 = new Numeros();
            Console.Write("Ingrese el primer numero:");
            operacion1.n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero:");
            operacion1.n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese una opcion para realizar la siguiente operacion:");
            Console.WriteLine("1-Sumar");
            Console.WriteLine("2-Restar");
            operacion1.op = Convert.ToInt32(Console.ReadLine());
            operacion1.Operar(operacion1.op,operacion1.n1,operacion1.n2);
        }
    }
}
