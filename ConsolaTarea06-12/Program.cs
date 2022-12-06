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

            //Console.WriteLine("Favor rellene este formulario");
            // Console.WriteLine("Nombre completo");
            // string nombre = Console.ReadLine();
            // Console.WriteLine("ingrese su contraseña");
            //string contraseña = Console.ReadLine();
            // Console.WriteLine("edad");
            // string edad = Console.ReadLine();
            // int valor = Convert.ToInt32(edad);
            // Console.WriteLine("ingrese su nickname");
            // string nick = Console.ReadLine();
            // Console.WriteLine("su nombre es " + nombre + " su contraseña " + contraseña + " su edad " + edad + " y su nickname " + nick);

            // Console.ReadKey();

            #endregion

            #region Tarea 5
            // Se necesita que el usuario ingrese su edad y se valide si es mayor de edad

            //Console.WriteLine("ingrese su edad");
            // string cliente   = Console.ReadLine();
            // int edad1 = Convert.ToInt32(cliente);
            // int x = 18;

            //if (edad1 > x) 
            // {
            //Console.WriteLine("es mayor de edad");

            // }
            //  else
            // {
            // // Console.Write("no es mayor de edad");
            //}

            // Console.ReadKey();








            #endregion

            #region Tarea 6
            // Se necesita que el usuario ingrese la cantidad de personas que componen
            // su familia para validar si cumple con los requisitos para el bono, si son mas de 4 integrantes recibe $250000,
            //si son mas de 6 recibe $500000, si no cumple con ninguna de las condiciones no recibe bono
            #endregion

            //Console.WriteLine("ingrese la cantidad de personas que componen su familia");
            //string personas = Console.ReadLine();
            //int cantidad = Convert.ToInt32(personas);

            // if (cantidad > 4 && cantidad <=6)
            //{
            // Console.WriteLine("grupo apto para bono de 250000");

            // }
            // else if (cantidad>6)
            // {
            // Console.WriteLine("grupo apto para bono de 500000");
            //  }
            //else
            // {
            //Console.WriteLine("no cumple con los requisitos");
            // }

            //Console.ReadKey();

            #region Tarea 7
            // se necesita que el usuario ingrese la cantidad de kilos de la maleta, si pesa mas de 21
            // requerira pagar un extra por la maleta, si no puede pasar sin recargo

            // Console.WriteLine("ingrese el peso de su maleta");
            // string peso = Console.ReadLine();
            // double peso1 = Convert.ToDouble(peso);
            // int peso2 = Convert.ToInt32(peso1);

            // if (21>peso2)
            {
                // Console.WriteLine("no paga extra");
            }
            // else
            {
                //Console.WriteLine("paga extra");
            }


            //Console.ReadKey();
            #endregion

            #region Tarea 8
            //solicitar que el usuario ingrese 4 numeros, al finalizar indicar cual de los 4 numeros es el mayor.

            Console.WriteLine("ingrese 4 numeros");
            string a = Console.ReadLine();
            int z = Convert.ToInt32(a);          
            string s = Console.ReadLine();
            int x = Convert.ToInt32(s);
            string d = Console.ReadLine();
            int c = Convert.ToInt32(d);
            string f = Console.ReadLine();
            int v = Convert.ToInt32(f);
            int retorno = 0;

            if (z>x)
            {
                retorno = z;
            }
            else
            {
                retorno = x;
            }

            if (c > retorno)
            {
                retorno = c;

            }

            if (v>retorno)

            {
                retorno = v;
                
            }
            Console.WriteLine("el numero mayo es " + retorno);



            Console.ReadKey();

            #endregion


        }
    }
}
