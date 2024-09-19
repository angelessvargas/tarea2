﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_07
{
    internal class Paciente
    {


       
        private string nombre { get; set; }
        private string apellido { get; set; }
        private int edad { get; set; }
        private double talla { get; set; }
        private double peso { get; set; }

        public Paciente(string nombre, string apellido, int edad, double talla, double peso)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.talla = talla;
            this.peso = peso;
        }

        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public double Talla
        {
            get { return talla; }
            set { talla = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        
        public string getedadPersona()
        {
            if (edad < 18)
            {
                return "menor  de edad";
            }
            else 
            {
                return "mayor de edad";
            }
        }


    }
}