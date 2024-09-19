using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el c0digo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el número de celular: ");
            int numCelular = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el sueldo en soles: ");
            double sueldoSoles = double.Parse(Console.ReadLine());


            Empleado e = new Empleado(codigo, nombre, numCelular, sueldoSoles);

            Listado(e);


            e.NumCelular = 999888777;
            e.SueldoSoles += 200;


            Listado(e);
            Console.ReadKey();  
        }
        public static void Listado(Empleado e)
        {


            Console.WriteLine("Codigo:" + e.Codigo);
            Console.WriteLine("Nombre:" + e.Nombre);
            Console.WriteLine("Numero de celular :" + e.NumCelular);
            Console.WriteLine("Sueldos en soles :" + e.SueldoSoles);
            Console.WriteLine();
        }
    }
}
