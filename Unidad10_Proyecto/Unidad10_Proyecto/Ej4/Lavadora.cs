using System;
using System.Collections.Generic;
using System.Text;

namespace Unidad10_Proyecto
{
    public class Lavadora : Electrodomestico
    {
        private const int cargaDef = 5;

        private int carga;

        public int Carga { get => carga; }

        public Lavadora()
        {
            precio = precioBaseDef;       
            peso = pesoDef;
            consumoEnergetico = consumoEnergeticoDef;
            color = colorDef;
            carga = cargaDef;

        }

        public Lavadora(double precio, double peso)
        {
            this.precio = precio;
            this.peso = peso;
            consumoEnergetico = consumoEnergeticoDef;
            color = colorDef;
            carga = cargaDef;

        }

        public Lavadora(double precio, double peso, char consumoEnergetico, string color, int carga)
        {
            this.precio = precio;
            this.peso = peso;
            this.consumoEnergetico = consumoEnergetico;
            this.color = color;
            this.carga = carga;
        }



    }
}
