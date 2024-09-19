using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_10
{
    internal class Pelota
    {
        public Pelota(string marca, double pesoGramos, double presionLibras, double diametroCem, double precio)
        {
            this.marca = marca;
            this.pesoGramos = pesoGramos;
            this.presionLibras = presionLibras;
            this.diametroCem = diametroCem;
            this.precio = precio;
        }

        //marca (String), peso en gramos(double), presión en libras(double), diámetro en centímetros(double) y precio(double
        private string marca {  get; set; }
        private double pesoGramos { get; set; }
        private  double presionLibras { get; set; }
        private double diametroCem {  get; set; }   

        private  double precio {  get; set; }


        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public double PesoGramos
        {
            get { return pesoGramos; }
            set { pesoGramos = value; }
        }

        public double PresionLibras
        {
            get { return presionLibras; }
            set { presionLibras = value; }
        }

        public double DiametroCem
        {
            get { return diametroCem; }
            set { diametroCem = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        
        public double getCalcularRadio()
        {
            return DiametroCem / 2;
        }

        
        public double getCalcularVolumen()
        {
            double radio = getCalcularRadio();
            return (4.0 / 3.0) * 3.1416 * Math.Pow(radio, 3);
        }

        
        public double getCalcularDescuento()
        {
            return precio * 0.10;
        }

        public double getCalcularImporteAPagar()
        {
            return precio - getCalcularDescuento();
        }
    }
}
