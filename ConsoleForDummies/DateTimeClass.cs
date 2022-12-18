using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForDummies
{
    public  class DateTimeClass
    {

        public void datetimeExample()
        {
            //DATE = SOLO FECHA  año, mes y dia
            //DateTime fechaNacimiento = new DateTime(2000, 4, 16);

            //Time = horas, minutos , segundos y milisegundos

            //datetime = años, mes , dia , horas , minutos , segundos y milisegundos
            //DateTime fechaNacimientoConHora = new DateTime(2000,4,16,12,12,12);

            //DateTime fechaActual = DateTime.Now;

            //DateTime fechaNacimiento = new DateTime(); //0001/01/01

            DateTime EdadMinima = new DateTime(1999, 12, 31);

            Console.WriteLine("Ingrese Año");
            int año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Mes");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Dia");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Hora");
            int hora = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Minutos");
            int minutos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Segundos");
            int segundos = Convert.ToInt32(Console.ReadLine());

            DateTime fechaActual = DateTime.Now;
            DateTime fechaNacimiento = new DateTime(año, mes, dia,hora,minutos,segundos);

            DateTime mayorEdad =  fechaActual.AddYears(-18);

            //Mayor de edad en Chile edad > =  18
            if (fechaNacimiento >= mayorEdad)
            {
                fechaActual.AddYears(1);
            }

            
            DateTime fechaUtcActual = DateTime.UtcNow;

        }
    }
}
