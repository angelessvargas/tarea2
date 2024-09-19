using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora c = new Computadora(999, "hp", "platino", 450);
            //(int codigo, string marca, string color, double precioDolares)
            listarDatos(c);

            
            c.PrecioDolares *= 0.90;

            listarDatos(c);

            Console.ReadKey();
        }
        static void listarDatos(Computadora c)
        {
            Console.WriteLine("datos de la compra");
            Console.WriteLine("Código: " + c.Codigo);
            Console.WriteLine("Marca: " + c.Marca);
            Console.WriteLine("Color: " + c.Color);
            Console.WriteLine("Precio en DOlares: " + c.PrecioDolares);
            Console.WriteLine("Precio en Soles: " + c.getPrecioSoles());
            Console.WriteLine("Precio en Euros: " + c.getPrecioEuros());
            Console.WriteLine();
        }
    }
}
