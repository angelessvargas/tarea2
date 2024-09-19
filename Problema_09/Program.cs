using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Asesor a = new Asesor( 666, "Raul", 40, 10.5);

            listado(a);

            
            a.HorasTrabajadas += 10;
            a.TarifaHora *= 0.85;

            
            listado(a);

            Console.ReadKey();
        }
        public static void listado(Asesor a)
        {
            Console.WriteLine("Datos actualizados");
            Console.WriteLine("    Codigo  :" + a.Codigo);
            Console.WriteLine("    Nombre  :" + a.Nombre);
            Console.WriteLine("    Horas trabajadas   :" + a.HorasTrabajadas);
            Console.WriteLine("    Tarifa por hora   :" + a.TarifaHora);
            Console.WriteLine("    Sueldo Bruto   :" + a.getsueldoBruto());
            Console.WriteLine("    Descuento  :" + a.getdescuento());
            Console.WriteLine("    Sueldo Neto   :" + a.getsueldoNeto());

        }
    }
}
