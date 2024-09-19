using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_04
{
    internal class Edificio
    {


        private int codigo { get; set; }
        private int numeroDepartamentos { get; set; }
        private int CantidadPisos { get; set; }
        private double PrecioDepartamentoDolares { get; set; }

        
        public Edificio(int codigo, int numeroDepartamentos, int CantidadPisos, double PrecioDepartamentoDolares)
        {
            this.codigo = codigo;
            this.numeroDepartamentos = numeroDepartamentos;
            this.CantidadPisos = CantidadPisos;
            this.PrecioDepartamentoDolares = PrecioDepartamentoDolares;
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int numeroDepartamento
        {
            get { return numeroDepartamentos; }
            set { numeroDepartamentos = value; }
        }
        
        public int CantidadPiso
        {
            get { return CantidadPisos; }
            set { CantidadPisos = value; }
        }

        
        public double PrecioDepartamentoDolare
        {
            get { return PrecioDepartamentoDolares; }
            set { PrecioDepartamentoDolares = value; }
        }

                public double PrecioTotalEnDolares()

        {
            return numeroDepartamentos * PrecioDepartamentoDolares;
        }




    }

}


        
       