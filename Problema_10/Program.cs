using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pelota p = new Pelota("USK", 111.1, 12, 22.2, 55.5);


            Listado(p);

           
            p.Precio *= 0.75;

            p.DiametroCem += 1.0;

            Listado(p);
            Console.ReadKey();  
        }
        
        public static void Listado(Pelota p)
        {
            Console.WriteLine("Marca : " + p.Marca);
            Console.WriteLine(" Peso en gramos : " + p.PesoGramos);
            Console.WriteLine(" Presion en libras : " + p.PresionLibras);
            Console.WriteLine("Diametro en centímetros : " + p.DiametroCem);
            Console.WriteLine("Calcular Radio  : " + p.getCalcularRadio());
            Console.WriteLine("Calcular volumen  : " + p.getCalcularVolumen());
            Console.WriteLine("Calcular descuento : " + p.getCalcularDescuento());
            Console.WriteLine("Calcular importe a  pagar  : " + p.getCalcularImporteAPagar());
            Console.WriteLine();


        }
    }
}
