using System;
using System.Collections.Generic;
using System.Text;

namespace De_la_Práctica__3._1._2._3__hasta_____
{
    class Ejercicios
    {
        //(3.1.2.3) Pide al usuario dos números enteros largos ("long") y muestra su suma,
        //su resta y su producto
        public static void Ejercicio4 ()
        {
            try
            {
                System.Console.WriteLine("introduce un numero entero");
                long n1 = System.Convert.ToInt64(System.Console.ReadLine());
                System.Console.WriteLine("introduce un numero entero");
                long n2 = System.Convert.ToInt64(System.Console.ReadLine());
                long suma = System.Convert.ToInt64(n1 + n2);
                long resta = System.Convert.ToInt64(n1 - n2);
                long multiplicacion = System.Convert.ToInt64(n1 * n2);

                System.Console.WriteLine(" La suma es: " + suma + ",  La resta es: " + resta + ", La multiplicacion es: " + multiplicacion);
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("error");
            }
        }
        //(3.1.3.1) Crea un programa que use tres variables x,y,z. Sus valores iniciales serán
        //15, -10, 2.147.483.647. Se deberá incrementar el valor de estas variables. ¿Qué
        //valores esperas que se obtengan? Contrástalo con el resultado obtenido por el
        //programa.
        public static void Ejercicio5 ()
        {
            int x = 15;
            int y = -10;
            long z = 2147483647;

            System.Console.WriteLine("El valor de x es : " + x);
            x++;
            System.Console.WriteLine("El incremento de x es : " + x);
            System.Console.WriteLine("El valor de x es : " + y);
            y++;
            System.Console.WriteLine("El incremento de x es : " + y);
            System.Console.WriteLine("El incremento de x es : " + z);
            z++;
            System.Console.WriteLine("El incremento de x es : " + z);
        }
        //(3.1.3.2) ¿Cuál sería el resultado de las siguientes operaciones? a=5; b=++a; c=a++;
       // b=b*5; a=a*2; Calcúlalo a mano y luego crea un programa que lo resuelva, para
        //ver si habías hallado la solución correcta.
        public static void ejercicio6 ()
        {
            int a = 5;
            int result = a * 2;
            int b = ++a;
            int c = a++;
            int result1  = b * 5;
            System.Console.WriteLine("Para a = a * 2 tenemos: " + result);
            System.Console.WriteLine("Para b = ++a tenemos: " + b);
            System.Console.WriteLine("Para c = a++ tenemos: " + c);
            System.Console.WriteLine("Para b * 5 tenemos: " + result1);

        }
        //(3.1.4.1) Crea un programa que use tres variables x,y,z. Sus valores iniciales serán
        //15, -10, 214. Deberás incrementar el valor de estas variables en 12, usando el
        //formato abreviado. ¿Qué valores esperas que se obtengan? Contrástalo con el
        //resultado obtenido por el programa.
        public static void Ejercicio7 ()
        {
            int x = 15;
            int y = -10;
            int z = 214;
            System.Console.WriteLine("La X es igual a: " + x);
            x += 12;
            System.Console.WriteLine("La X es igual a: " + x +" si se incrementa por 12");
            System.Console.WriteLine("La Y es igual a: " + y);
            y += 12;
            System.Console.WriteLine("La Y es igual a: " + y + " si se incrementa por 12");
            System.Console.WriteLine("La Z es igual a: " + z);
            z += 12;
            System.Console.WriteLine("La z es igual a: " + z + " si se incrementa por 12");
        }
    }
}
