using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Problema_
{
    internal class Obrero
    {
        
        private int  codigo {  get; set; }  
        private string nombre {  get; set; }
      private int horastrabajadas { get; set; }
             private double tarifahora {  get; set; }  
        public Obrero(int codigo, string nombre, int horastrabajadas, double tarifahora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horastrabajadas = horastrabajadas;
            this.tarifahora = tarifahora;
        }

        public int Codigo
        { 
           get{ return codigo; }
            set{ codigo = value; }
        } 
        public string Nombre
        {
          get  { return nombre; }
           set { nombre = value; }
        }
        public int Horastrabajadas
        {
            get { return horastrabajadas ; }
            set { horastrabajadas = value; }
        }


        public double Tarifahora
        {
            get { return tarifahora; }
            set { tarifahora = value; }
        }

       
        public double getsueldoBruto()
        {
            return tarifahora * horastrabajadas;
        }
        
        public double getdescuentoAFP()
        {
            return getsueldoBruto() * 0.10;
        }
        
        public double getdescuentoEPS()
        {
            return getsueldoBruto() * 0.05;
        }
        
        public double getsueldoNeto()
        {
            return getsueldoBruto()- getdescuentoAFP()- getdescuentoEPS();
        }

    }
}
