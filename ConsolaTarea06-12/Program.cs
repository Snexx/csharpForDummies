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

            #region Tarea 1 OK

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

            #region Tarea 2 OK

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

            #region Tarea 3 OK
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

            #region Tarea 4 OK
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

            #region Tarea 5 OK
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

            #region Tarea 6 OK
            // Se necesita que el usuario ingrese la cantidad de personas que componen
            // su familia para validar si cumple con los requisitos para el bono, si son mas de 4 integrantes recibe $250000,
            //si son mas de 6 recibe $500000, si no cumple con ninguna de las condiciones no recibe bono


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
            #endregion
            #region Tarea 7 OK
            // se necesita que el usuario ingrese la cantidad de kilos de la maleta, si pesa mas de 21
            // requerira pagar un extra por la maleta, si no puede pasar sin recargo

            // Console.WriteLine("ingrese el peso de su maleta");
            // string peso = Console.ReadLine();
            // double peso1 = Convert.ToDouble(peso);
            // int peso2 = Convert.ToInt32(peso1);

            // if (21>peso2)
            //{
            // Console.WriteLine("no paga extra");
            // }
            // else
            //{
            //Console.WriteLine("paga extra");
            //}


            //Console.ReadKey();
            #endregion

            #region Tarea 8 NOK
            #region Tarea 8

            //solicitar que el usuario ingrese 4 numeros, al finalizar indicar cual de los 4 numeros es el mayor.

            // Console.WriteLine("ingrese 4 numeros");
            //string a = Console.ReadLine();
            //int z = Convert.ToInt32(a);          
            //string s = Console.ReadLine();
            //int x = Convert.ToInt32(s);
            //string d = Console.ReadLine();
            //int c = Convert.ToInt32(d);
            //string f = Console.ReadLine();
            //int v = Convert.ToInt32(f);
            //int retorno = 0;

            //if (z>x)
            //{
            //retorno = z;
            //}
            //else
            //{
            //retorno = x;
            //}

            //if (c > retorno)
            //{
            //retorno = c;

            //}

            //if (v>retorno)

            //{
            //retorno = v;

            //}
            //Console.WriteLine("el numero mayor es " + retorno);



            //Console.ReadKey();

            #endregion



            #region Tarea 9


            // se necesita que el usuario ingrese la cantidad de kilos de la maleta, si pesa mas de 21
            // requerira pagar un extra por la maleta, si no puede pasar sin recargo

            // Console.WriteLine("ingrese el peso de su maleta");
            // string peso = Console.ReadLine();
            // double peso1 = Convert.ToDouble(peso);
            // int peso2 = Convert.ToInt32(peso1);

            // if (21>peso2)
            //{
            // Console.WriteLine("no paga extra");
            //}
            // else
            // {
            //Console.WriteLine("paga extra");
            //}


            //Console.ReadKey();
            #endregion


            #region Tarea 10

            //Se ingresa por teclado un número positivo de uno o dos dígitos (1 al 99) mostrar un mensaje indicando si el número tiene uno o dos dígitos.

            //Console.WriteLine("ingrese 2 numeros del 1 al 99");
            //Console.WriteLine("numero 1");
            // string primero = Console.ReadLine();
            //int primernumero = Convert.ToInt32(primero);


            //if (primernumero >= 10)
            // {
            //Console.WriteLine("este numero tiene dos digitos");
            //}
            // else
            // {
            // Console.WriteLine("este numero tiene un digito");
            //}


            //Console.ReadKey();
            #endregion

            #region Tarea 11
            //Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo informar su suma y diferencia,
            //en caso contrario informar el producto y la división del primero respecto al segundo.

            // Console.WriteLine("ingrese 2 numeros");
            // Console.WriteLine("numero 1");
            // string numero1 = Console.ReadLine();
            // int x = Convert.ToInt32(numero1);
            // Console.WriteLine("numero 2");
            // string numero2 = Console.ReadLine();
            // int y = Convert.ToInt32(numero2);
            // int suma = x + y;
            // int resta = x - y;
            // int multiplicar = x * y;
            // double division = Convert.ToDouble(y) / Convert.ToDouble(x);
            // para division convertir los valores a double.


            // if (x>y)
            // {
            // Console.WriteLine("el primer numero es mayor, su suma es " + suma);
            // Console.WriteLine("su diferencia es de " + resta +" numeros");
            //}
            // else 
            //{
            //Console.WriteLine("el segundo numero es mayor, su multiplicacion es de " + multiplicar);
            //Console.WriteLine("su division es de " + division);
            // }

            //Console.ReadKey();

            #endregion

            #region Tarea 12

            //Cree un programa que valide si el número ingresado es par o impar
            // hice un pete por esta respuesta.

            //Console.WriteLine("ingrese un numero, este se validara si es par o impar");
            //string numero1 = Console.ReadLine();
            //int x = Convert.ToInt32(numero1);

            //if ((x%2)==0)   
            // {
            //Console.WriteLine("es un numero par");

            //}
            //else
            //{
            //Console.WriteLine("este numero es impar");

            //}

            //Console.ReadKey();


            #endregion

            #region Tarea 13
            //Cree un programa que permita saber, en base a la nota final del curso de un alumno, si ha aprobado o ha desaprobado.
            //Si la nota es mayor que 4, el alumno ha aprobado, en caso contrario, ha desaprobado.

            //Console.WriteLine("Ingrese nota");
            //    string nota = Console.ReadLine();
            //    double final = Convert.ToDouble(nota);

            //if (final >= 4)
            //    {
            //        Console.WriteLine("aprueba");
            //    }
            //else
            //    {
            //        Console.WriteLine("no aprueba");

            //    }




            //    Console.ReadKey();
            #endregion

            #region Tarea 14

            //Cree un programa que solicite al usuario el lado de un cuadrado.
            //Luego le debe pedir una opción al usuario, si elige 1, le debe mostrar el perímetro del cuadrado, si elige 2, le debe mostrar el área del cuadrado.

            //Console.WriteLine("ingrese un lado del cuadrado");
            //double lado = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("ingrese opcion 1 para perimetro o 2 para area");
            //int opcion = Convert.ToInt32(Console.ReadLine());

            //if(opcion==1 )
            //{
            //    Console.WriteLine("el primetro del cuadrado es " + lado * 4);
            //}
            //else if (opcion==2)
            //{
            //    Console.WriteLine("el area del cuadrado es " + lado * lado);
            //}
            //else
            //{
            //    Console.WriteLine("opcion no valida");
            //}

            //Console.ReadKey();

            #endregion

            #region Tarea 15
            //Cree un programa que solicite la siguiente información: Nombre, sexo, cantidad de hijos y monto total de compra.
            //En base a esa información, se debe realizar lo siguiente. Si el cliente es hombre y no tiene hijos, le debes aplicar un descuento de 2.5% al monto total de compra.
            //Si tiene 1 a más hijos, debes aplicarle un descuento de 5% al monto de compra.
            //Si es mujer y no tiene hijo, debe aplicarle 10% de descuento, si tiene 1 o 2, debes aplicar 15% de descuento y si tiene 3 a más hijos, debes aplicar el 20% de descuento a la compra.
            //El programa debe imprimir «Señor», «Señorita» o «Señora» respectivamente y su nombre. La mujer es señorita si no tiene hijos. Además debe imprimir el subtotal, el descuento y el monto final de compra

            //Console.WriteLine("ingrese los siguientes datos");
            //Console.WriteLine("Nombre");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("M para masculino, F para femenino");
            //string sexo = Console.ReadLine();
            //Console.WriteLine("ingrese cantidad de hijos");
            //int cantidadHijos = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("ingrese total de compra");
            //int montoTotal = Convert.ToInt32(Console.ReadLine());
            //double descuento ;
            //double total;

            //if (sexo=="M"&& cantidadHijos==0)
            //{
            //    Console.WriteLine("Señor " + nombre);
            //    Console.WriteLine("subtotal = $" + montoTotal);
            //    descuento = 0.025;
            //    Console.WriteLine("su descuento es de: %" + (descuento * 100));
            //    total = montoTotal - (montoTotal * descuento);
            //    Console.WriteLine("su total es = $" + total );

            //}
            //else if (sexo == "M" && cantidadHijos>0)
            //{
            //    Console.WriteLine("Señor " + nombre);
            //    Console.WriteLine("subtotal = $" + montoTotal);
            //    descuento = 0.05;
            //    Console.WriteLine("su descuento es de: %" + (descuento * 100));
            //    total = montoTotal - (montoTotal * descuento);
            //    Console.WriteLine("su total es = $" + total);
            //}
            //else if (sexo == "F" && cantidadHijos==0)
            //{
            //    Console.WriteLine("Señorita " + nombre);
            //    Console.WriteLine("subtotal = $" + montoTotal);
            //    descuento = 0.1;
            //    Console.WriteLine("su descuento es de: %" + (descuento * 100));
            //    total = montoTotal - (montoTotal * descuento);
            //    Console.WriteLine("su total es = $" + total);
            //}
            //else if (sexo == "F" && (cantidadHijos==1 ||cantidadHijos==2))
            //{
            //    Console.WriteLine("Señora " + nombre);
            //    Console.WriteLine("subtotal = $" + montoTotal);
            //    descuento = 0.15;
            //    Console.WriteLine("su descuento es de: %" + (descuento * 100));
            //    total = montoTotal - (montoTotal * descuento);
            //    Console.WriteLine("su total es = $" + total);
            //}
            //else if (sexo == "F" && cantidadHijos > 2)
            //{
            //    Console.WriteLine("Señora " + nombre);
            //    Console.WriteLine("subtotal = $" + montoTotal);
            //    descuento = 0.2;
            //    Console.WriteLine("su descuento es de: %" + (descuento*100));
            //    total = montoTotal - (montoTotal * descuento);
            //    Console.WriteLine("su total es = $" + total);



            //}

            //Console.ReadKey();
            #endregion

            #region Tarea 16

            ////Cree un programa que lea 5 notas, calcule el promedio e imprima si aprobó o reprobó(promedio > 4 = aprobó)

            //Console.WriteLine("ingrese notas");
            //Console.WriteLine("ingrese nota 1");
            //double nota1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("ingrese nota 2");
            //double nota2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("ingrese nota 3");
            //double nota3 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("ingrese nota 4");
            //double nota4 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("ingrese nota 5");
            //double nota5 = Convert.ToDouble(Console.ReadLine());
            //double promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

            //if (promedio>=4)
            //{
            //    Console.WriteLine ("aprueba con "+promedio );

            //}
            //else
            //{
            //    Console.WriteLine("fracaste con "+promedio);
            //}


            //Console.ReadKey();

            #endregion

            #region Tarea 17
            //Cree un programa que lea los 3 lados de un triangulo y nos diga si es Equilátero, Isósceles o Escaleno

            //Console.WriteLine("ingrese 3 valores para el triangulo");
            //Console.WriteLine("lado 1");
            //double valor1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("lado 2");
            //double valor2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Lado 3");
            //double valor3 = Convert.ToDouble(Console.ReadLine());

            //if (valor1 == valor2 && valor1 == valor3)
            //{
            //    Console.WriteLine("corresponde a equilatero");
            //}
            //else if (valor1 == valor2 || valor1 == valor3 || valor2 == valor3)
            //{
            //    Console.WriteLine("corresponde a isosceles");
            //}
            //else
            //{
            //    Console.WriteLine("corresponde a Escaleno");
            //}


            //Console.ReadKey();

            #endregion

            #region Tarea 18

            //Cree un programa que permita ingresar una vocal y te devuelva una palabra que empiece por esa vocal. 

            //Console.WriteLine("ingrese una vocal");
            //string vocal = Console.ReadLine();
            //switch (vocal)
            //{
            //    case "A":
            //        Console.WriteLine("action maaaan");
            //        break;

            //    case "E":
            //        Console.WriteLine("Estoy harto");
            //        break;

            //    case "I":
            //        Console.WriteLine("i need sushi");
            //        break;

            //    case "O":
            //        Console.WriteLine("orto");
            //        break;

            //    case "U":
            //        Console.WriteLine("uuuuuranai baba");
            //        break;

            //    default:
            //        Console.WriteLine("el paulo me manda sushi");
            //        break;
            //}
            // Console.ReadKey();



            #endregion
            #region Tarea 19
            //Cree un programa que permita ingresar una de las estaciones del año y te devuelva el rango de fechas de su duración(de tu país). Validar que ingrese una estación válida.

            //Console.WriteLine("inserte una estacion del año");
            //string estacion = Console.ReadLine();
            //switch (estacion)
            //{
            //    case "VERANO":
            //        Console.WriteLine("desde el 21 de Diciembre solsticio al 20 de Marzo equinoccio");
            //        break;
            //    case "OTOÑO":
            //        Console.WriteLine("desde el 20 de Marzo equinoccio al 21 de Junio solsticio");
            //        break;
            //    case "INVIERNO":
            //        Console.WriteLine("desde el 21 de Junio al 20 solsticio de 21 de Septiembre equinoccio");
            //        break;
            //    case "PRIMAVERA":
            //        Console.WriteLine("desde el 21 de Septiembre equinoccio al 21 de Diciembre solsticio");
            //        break;
            //    default:
            //        Console.WriteLine("el paulo me manda sushi");
            //         break;
            //}
            //Console.ReadKey();
            #endregion



        }






    }
}


