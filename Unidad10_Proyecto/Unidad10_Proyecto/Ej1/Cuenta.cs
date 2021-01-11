using System;
using System.Collections.Generic;
using System.Text;

namespace Unidad10_Proyecto
{
    class Cuenta
    {
        private string _Titular;
        private decimal _Cantidad;

        public String Titular
        {
            get { return _Titular;   }
            set { _Titular = value; }
        }

        public Decimal Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        public Cuenta()
        {
            Titular = "Fernanbuncio";
        }

        public String toString()
        {
            return "Cuenta: [Titular= " + Titular + ", Cantidad= " + Cantidad + "]";
        }

        public void Ingresar()
        {
            Console.WriteLine("Introduzca una cantidad a ingresar");

            decimal ingreso = Convert.ToDecimal(Console.ReadLine());


            if (ingreso < 0)
            {
                Console.WriteLine("Lo sentimos, pero no puede ingresar numeros negativos");
               
            }
            else if (ingreso > 0) {
                Console.WriteLine("Ingreso realizado");
                Cantidad += ingreso;
            }
           Console.WriteLine(toString());

        }

        

        public void Retirar()
        {
            Menu menu = new Menu();
            Console.WriteLine("Introduzca una cantidad a retirar");

            decimal retirar = Convert.ToDecimal(Console.ReadLine());

            if (retirar > 0)
            {               
                Cantidad -= retirar;
                if (Cantidad < 0)
                {
                    Cantidad = 0;
                }
            }else if(retirar < 0)
            {
                Cantidad = 0;
            }
            Console.WriteLine("Retiro realizado");

            Console.WriteLine(toString());
            menu.Ejercicios();

        }

        

    }
}
