using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaTarea06_12
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Tarea 1

            //1. Escribir el siguiente texto por consola ("Hola, tenemos que trabajar!")

            //2. Escribir por consola al usuario para que ingrese el nombre de un pais

            //3. Guardar la respuesta del usuario en una variable

            //4. Escribir por consola al usuario que ingrese un año

            //5. Guardar la respuesta del usuario en una variable

            //6. Al año ingresado por el usuario agregar 50

            //6. Escribir por consola al usuario el usuario el nuevo año y el pais que ingreso.

            //Console.WriteLine("Hola, tenemos que trabajar");
            // Console.WriteLine("ingrese un pais");
            // string pais = Console.ReadLine();
            // Console.WriteLine(pais);
            // Console.WriteLine("ingrese un año");
            // string año = Console.ReadLine();
            // int fecha = Convert.ToInt32(año);
            // Console.WriteLine(fecha);
            // int valor = 50;
            //int total = fecha + valor;
            // Console.WriteLine("señor usuario el nuevo año es " + total + " y el pais " + pais);

            // Console.ReadKey();


            #endregion

            #region Tarea 2

            //1. Escribir el siguiente texto por consola ("Ejercicio Numero 2, Let's GO")

            //2. Escribir por consola al usuario para que ingrese su nombre, segundo nombre, apellido paterno, apellido materno

            //3. Guardar las respuesta del usuario.

            //4. Darle la bienvenida al usuario con su nombre completo

            //Console.WriteLine("Ejercicio Numero 2, Let's GO");
            //Console.WriteLine("ingrese su nombre");
            //string nombre = Console.ReadLine();
            // Console.WriteLine("ingrese su apellido paterno");
            // string apellidopaterno = Console.ReadLine();
            // Console.WriteLine("ingrese su apellido materno");
            // string apellitomaterno = Console.ReadLine();
            //  Console.WriteLine("bienvenido " + nombre+" " + apellidopaterno+" " + apellitomaterno);


            //Console.ReadKey();

            #endregion

            #region Tarea 3
            // Se necesita que una consola solicite al usuario 3 numeros, los primeros 2 numeros deben sumarse y el 3 resta al valor total,
            // por pantalla se debe imprimir la suma de los 2 primeros valores y tambien el resultado final al restar el 3.
            //solicita 3 numeros
            //primeros 2 sumar
            //3 restar 3 a los otros dos
            //imprimir

            //Console.WriteLine("Favor ingrese 3 numeros, los primeros 2 seran sumados y el tercero realizara una resta");
           //string numero1 = Console.ReadLine();
            //int valor1 = Convert.ToInt32(numero1);
            //Console.WriteLine(valor1);
           // string numero2 = Console.ReadLine();
            //int valor2 = Convert.ToInt32(numero2);
            //int suma = valor1 + valor2;
            //Console.WriteLine(suma);
            //string numero3 = Console.ReadLine();
            //int valor3 = Convert.ToInt32(numero3);
            //Console.WriteLine(valor3);
            //Console.WriteLine(suma - valor3);

            
           //Console.ReadKey();
            #endregion


            #region Tarea 4
            //Se necesita que el usuario registre un nombre completo, contraseña, edad y nickname, hacer un formulario basico por consola para consultar estos valores.
            //Estos valores deben ser impresos en pantalla al final en el orden ingresado.

            Console.WriteLine("Favor rellene este formulario");
            Console.WriteLine("Nombre completo");
            string nombre = Console.ReadLine();
            Console.WriteLine("ingrese su contraseña");
            string contraseña = Console.ReadLine();
            Console.WriteLine("edad");
            string edad = Console.ReadLine();
            int valor = Convert.ToInt32(edad);
            Console.WriteLine("ingrese su nickname");
            string nick = Console.ReadLine();
            Console.WriteLine("su nombre es " + nombre + " su contraseña " + contraseña + " su edad " + edad + " y su nickname " + nick);

            Console.ReadKey();

            #endregion




        }
    }
}
