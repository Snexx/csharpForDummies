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

            #region Tarea 16 Promedio de notas

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

            #endregion  //Promedio de notas

            #region Tarea 17 verifica triangulo en base a sus lados
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

            #region Tarea 18 ejercicio switch

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

            #region Tarea 20 primeros 100 numeros de un array
            //Realiza un programa en C#, que muestre los primeros 100 números enteros iniciando desde el 1.



            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadKey();
            #endregion

            #region Tarea 21 Forma Inversa de numeros
            //Realiza un programa en C#, que muestre los primeros 100 números de forma inversa, es decir, del 100 al 1

            //for (int i = 100; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadKey();

            #endregion

            #region Tarea 22 Numeros pares del 1 al 100
            //Realiza un programa en C#, que muestre únicamente, los números pares en el rango del 1 al 100

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i%2==0)
            //    {
            //        Console.WriteLine(i + " es numero par");
            //    }
            //}

            //Console.ReadKey();


            #endregion

            #region Tarea 23 Suma del 1 al 100
            //Realiza un programa en C#, que muestre la suma de los números del 1 al 100

            //int suma = 0;


            //for (int i = 1; i <= 100; i++)
            //{
            //    suma = suma + i;

            //}
            //Console.WriteLine(suma);

            //Console.ReadKey();

            #endregion

            #region Tarea 23 Multiplicacion del 1 al 10
            //Realiza un programa en C#, que muestre la multiplicacion de los números del 1 al 10
            //int multiplicacion = 1;

            //for (int i = 1; i <= 10; i++)
            //{
            //    multiplicacion = multiplicacion * i;
            //}

            //Console.WriteLine(multiplicacion);

            //Console.ReadKey();

            #endregion

            #region Tarea 24 creacion de string

            //string[] animales = { "perro", "oso", "panda", "lobo" };
            //foreach (var animal in animales)
            //{
            //    Console.WriteLine(animal);
            //}
            //Console.WriteLine(animales.Length);

            //Console.ReadKey();
            #endregion

            #region Tarea 25 array de 10 posiciones
            //Crea un array de 10 posiciones, pide los valores por consola y muestra el array.
            //int[] posiciones = new int[10];

            //for (int i = 0; i < posiciones.Length; i++)
            //{
            //    Console.WriteLine("ingrese un valor en la posicion" + i);
            //   int posicion= Convert.ToInt32(Console.ReadLine());
            //    posiciones[i] = posicion;
            //}
            //foreach (var posicion in posiciones)
            //{
            //    Console.WriteLine(posicion);
            //}


            //Console.ReadKey();

            #endregion

            #region Tarea 26 array de posiciones

            //1.Crea un array de 10 posiciones, con valores puestos por ti y muestra el array.


            //int[] lugares = {1, 4, 5,7,2,3,6,9,10,8 };
            //foreach (var lugar in lugares)
            //{
            //    Console.WriteLine(lugar);

            //}

            //Console.ReadKey();
            #endregion

            #region Tarea 27 array de posiciones, imprimidos en consola

            //2.Crea un array de 10 posiciones, pide los valores por consola y muestra el array

            //int[] posiciones = new int[10];
            //for (int i = 0; i < posiciones.Length; i++)
            //{
            //    Console.WriteLine("ingrese un valor en la posicion" + i);

            //    int posicion = Convert.ToInt32(Console.ReadLine());
            //    posiciones[i] = posicion;
            //}
            //foreach (var posicion in posiciones)
            //{
            //    Console.WriteLine(posicion);
            //}
            //Console.ReadKey();
            #endregion

            #region Tarea 28 suma valores de un array
            //3.	Sumar los valores de un array y mostrar el resultado.

            //int[] valores = { 1, 4, 5, 7, 2, 3, 6, 9, 10, 8 };
            //int suma = 0;

            //for (int i = 1; i < valores.Length; i++)
            //{
            //    suma = suma + valores[i];
            //}
            //Console.WriteLine(suma);

            //Console.ReadKey();

            #endregion

            #region Tarea 29 Promedio de un array
            //-Hacer la media de los valores de un array y mostrar el resultado.
            //int[] valores = { 1, 4, 5, 7, 2, 3, 6, 9, 10, 8 };
            //int suma = 0;
            //double promedio = 0;

            //for (int i = 0; i < valores.Length; i++)
            //{
            //    suma = suma + valores[i];


            //}
            //promedio = Convert.ToDouble(suma) / Convert.ToDouble(valores.Length);
            //Console.WriteLine(promedio);


            //Console.ReadKey();
            #endregion

            #region Tarea 30
            //Pedir un numero por teclado y multiplicar todos los valores de un array.
            //int[] multi = { 1, 4, 5, 7, 2, 3, 6, 9, 10, 8 };
            //int multiplo = Convert.ToInt32(Console.ReadLine());


            //for (int i = 0; i < multi.Length; i++)
            //{

            //    var resultado = multiplo * multi[i];
            //    Console.WriteLine(resultado);

            //}



            //Console.ReadKey();

            #endregion

            #region Tarea 31
            // Dado un array de números con el método sort, ordenalos y muestra su contenido.
            //int[] valores = { 1, 4, 5, 7, 2, 3, 6, 9, 10, 8 };
            //Array.Sort(valores);

            //for (int i = 0; i < valores.Length; i++)
            //{
            //    Console.WriteLine(valores[i]);
            //}


            //Console.ReadKey();

            #endregion

            #region Tarea 32
            //Dado un array de números, muestra el mayor y el menor.
            //int[] valores = { 1, 4, 5, 7, 2, 3, 6, 9, 10, 8 };
            //Array.Sort(valores);
            //Console.WriteLine(" el valor minimo es : " + valores [0]);
            //Console.WriteLine(" el valor mayor es : " + valores[valores.Length - 1]);

            //Console.ReadKey();
            #endregion

            #region Tarea 33
            //Genera dos arrays con valores aleatoreos e indica cuantos valores coinciden, si aciertas 3 o mas se mostrará un mensaje de felicitaciones.

            //Random r = new Random();
            //int longitud = 10;
            //int coincidencias = 0;
            //int[] valores1 = new int[longitud];
            //int[] valores2 = new int[longitud];
            //int[] valores3 = new int[longitud];

            //for (int i = 0; i < valores1.Length; i++)
            //{
            //    valores1[i] = r.Next(1, 50);
            //    Console.WriteLine(valores1[i]);
            //}
            //for (int i = 0; i < valores2.Length; i++)
            //{
            //    valores2[i] = r.Next(1, 50);
            //    Console.WriteLine(valores2[i]);
            //}
            //for (int i = 0; i < valores1.Length; i++)
            //{
            //    for (int j = 0; j < valores2.Length; j++)
            //    {
            //        if (valores1[i] == valores2[j])
            //        {
            //            bool existe = false;
            //            for (int k = 0; k < coincidencias; k++)
            //            {
            //                if (valores3[k] == valores1[i])
            //                {
            //                    existe = true;
            //                }
            //            }
            //            if (!existe)
            //            {
            //                valores3[coincidencias] = valores1[i];
            //                coincidencias++;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine("Coincidencias");
            //for (int i = 0; i < valores3.Length; i++)
            //{
            //    Console.WriteLine(valores3[i]);
            //}
            //if (coincidencias>=3)
            //{
            //    Console.WriteLine("Ganaste ctm toma un sushi");
            //}
            //else
            //{
            //    Console.WriteLine("perdiste ctm toma un sushi");
            //}


            //Console.ReadKey();
            #endregion

            #region Tarea 34
            //dado un string ingresado por consola, imprimir el string al revés ej: auto -> otua
            //string val1 = "Auto";
            //char[] val2 = val1.ToCharArray();
            //Array.Reverse(val2);
            //string val3 = new string(val2);
            //Console.WriteLine(val3);


            //Console.ReadKey();
            #endregion

            #region Tarea 35
            //dado un string ingresado por consola, calcular el numero de vocales y consonantes
            // Console.WriteLine(" ingrese sushi");
            //string val1 = Console.ReadLine().ToUpper().Trim();
            // char[] val2 = val1.ToCharArray();
            // int vocales = 0;
            // int consonante = 0;

            // for (int i = 0; i < val2.Length; i++)
            // {
            //     if (val2[i] == 'A'|| val2[i] == 'E' || val2[i] == 'I' || val2[i] == 'O' || val2[i] == 'U')
            //     {
            //         vocales++; 
            //     }
            //     //else if (val2[i] == ' ')
            //     //{
            //     //    continue;
            //     //}
            //     else
            //     {
            //         consonante++;
            //     }

            // }
            // Console.WriteLine($"el numero de vocales es : {vocales} y las consonantes son {consonante}");

            // Console.ReadKey();
            #endregion

            #region Tarea 36
            //dado un string ingresado por consola, validar si el string es un palíndromo(se lee al derecho y revés de la misma manera) ej: narran
            //Console.WriteLine("ingrese una palabra");
            //string val1 = Console.ReadLine();
            //char[] val2 = val1.ToCharArray();
            //Array.Reverse(val2);
            //string val3 = new string(val2);    

            //if (val1==val3)
            //{
            //    Console.WriteLine("es un palindromo");
            //}
            //else
            //{
            //    Console.WriteLine("no es un palindromo");
            //}


            //Console.ReadKey();
            #endregion

            #region Tarea 37 desde aqui ta listo
            //Dado un string ingresado por consola, imprime el numero de letras que contiene
            //solicita un texto a cliente
            // imprime la cantidad de letras,no contar espacios.

            //Console.WriteLine("ingrese una frase o texto");
            //string val1 = Console.ReadLine();
            //val1 = val1.Replace(" " , "");

            //Console.WriteLine($" la cantidad de letras ingresadas son: {val1.Length}");

            //Console.ReadKey();

            #endregion

            #region Tarea 38
            //dado un string ingresado por consola, imprime los caracteres por separado ej: hola = h o l a
            //Console.WriteLine("ingrese una frase o texto");
            //String frase = Console.ReadLine();
            //char[] frases = frase.ToCharArray();


            //Console.ReadKey();

            #endregion

            #region Tarea 39 jojojo aca

            //dado 2 string ingresado por consola, indica si ambos strings son iguales

            //string mensaje1 = Console.ReadLine();
            ////char[] mensajes1 = mensaje1.ToCharArray();
            //string mensaje2 = Console.ReadLine();
            ////char[] mensajes2 = mensaje2.ToCharArray();

            //if (mensaje1 == mensaje2)
            //{
            //    Console.WriteLine("son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("no son iguales");
            //}

            //Console.ReadKey();
            #endregion

            #region Tarea 40 trabajando  tamos listos

            //dado un string ingresado por consola, imprimelo en orden de abc
            //string frase = "chupapi kasjdkasd";
            //char[] frases = frase.ToCharArray();
            //Array.Sort(frases);

            //Console.WriteLine(frases);


            //Console.ReadKey();
            #endregion

            #region Tarea 41
            //dado un string, calcular el numero de palabras "NO"
            //string palabra = Console.ReadLine();
            //// transformar el texto en un arreglo de caracteres
            //char[] caracteres = palabra.ToCharArray();
            ////definir un contador de palabras
            //// contador debe partir con 1
            //int contador = 1;
            //// recorrer el arreglo de caracter y definir si es un espacio, un salto de linea o un tab.
            //foreach (var caracter in caracteres)
            //{
            //    if (caracter==' ' || caracter=='\n' || caracter== '\t')
            //    {
            //        contador++;
            //    }
            //}


            //// imprimir cantidad de palabras
            //Console.WriteLine($"la catidad de palabras escritas es: {contador}");

            //Console.ReadKey();
            #endregion

            #region Tarea 42
            //dado un string ingresado por consola, la cantidad de letras, cantidad de números y cantidad de caracteres especiales
            //string msjUsuario = Console.ReadLine();
            //// transformar texto en un arreglo char
            //char[] caracteres = msjUsuario.ToCharArray();
            ////definir contadores
            //int letra = 0;
            //int numero = 0;
            //int especial = 0;
            ////recorrer el arreglo para definir contadores
            //foreach (var caracter in caracteres)
            //{
            //    if ((caracter>= 'a'&& caracter <='z')||(caracter >= 'A' && caracter <= 'Z'))
            //    {
            //        letra++;
            //    }
            //    else if (caracter>='0' && caracter<='9')
            //    {
            //        numero++;
            //    }
            //    else 
            //    {
            //        especial++;
            //    }

            //}
            //Console.WriteLine($"La cantidad de letras en el texto es de {letra} la cantidad de numeros {numero} y la cantidad de caracteres especiales es de {especial}");

            //Console.ReadKey();
            //imprimir valores

            #endregion

            #region Tarea 43
            //  dado un string ingresado por consola, transforma las minúsculas en mayúsculas y viceversa "NO"
            // ingresa un texo
            //string textoUser = Console.ReadLine();
            //char[] textos = textoUser.ToCharArray();
            
            ////transformar minusculas en mayusculas

            //foreach (var texto in textos)
            //{
            //    if (texto >= 'a' && texto <= 'z')
            //    {
            //        Console.Write(Char.ToUpper(texto));
                    
            //    }
            //    else if ((texto >= 'A' && texto <= 'Z'))
            //    {
            //        Console.Write(Char.ToLower(texto));
            //    }
            //    else 
            //    {
            //        Console.Write(texto);
            //    }
            //}


            //Console.ReadKey();
            //transformar mayusculas en minusculas

            // imprimir el texto

            #endregion
        }



    }
}
