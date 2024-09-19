using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_02
{
    internal class Celular
    {
        private int numero { get; set; }
        private string usuario { get; set; }
        private int segundosConsumidos { get; set; }
        private double precioSegundo { get; set; }

        public Celular()
        {

        }

        public Celular(int segundosConsumidos)
        {
            this.segundosConsumidos = segundosConsumidos;
        }
        public Celular(int numero, string usuario, int segundosConsumidos, double precioSegundo)
        {
            this.numero = numero;
            this.usuario = usuario;
            this.segundosConsumidos = segundosConsumidos;
            this.precioSegundo = precioSegundo;
        }


        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }


        public int SegundosConsumidos
        {
            get { return segundosConsumidos; }
            set { segundosConsumidos = value; }
        }


        public double PrecioSegundo
        {
            get { return precioSegundo; }
            set { precioSegundo = value; }
        }

        public double costoConsumo()
        {
            return segundosConsumidos * precioSegundo;
        }

        public double impuestoIGV()
        {
            return costoConsumo() * 0.18;
        }

        public double totalPago()
        {
            return costoConsumo() + impuestoIGV();
        }

    }
}
