using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_04
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el código del edificio:");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de departamentos:");
            int numeroDepartamentos = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de pisos del edificio:");
            int cantidadPisos = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio de un departamento en dólares:");
            double precioDepartamentoDolares = double.Parse(Console.ReadLine());

            Edificio e= new Edificio(codigo, numeroDepartamentos, cantidadPisos, precioDepartamentoDolares);


            ListarDatos(e);

           
            e.PrecioDepartamentoDolare *= 1.20;

            
            ListarDatos(e);
            Console.ReadKey();

        }

        
        static void ListarDatos(Edificio e)
        {
            Console.WriteLine("Código: " + e.Codigo);
            Console.WriteLine("Número de Departamentos: " + e.numeroDepartamento);
            Console.WriteLine("Cantidad de Pisos: " + e.CantidadPiso);
            Console.WriteLine("Precio de un Departamento en Dólares: $" + e.PrecioDepartamentoDolare);
            Console.WriteLine("Precio Total del Edificio en Dólares: $" + e.PrecioTotalEnDolares());
            Console.WriteLine();
            
        }
    }
    }

