using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Obrero o = new Obrero(555, "Juan Orlando", 60, 25);

            Console.WriteLine("Datos iniciales:");
            

            Listado(o);

            o.Horastrabajadas += 8;

            
            o.Tarifahora *= 0.985;

           
            Console.WriteLine("Datos actualizados:");
            Listado(o);


            Console.ReadLine();







        }

        private static void Listado(Obrero o)
        {
            Console.WriteLine("codigo:" + o.Codigo);
            Console.WriteLine("nombre:" + o.Nombre);
            Console.WriteLine("codigo:" + o.Horastrabajadas);
            Console.WriteLine("Horas trabajadas:" + o.Tarifahora);
            Console.WriteLine("sueldo Bruto:" + o.getsueldoBruto());
            Console.WriteLine("descuento AFP:" + o.getdescuentoAFP());
            Console.WriteLine("descuento por EPS:" + o.getdescuentoEPS());
            Console.WriteLine("Sueldo Neto:" + o.getsueldoNeto());

        }
    }
}
