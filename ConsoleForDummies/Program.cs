using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForDummies
{
    class Program
    {
        //Consola principal
        static void Main(string[] args)
        {

            int intValue1 = 2;
            int intValue2 = 3;
            string stringValue1 = "2";
            string stringValue2 = "3";
            bool boolValue1 = false;
            bool boolValue2 = true;
            double doubleValue1 = 3.5;
            double doubleValue2 = 4.5;
            char charValue1 = 'k';
            char charValue2 = 'j';

            //Como escribir en una consola
            //Console.WriteLine("hola1");

            //Como leer en una consola 
            //Console.ReadLine();

            //Escribir en una consola la suma de los valores int (crear una variable previa)
            //int suma1 = intValue1+ intValue2;
            //Console.WriteLine(suma1);
            //Console.ReadKey();

            //Crear un valor de texto, ingresar un numero y crear un campo tipo numero con el
            //valor ingresado en el texto
            //string resta1 = "4";
            //int ej4 = Convert.ToInt32(resta1);
            //Console.WriteLine(ej4);
            //Console.ReadKey();

            //Crear un valor de texto, ingresar un valor Verdadero o falso, y crear un campo tipo bool con
            //el valor ingresado en el texto
            //string ej5 = "true";
            //bool transformacion = Convert.ToBoolean(ej5);
            //Console.WriteLine(transformacion);


            //Pedir por consola que ingrese un animal, posteriormente un numero y para finalizar un bool, guardar las 3 variables e
            //imprimir un texto con los 3 datos registrados por el usuario.

            Console.WriteLine("ingrese un animal");
            string animalConsola =  Console.ReadLine();
            Console.WriteLine("ingrese un numero");
            string numeroConsola = Console.ReadLine();
            Console.WriteLine("ingrese un bool");
            string boolConsola = Console.ReadLine();

            Console.WriteLine(animalConsola+" "+numeroConsola+" "+boolConsola);

            //Console.ReadKey();
        }
    }
}
