using System;
using System.Collections.Generic;
using System.Text;

namespace Unidad10_Proyecto
{
   public class Persona
    {
        protected const char Def_Sexo = 'H';
        private string Nombre;
        private int edad;
        private int DNI;
        private char sexo;
        private double peso;
        private double altura;
        protected const int PesoMen = -1;
        protected const int PesoIdeal = 0;
        protected const int PesoMayor = 1;

        public Persona()
        {
            this.Nombre = "";
            this.edad = 0;
            this.sexo = Def_Sexo;
            this.peso = 0;
            this.altura = 0;
        }

        public Persona(string Nombre, int edad, char sexo)
        {
            this.Nombre = Nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public Persona(string Nombre, int edad, char sexo, double peso, double altura)
        {
            this.Nombre = Nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }
       

        private void generarDni()
        {
            const int divisor = 23;

            Random rand = new Random();

            int numDNI = rand.Next(10000000, 80000000);
            int res = numDNI - (numDNI / divisor * divisor);

            //Calculamos la letra del DNI
            char letraDNI = generaLetraDNI(res);

            //Pasamos el DNI a String
            DNI = Convert.ToInt32(numDNI + letraDNI);
        }

        private char generaLetraDNI(int res)
        {
            char[] letras = {'T', 'R', 'W', 'A', 'G', 'M', 'Y',
            'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z',
            'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E'};

            return letras[res];
        }

        public void setNombre(String Nombre)
        {
            this.Nombre = Nombre;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }

        public void setPeso(double peso)
        {
            this.peso = peso;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        public int calcularIMC()
        {
            int pesoIdeal = -1;
            int debajoPeso = 0;
            int sobrepeso = 1;
            //Calculamos el peso de la persona
            double pesoActual = peso / (Math.Pow(altura, 2));
            //Segun el peso, devuelve un codigo
            if (pesoActual >= 20 && pesoActual <= 25)
            {
                return pesoIdeal;
            }
            else if (pesoActual < 20)
            {
                return debajoPeso;
            }
            else
            {
                return sobrepeso;
            }
        }

        public Boolean esMayorDeEdad()
        {
            bool mayor = false;
            if (edad >= 18)
            {
                mayor = true;
            }
            return mayor;
        }

        public void ValidaPeso (Persona p)
        {
            int IMC = p.calcularIMC();
            switch (IMC)
            {
                case Persona.PesoIdeal:
                    Console.WriteLine("La persona esta en su peso ideal");
                    break;
                case Persona.PesoMen:
                    Console.WriteLine("La persona esta por debajo de su peso ideal");
                    break;
                case Persona.PesoMayor:
                    Console.WriteLine("La persona esta por encima de su peso ideal");
                    break;
            }
        }

        public void MayorDeEdad(Persona p)
        {

            if (p.esMayorDeEdad())
            {
                Console.WriteLine("La persona es mayor de edad");
            }
            else
            {
                Console.WriteLine("La persona no es mayor de edad");
            }
        }

        public String toString()
        {
            String sexo;
            if (this.sexo == 'H')
            {
                sexo = "Hombre";
            }
            else
            {
                sexo = "Mujer";
            }
            return "Informacion de la persona:\n"
                    + "Nombre: " + Nombre + "\n"
                    + "Sexo: " + sexo + "\n"
                    + "Edad: " + edad + " años\n"
                    + "DNI: " + DNI + "\n"
                    + "Peso: " + peso + " kg\n"
                    + "Altura: " + altura + " metros\n";
        }
    }
}
