using System;
using System.Collections.Generic;
using System.Text;

namespace Unidad10_Proyecto
{
   public class Electrodomestico
    {
        protected const  string colorDef = "blanco";
        
        protected const  char consumoEnergeticoDef = 'F';

        protected const  double precioBaseDef = 100;
       
        protected const  double pesoDef = 5;


        protected double precio;

        protected string color;

        protected char consumoEnergetico;

        protected double peso;

        protected double Precio { get => precio; }
        protected string Color { get => color; }
        protected char ConsumoEnergetico { get => consumoEnergetico; }
        protected double Peso { get => peso; }

        public Electrodomestico()
        {
            precio = precioBaseDef;
            peso = pesoDef;
            consumoEnergetico = consumoEnergeticoDef;
            color = colorDef;
        }

        public Electrodomestico(double precio, double peso)
        {
            this.precio = precio;
            this.peso = peso;
            consumoEnergetico = consumoEnergeticoDef;
            color = colorDef;
        }

        public Electrodomestico(double precio, double peso, char consumoEnergetico, string color  )
        {
            this.precio = precio;
            this.peso = peso;
            comprobarConsumoEnergetico(consumoEnergetico);
            comprobarColor(color);
        }

        

        public void comprobarConsumoEnergetico(char consumoEnergetico)
        {

            if (consumoEnergetico >= 65 && consumoEnergetico <= 70)
            {
                this.consumoEnergetico = consumoEnergetico;
            }
            else
            {
                this.consumoEnergetico = consumoEnergeticoDef;
            }

        }

        public void comprobarColor(string color)
        {
            string[] colores = { "blanco", "negro", "rojo", "azul", "gris" };
            Boolean encontrado = false;

            for (int i = 0; i < colores.Length && !encontrado; i++)
            {

                if (colores[i].Equals(color))
                {
                    encontrado = true;
                }

            }

            if (encontrado)
            {
                this.color = color;
            }
            else
            {
                this.color = colorDef;
            }
        }

        public double precioFinal()
        {
            double plus = 0;
            switch (consumoEnergetico)
            {
                case 'A':
                    plus += 100;
                    break;
                case 'B':
                    plus += 80;
                    break;
                case 'C':
                    plus += 60;
                    break;
                case 'D':
                    plus += 50;
                    break;
                case 'E':
                    plus += 30;
                    break;
                case 'F':
                    plus += 10;
                    break;
            }

            if (peso >= 0 && peso < 19)
            {
                plus += 10;
            }
            else if (peso >= 20 && peso < 49)
            {
                plus += 50;
            }
            else if (peso >= 50 && peso <= 79)
            {
                plus += 80;
            }
            else if (peso >= 80)
            {
                plus += 100;
            }

            return precio + plus;
        }

    }
}
