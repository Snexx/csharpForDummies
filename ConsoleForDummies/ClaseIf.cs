using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForDummies
{
    public class ClaseIf
    {
        int a, b, c;

        public void EjemplosIf(){
            //Menor que: a < b
            //Menor o igual que: a <= b
            //Mayor que: a > b
            //Mayor o igual que: a >= b
            //Igual a a == b
            //No es igual a: a != b
            a = 5;
            b = 10;
            c = 20;

            //sintaxis if
            if (a < b)
            {
                Console.WriteLine("A es menor que B");
            }

            //sintaxis If Else si
            if (b > c)
            {
                Console.WriteLine("B es mayor que C");
            }
            else
            {
                Console.WriteLine("B NO es mayor que C");
            }

            if(a > c)
            {
                Console.WriteLine("A es mayor que C");
            }else if (b < c)
            {
                Console.WriteLine("B es menor que C");
            }



        }
    }
}
