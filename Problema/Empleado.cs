using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema
{
    internal class Empleado
    {
       

        private int codigo {  get; set; }
            private string nombre { get; set; }
            private  int numCelular { get; set; }
            private double sueldoSoles { get; set; }

        public Empleado(int codigo, string nombre, int numCelular, double sueldoSoles)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.numCelular = numCelular;
            this.sueldoSoles = sueldoSoles;
        }

        
         public int Codigo
         {
            get { return codigo; }
            set { codigo = value; }

         } 
         public string Nombre 
         { 
            get { return nombre; } 
            set { nombre = value; } 
         }   
         public int NumCelular
         { 
            get { return numCelular; }
            set { numCelular = value; }
         }
         public double SueldoSoles
         {
            get { return sueldoSoles; }
            set { sueldoSoles = value; }
         }
        public String getSueldo()
        {
            if (sueldoSoles > 3500)
            {
                return "mayor a 3500";
            }
            else if (sueldoSoles < 3500)
            {
                return "menor a 3500";
            }
            else
            {
                return "igual a 3500";
            }
        }

    }
}
