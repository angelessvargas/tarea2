using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente p = new Paciente("Ama", "Lopez", 20, 1.58, 50);


            Console.WriteLine("Nombre:" + p.Nombre);
            Console.WriteLine("Apellido:" + p.Apellido);
            Console.WriteLine("Edad:" + p.Edad);
            Console.WriteLine("Talla:" + p.Talla);
            Console.WriteLine("Peso:" + p.Peso);
            Console.WriteLine("Edad del paciente:" + p.getedadPersona());
            Console.WriteLine();

            p.Edad = 15;

            Console.WriteLine("Datos actualizados del paciente");

            Console.WriteLine("Nombre:" + p.Nombre);
            Console.WriteLine("Apellido:" + p.Apellido);
            Console.WriteLine("Edad:" + p.Edad);
            Console.WriteLine("Talla:" + p.Talla);
            Console.WriteLine("Peso:" + p.Peso);
            Console.WriteLine("Edad del paciente:" + p.getedadPersona());
            Console.WriteLine();

            Console.ReadKey();  

        }
    }
}
