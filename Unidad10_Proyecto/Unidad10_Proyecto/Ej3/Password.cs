using System;
using System.Collections.Generic;
using System.Text;

namespace Unidad10_Proyecto
{
   public class Password
    {
        private const int Max_Pass = 8;
        private int long_pass;
        private string passw;

        public int Long_pass { set => long_pass = value; }
        public string Passw { get => passw; set => passw = value; }


        public Password()
        {
            this.long_pass = Max_Pass;
        }

        public Password(int longitud)
        {
            this.long_pass = longitud;
            passw = generaPassword();
        }

        public String generaPassword()
        {
            String password = "";
            Random rand = new Random();
            
            for (int i = 0; i < long_pass; i++)
            {
                //Generamos un numero aleatorio
                int eleccion = ((int)Math.Floor(rand.NextDouble() * 3 + 1));

                if (eleccion == 1)
                {
                    char minusculas = (char)((int)Math.Floor(rand.NextDouble() * (123 - 97) + 97));
                    password += minusculas;
                }
                else
                {
                    if (eleccion == 2)
                    {
                        char mayusculas = (char)((int)Math.Floor(rand.NextDouble() * (91 - 65) + 65));
                        password += mayusculas;
                    }
                    else
                    {
                        char numeros = (char)((int)Math.Floor(rand.NextDouble() * (58 - 48) + 48));
                        password += numeros;
                    }
                }
            }
            return password;
        }

        public Boolean esFuerte()
        {
            int cuentanumeros = 0;
            int cuentaminusculas = 0;
            int cuentamayusculas = 0;
            //Comprobamos que tipo de caracter
            for (int i = 0; i < passw.Length; i++)
            {
               
                if (passw[i] >= 97 && passw[i] <= 122)
                {
                    cuentaminusculas += 1;
                }
                else
                {
                    if (passw[i] >= 65 && passw[i] <= 90)
                    {
                        cuentamayusculas += 1;
                    }
                    else
                    {
                        cuentanumeros += 1;
                    }
                }
            }
            //Si la constraseña tiene mas de 5 numeros, mas de 1 minuscula y mas de 2 mayusculas
            if (cuentanumeros >= 5 && cuentaminusculas >= 1 && cuentamayusculas >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
