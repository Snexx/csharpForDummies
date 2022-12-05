using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            //1.- Crear variables para asignar nombres y apellidos
             string nombre1 = "";
             string apellido1 = "";


            //Solicitar nombres y apellidos y guardarlos en los valores previamente creados.
            //Console.WriteLine("ingrese nombre");
            //nombre1 = Console.ReadLine();
            //Console.WriteLine("ingrese apellido");
            //apellido1 = Console.ReadLine();





            //Imprimir resultado (Apellidos + nombre)
            //Console.WriteLine("Su nombre ordenado por apellidos es: ");

            //Console.WriteLine(apellido1 + " " + nombre1);


            //Console.ReadKey();


            //2


            //Crear una consola que solicite el valor faltante y que imprima el resultado
            //const int firstInt = 15;
            //Console.WriteLine("Que numero sumado a " + firstInt + " da 20");
            //CODIGO AQUI 
            //Console.WriteLine("ingrese numero");
            //string numero1 = Console.ReadLine();
            //int numero2 = Convert.ToInt32(numero1);
            //Console.WriteLine(numero2 + firstInt);





            //Imprimir respuesta final
            //Console.WriteLine("El numero es: ");

            //Console.ReadKey();



            //Ejercicio 3

            //1.- Crear una consola que tenga un texto inicial de bienvenida

            //2.- Crear un valor fijo del 1 al 9

            //3.- escribir en consola el siguiente texto "Su numero de la suerte es" y adicionar el numero creado

            //4.- Crear una variable  con el valor faltanta para llegar a 7777 (Ej. valor inicial = 0 + 7777, valor faltante 7777)
            //Este valor no puede ser ingresado manualmente (ej. (int number2 = 7777))

            //5.- Imprimir un texto que indique el numer faltante
            //string saludo= "bienvenido";
            //Console.WriteLine(saludo);
            //int ej4 = 9;
            // string suerte = "su numero de la suerte es";
            // Console.WriteLine(suerte + " " + ej4);
            // int resta1 = 7777-ej4;
            // Console.WriteLine(resta1);
            // Console.WriteLine(ej4 + resta1);


            // Console.ReadKey();





            //Ejercio 4

            //1.- Crear una consola que tenga un texto inicial de bienvenida, que solicite 2 numeros (el 2 numero debe solictar
            //que sea mayor que el primero) y guardar ambas respuestas en variables de tipo numero, posteriormente debe indicar
            //por cuanto es mayor el numero 2 en referencia al numero 1 e imprimirlo en pantalla.

            // 
            // saludar
            // solicitar 2 numeros, el segundo mayor
            //guardar variables de int
            //restar el 1 y 2 y ejecutar

            Console.WriteLine("bienvenido");
            string texto0 = "ingrese un numero";
            Console.WriteLine(texto0);
            string texto1 = Console.ReadLine();
            int numero1 = Convert.ToInt32(texto1);
            Console.WriteLine(numero1);
            string valor = "ingrese un valor superior al primero";
            Console.WriteLine(valor);
            string texto2 = Console.ReadLine();
            int numero2 = Convert.ToInt32(texto2);
            int numer3 = numero2 - numero1;
            Console.WriteLine("el numero: "+numero2+" es mayor por "+numer3);





            Console.ReadKey();
        }
    }
}
