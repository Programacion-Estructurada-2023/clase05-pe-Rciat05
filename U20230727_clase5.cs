using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Declaracion de variables

            //Declaracion de variables de tipo texto con captura desde la consola 

            string ? universidad="";

            //Declarar variables de tipo texto con asignacion desde el codigo 

            string facultad="Ingenieria y arquitectura";
            string profesion="Ingeniero en Desarrollo de Software";

            //Declaracion de variables con captura desde la consola 

            int añoIngreso =0;

            //Declaracion de variables igual a enteras asignando sus valores

            int edadIngreso=18;
            int edadegreso=20;

            //Declaracion de variables double asigando valor desde consola 

            double coutaUniversidad=0.0;

            //Declaracion de variables decimal asignando valores
            double gastotransporte=35.50;

            //Capturando valores desde la consola 
            Console.WriteLine("\n***************************************************************************************");
            Console.WriteLine("\n----------Capturando valores de tipo texto----------");
            Console.WriteLine("Ingrese el nombre de la universidad donde estudia >> ");
            universidad=Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n----------Fin de la captura de datos de tipo texto----------\n");

            Console.WriteLine("\n----------Capturando datos de tipo enteros----------\n");
            Console.WriteLine("Ingrese el año en que inicio la universidad >> ");
            añoIngreso=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n----------Fin de la captura de datos de tipo entero----------\n");

            Console.WriteLine("\n----------Capturando datos de tipo decimal----------\n");
            Console.WriteLine("Ingrese la couta de la universidad >> ");
            coutaUniversidad=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n----------Fin de la captura de datos de tipo decimal---------\n");
            Console.WriteLine("\n***************************************************************************************\n");


            //Impresion de datos en consola 
            Console.WriteLine("***************************************************************************************\n\n");
            Console.WriteLine("\n----------Impresion de datos de tipo texto----------");
            Console.WriteLine("\nLa universidad en la que estudia es >>> " + universidad);
            Console.WriteLine("\nLa facultad a la que pertenece es >>> " + facultad);
            Console.WriteLine("\nEstudiando la carrera >>> " + profesion);
            Console.WriteLine("\n***************************************************************************************\n");
           
             Console.WriteLine("***************************************************************************************\n\n");
            Console.WriteLine("\n----------Impresion de datos de tipo Entero----------");
            Console.WriteLine("\nEl año que ingreso a la universidad fue >>> " + añoIngreso);
            Console.WriteLine("\nLa eda cuando inicio sus estudios es >>> " + edadIngreso);
            Console.WriteLine("\nLa edad cuando finalice sus estudios sera >>> " + edadegreso);
            Console.WriteLine("\n***************************************************************************************\n");

             Console.WriteLine("***************************************************************************************\n\n");
            Console.WriteLine("\n----------Impresion de datos de tipo Double----------");
            Console.WriteLine("\nLa couta de su unidad es  >>> " +"$" + coutaUniversidad);
            Console.WriteLine("\nSu gasto en transporte es >>> "+"$" + gastotransporte);
            Console.WriteLine("\n***************************************************************************************\n");

            Console.ReadKey();
        }
    }
}