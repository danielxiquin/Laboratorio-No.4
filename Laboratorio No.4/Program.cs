using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_No._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ejercicio 1: Operaciones Aritmeticas");
            Console.WriteLine("");

            Console.Write("Ingrese un numero: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese otro numero: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            int suma = n1 + n2;
            int resta = n1 - n2;
            int multiplicacion = n1 * n2;
            double div1 = n1;
            double division = div1 / n2;
            int divOperacion = n1 / n2;
            int resto = n1 % n2;

            Console.WriteLine(n1 + "+" + n2 + "=" + suma);
            Console.WriteLine(n1 + "-" + n2 + "=" + resta);
            Console.WriteLine(n1 + "*" + n2 + "=" + multiplicacion);
            Console.WriteLine(n1 + "/" + n2 + "=" + division);
            Console.WriteLine(n1 + "/" + n2 + "=" + divOperacion);
            Console.WriteLine(n1 + "%" + n2 + "=" + resto);

            //Ejercicio 2

            Console.WriteLine("Ejercicio 2: Operaciones booleanas");

            bool mayor = n1 > n2; 
            bool menor = n1 < n2;
            bool igual = n1 == n2;

            Console.WriteLine(n1+">"+n2+ "="+mayor);
            Console.WriteLine(n1 + "<" + n2 + "=" + menor);
            Console.WriteLine(n1 + "=" + n2 + "=" + igual);

        }
    }
}
