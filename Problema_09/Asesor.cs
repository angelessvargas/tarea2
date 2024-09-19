using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_09
{
    internal class Asesor
    {



        private int codigo { get; set; }
        private string nombre { get; set; }
        private int horasTrabajadas { get; set; }
        private double tarifaHora { get; set; }
        public Asesor(int codigo, string nombre, int horasTrabajadas, double tarifaHora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasTrabajadas = horasTrabajadas;
            this.tarifaHora = tarifaHora;
        }
        //codigo (int), nombre   (String), horas trabajadas(int) y tarifa por hora(double

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
         public int HorasTrabajadas
        {
            get { return horasTrabajadas; }
            set { horasTrabajadas = value; }
        }
           public double TarifaHora      

           {
            get { return tarifaHora; }
            set { tarifaHora = value; }
           }
        public double getsueldoBruto ()
        {
            return horasTrabajadas * tarifaHora;
        }
        
        public double getdescuento ()
        {
            return getsueldoBruto() * 0.15;
        }
        
        public double getsueldoNeto()
        {
            return getsueldoBruto() - getdescuento();
        }
    }
}
