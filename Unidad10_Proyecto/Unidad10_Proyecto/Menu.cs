﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Unidad10_Proyecto
{
    class Menu
    {
        public void Ejercicios()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("¿Que ejercicio desea inspeccionar?(Tenga en cuenta los espacios, Ej: Ejercicio 1)\n" +
                "Si desea salir del programa escriba 'Salir'");
            String Ejercicio = Console.ReadLine();

            switch (Ejercicio)

               
            {
                case "Ejercicio 1":
                    Cuenta cuenta = new Cuenta();

                    cuenta.Ingresar();
                    cuenta.Retirar();

                    break;

                case "Ejercicio 2":
                    Console.WriteLine("Introduzca el nombre de la persona: ");
                    string nombre = Console.ReadLine();

                    Console.WriteLine("Introduzca la edad: ");
                    int edad = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Introduzca el sexo: ");
                    char sexo = Convert.ToChar(Console.ReadLine());

                    Console.WriteLine("Introduzca el Peso: ");
                    double peso = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Introduzca la altura de la persona: ");
                    double altura = Convert.ToDouble(Console.ReadLine());
                

                    //Un objeto por cada constructor
                    Persona persona1 = new Persona();
                    Persona persona2 = new Persona(nombre, edad, sexo);
                    Persona persona3 = new Persona(nombre, edad, sexo, peso, altura);

                    //Los datos que no esten completos los insertamos con los metodos set
                    persona1.setNombre("Robert");
                    persona1.setEdad(32);
                    persona1.setSexo('H');
                    persona1.setPeso(52.32);
                    persona1.setAltura(1.70);

                    persona2.setPeso(90.5);
                    persona2.setAltura(1.80);

                    //Usamos metodos para realizar la misma accion para cada objeto
                    Console.WriteLine("Primera Persona: ");

                    persona1.ValidaPeso(persona1);
                    persona1.MayorDeEdad(persona1);
                    Console.WriteLine(persona1.toString());

                    Console.WriteLine("Segunda Persona: ");

                    persona2.ValidaPeso(persona2);
                    persona2.MayorDeEdad(persona2);
                    Console.WriteLine(persona2.toString());

                    Console.WriteLine("Tercera Persona: ");

                    persona3.ValidaPeso(persona3);
                    persona3.MayorDeEdad(persona3);
                    Console.WriteLine(persona3.toString());

                    break;

                case "Ejercicio 3":

                   
                    Console.WriteLine("Introduce el tamaño de la array: ");

                    int array_taman = Convert.ToInt32(Console.ReadLine());
                  

                    Console.WriteLine("Introduce la longitud de la contraseña: ");
                    int longitud = Convert.ToInt32(Console.ReadLine());

                    //Creamos los arrays

                    Password  [] listaPassword = new Password[array_taman];
                    Boolean [] fortalezaPassword= new Boolean[array_taman];

                    //Creamos objetos, indicamos si es fuerte y mostramos la contraseña y su fortaleza.
                    for (int i = 0; i < listaPassword.Length; i++)
                    {
                        listaPassword[i] = new Password(longitud);
                        fortalezaPassword[i] = listaPassword[i].esFuerte();
                        Console.WriteLine(listaPassword[i].Passw + " " + fortalezaPassword[i]);
                    }

                    break;

                case "Ejercicio 4":

                    double sumaElectrodomesticos = 0;
                    double sumaTelevisiones = 0;
                    double sumaLavadoras = 0;

                    Electrodomestico [] arrayElectro = new Electrodomestico[10];

                    arrayElectro[0] = new Electrodomestico(300, 23.4, 'F', "Rojo");
                    arrayElectro[1] = new Lavadora(150, 30);
                    arrayElectro[2] = new Televisor(500, 80, 'E', "negro", 42, false);
                    arrayElectro[3] = new Electrodomestico();
                    arrayElectro[4] = new Electrodomestico(600, 20, 'D', "gris");
                    arrayElectro[5] = new Lavadora(230, 40, 'Z', "blanco", 40);
                    arrayElectro[6] = new Televisor(150, 70);
                    arrayElectro[7] = new Lavadora(200, 100, 'A', "verde", 15);
                    arrayElectro[8] = new Televisor(110, 60, 'C', "naranja", 30, true);
                    arrayElectro[9] = new Electrodomestico(30, 5);


                    //Recorre la array con el objeto y identifica si es del mismo tipo para sumar
                    for (int i = 0; i < arrayElectro.Length; i++)
                    {

                        if (arrayElectro[i].GetType() == typeof(Electrodomestico)){
                        sumaElectrodomesticos += arrayElectro[i].precioFinal();
                    }
                    if (arrayElectro[i].GetType() == typeof(Lavadora))
                        {
                        sumaLavadoras += arrayElectro[i].precioFinal();
                    }
                    if (arrayElectro[i].GetType() == typeof(Televisor))
                        {
                        sumaTelevisiones += arrayElectro[i].precioFinal();
                    }
            }
                    Console.WriteLine("Suma total Electrodomesticos: {0}",sumaElectrodomesticos);
                    Console.WriteLine("Suma total Lavadoras: {0}", sumaLavadoras);
                    Console.WriteLine("Suma total Televisores: {0}", sumaTelevisiones);


                    break;

                case "Salir":

                    break;

                default:
                    break;
            }
        }


    }
}
