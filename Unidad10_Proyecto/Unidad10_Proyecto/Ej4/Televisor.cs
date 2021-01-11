using System;
using System.Collections.Generic;
using System.Text;

namespace Unidad10_Proyecto
{
    public class Televisor : Electrodomestico
    {
        private const int resolucionDef = 20;
        private const bool sintonizadorTDtDef = false;

        protected int resolucion;
        protected bool sintonizadorTDT;

        protected int Resolucion { get => resolucion; }
        protected bool SintonizadorTDT { get => sintonizadorTDT; }


        public Televisor()
        {
            precio = precioBaseDef;
            peso = pesoDef;
            consumoEnergetico = consumoEnergeticoDef;
            color = colorDef;
            resolucion = resolucionDef;
            sintonizadorTDT = sintonizadorTDtDef;
        }

        public Televisor(double precio, double peso)
        {
            this.precio = precio;
            this.peso = peso;
            consumoEnergetico = consumoEnergeticoDef;
            color = colorDef;
            resolucion = resolucionDef;
            sintonizadorTDT = sintonizadorTDtDef;

        }

        public Televisor(double precio, double peso, char consumoEnergetico, string color, int resolucion, bool sintonizadorTDT)
        {
            this.precio = precio;
            this.peso = peso;
            this.consumoEnergetico = consumoEnergetico;
            this.color = color;
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizadorTDT;
        }


        public double precioFinal(Electrodomestico elect)
        {

            double plus = elect.precioFinal();           
            
            if (resolucion > 40)
            {
                plus += precio * 0.3;
            }
            if (sintonizadorTDT)
            {
                plus += 50;
            }

            return plus;
        }


    }
}
