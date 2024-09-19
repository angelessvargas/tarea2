using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo = 333;
            String nombreVideo = "video de programacion";
            double duracion = 90; 
            double precioSoles = 45.5;
            double tipoCambio = 3.76;

            
            Video v = new Video(codigo, nombreVideo, duracion, precioSoles, tipoCambio);

           
            listado(v);

            
            v.PrecioSoles += 5.50;

           
            listado(v);
            Console.ReadKey();
        }

        
        public static void listado(Video v)
        {
            Console.WriteLine("Código: " + v.Codigo);
            Console.WriteLine("Nombre del Video: " + v.NombreVideo );
            Console.WriteLine("Duración: " + v.Duracion );
            Console.WriteLine("Precio en Soles: " + v.PrecioSoles );
            Console.WriteLine("Tipo de Cambio: " + v.TipoCambio);
            Console.WriteLine("Precio en Dólares: " + v.getprecioDolares() );
            Console.WriteLine();
        }
    
    }
}
