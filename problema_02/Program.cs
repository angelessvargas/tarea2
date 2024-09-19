using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular c = new Celular(987456321, "jefferson", 40, 105.5);

            
            listarDatos(c);

            c.SegundosConsumidos += 20;

            c.PrecioSegundo *= 0.95;

                      listarDatos(c);

            Console.ReadKey();



        }
        public static void listarDatos(Celular c)
        {
            Console.WriteLine("datos del usuario");
            Console.WriteLine("numero:  " + c.Numero);
            Console.WriteLine("nombre:  " + c.Usuario);
            Console.WriteLine("segundos consumidos:  " + c.SegundosConsumidos);
            Console.WriteLine("precio por segundo :  " + c.PrecioSegundo);
            Console.WriteLine("costo  del consumo:" + c.costoConsumo());
            Console.WriteLine("impuesto IGV:" + c.impuestoIGV());
            Console.WriteLine("total a pagar:" + c.totalPago());
            Console.WriteLine();





        }
    }
    }

