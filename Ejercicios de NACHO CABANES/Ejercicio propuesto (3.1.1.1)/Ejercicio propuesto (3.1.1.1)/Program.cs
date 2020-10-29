using System;

namespace Ejercicio_propuesto__3._1._1._1_
{
    class Program
    {
       public static void Main ()
       {
         
            long producto = 1000000 * 100;

        

            System.Console.WriteLine("LA SOLUCION ES:", producto);
       }
        public static void Pepe ()
        {
            int producto2 = 1000000 * 100;

            System.Console.WriteLine("LA SOLUCION ES:", producto2);


        }
        //(3.1.2.1)Pregunta al usuario su edad, que se guardará en un "byte". A continuación, le deberás decir 
        //que no aparenta tantos años(por ejemplo, "No aparentas 20 años").
       public static void ejemplo()
        {
            string pregunta = "¿cuantos años tines?";
            string años = "20";

            byte edad = Convert.ToByte(años);

            Console.WriteLine(pregunta  + edad);
        }





    }


    //(3.1.2.2) Pide al usuario dos números de dos cifras("byte"), calcula su multiplicación, que se deberá guardar 
    //en un "ushort", y muestra el resultado en pantalla.
   //3.1.2.3) Pide al usuario dos números enteros largos("long") y muestra su suma, su resta y su producto.




}

