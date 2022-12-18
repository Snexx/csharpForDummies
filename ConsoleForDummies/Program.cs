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
            #region Primer Clase

            //int intValue1 = 2;
            //int intValue2 = 3;
            //string stringValue1 = "2";
            //string stringValue2 = "3";
            //bool boolValue1 = false;
            //bool boolValue2 = true;
            //double doubleValue1 = 3.5;
            //double doubleValue2 = 4.5;
            //char charValue1 = 'k';
            //char charValue2 = 'j';

            ////Como escribir en una consola
            ////Console.WriteLine("hola1");

            ////Como leer en una consola 
            ////Console.ReadLine();

            ////Escribir en una consola la suma de los valores int (crear una variable previa)
            ////int suma1 = intValue1+ intValue2;
            ////Console.WriteLine(suma1);
            ////Console.ReadKey();

            ////Crear un valor de texto, ingresar un numero y crear un campo tipo numero con el
            ////valor ingresado en el texto
            ////string resta1 = "4";
            ////int ej4 = Convert.ToInt32(resta1);
            ////Console.WriteLine(ej4);
            ////Console.ReadKey();

            ////Crear un valor de texto, ingresar un valor Verdadero o falso, y crear un campo tipo bool con
            ////el valor ingresado en el texto
            ////string ej5 = "true";
            ////bool transformacion = Convert.ToBoolean(ej5);
            ////Console.WriteLine(transformacion);


            ////Pedir por consola que ingrese un animal, posteriormente un numero y para finalizar un bool, guardar las 3 variables e
            ////imprimir un texto con los 3 datos registrados por el usuario.

            //Console.WriteLine("ingrese un animal");
            //string animalConsola =  Console.ReadLine();
            //Console.WriteLine("ingrese un numero");
            //string numeroConsola = Console.ReadLine();
            //Console.WriteLine("ingrese un bool");
            //string boolConsola = Console.ReadLine();

            //Console.WriteLine(animalConsola+" "+numeroConsola+" "+boolConsola);

            ////Console.ReadKey();
            #endregion

            ////Arreglo con 4 valores 
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda", "Peras","asffas","asfasf","asfasf"}; //0-1242

            ////Obtener cantidad de valores en numero
            //int valores = cars.Length; //1243

            ////Pedir que ingrese un valor de auto
            //Console.WriteLine("Ingrese un valor de auto");

            ////Valores permitidos
            //Console.WriteLine("Valores permitidos: 1 - " + valores); // ingresal del 1 al 1243
            //int valorR = Convert.ToInt32(Console.ReadLine()); //1243
            //int valorLista = valorR - 1; //1242

            //if (valorR > valores || valorR <= 0) //(1243 > 1243 || 1243 <= 0 ) NO
            //{
            //    Console.WriteLine("Valor NO permitido");
            //}
            //else
            //{
            //    Console.WriteLine(cars[valorLista]); //POSICION DEL ARRAY 1242
            //}

            ////0-1-2-3-4-5
            ////1-2-3-4-5-6

            //Console.ReadKey();

            //string[] numerosEJ1 = new string[4];  //Inicializar sin valores
            //string[] numerosEJ2 = { "", "", "", ""}; //Inicializar sin valores
            //string[] numerosEJ3 = new string[] { "", "", "", "" }; //Inicializar sin valores


            //FOR

            //for (int i = 1; i <= 9; ++i)
            //{
            //    Console.WriteLine("Alumno N°: " + i);
            //    Console.WriteLine("Nombre: ");
            //    Console.WriteLine("Apellido: ");
            //    Console.WriteLine("Edad: ");// Executes 2 times

            //    // Inner loop
            //    for (int j = 1; j <= 4; j++)
            //    {
            //        Console.WriteLine(" Cartola semastral Semestre: " + j);  // Executes 6 times (2 * 3)
            //        for (int n = 1; n <= 10; n++)
            //        {
            //            Console.WriteLine("  Nota n°: " + j);  // Executes 6 times (2 * 3)
            //        }
            //    }
            //    Console.WriteLine(" ");
            //    Console.WriteLine(" ");
            //    Console.WriteLine(" ");
            //}

            //string[] autos = { "Juan", "Pedro", "Rodrigo", "" };
            //Array.Sort(autos);
            //foreach (string auto in autos)
            //{
            //    Console.WriteLine(auto);
            //}

            //#region Continue
            ////Console.WriteLine("Ingrese un numero");
            ////int numerConsola = Convert.ToInt32(Console.ReadLine());


            ////int[] ListaNumeros2 = { 5000, 6000, 9000,12000,7000,15000 };
            ////foreach (int numero in ListaNumeros2)
            ////{

            ////    if (numero <= numerConsola)
            ////    {
            ////        continue;
            ////    }
            ////    Console.Write(" " + numero + " ");
            ////}
            ////Console.Write("For terminado");
            ////Console.ReadKey();
            //#endregion

            //#region Break
            ////int[] ListaNumeros = { 10000, 11000, 9000, 15000 };
            ////foreach (int numero in ListaNumeros)
            ////{
            ////    if (numero < 10000)
            ////    {
            ////        break;
            ////    }
            ////    Console.Write(" " + numero + " ");
            ////}
            ////Console.Write("For terminado");
            //#endregion

            //#region Sort
            ////string[] autosSort = { "Juan", "Pedro", "Rodrigo", "" };
            ////Array.Sort(autosSort);
            //#endregion
            //Console.ReadKey();

            Console.WriteLine("Ingrese Año");
            var año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Mes");
            var mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Dia");
            var dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Hora");
            var hora = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Minutos");
            var minutos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Segundos");
            var segundos = Convert.ToInt32(Console.ReadLine());

            var fechaActual = DateTime.Now;
            var fechaUtcActual = DateTime.UtcNow;

            var fechaDate = new DateTime(año, mes, dia);
            var fechaNacimiento = new DateTime(año, mes, dia, hora, minutos, segundos);

            var mayorEdad = fechaActual.AddYears(-18);
            var fechaHace1Hora = fechaActual.AddHours(-1);
            //Mayor de edad en Chile edad > =  18
            if (fechaNacimiento >= mayorEdad)
            {
                Console.WriteLine("No es mayor de edad");
            }
            //https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
            fechaNacimiento.ToString("dd/MM/yyyy");

            Console.ReadKey();
            
        }
    }
}
