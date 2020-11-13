using System;
using System.Collections.Generic;
using System.Text;

namespace De_la_Práctica__3._1._2._3__hasta_____
{
    class Ejercicios
    {
        //(3.1.2.3) Pide al usuario dos números enteros largos ("long") y muestra su suma,
        //su resta y su producto
        public static void Ejercicio4()
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
        public static void Ejercicio5()
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
        public static void ejercicio6()
        {
            int a = 5;
            System.Console.WriteLine("Para a = 5 tenemos: " + a);
            int b = ++a;
            System.Console.WriteLine("Para b = ++a tenemos: " + b);
            int c = a++;
            System.Console.WriteLine("Para c = a++  tenemos: " + c);
            b = b * 5;
            System.Console.WriteLine("Para b=b*5 tenemos: " + b);
            a = a * 2;
            System.Console.WriteLine("Para a=a*2 tenemos: " + a);


        }
        //(3.1.4.1) Crea un programa que use tres variables x,y,z. Sus valores iniciales serán
        //15, -10, 214. Deberás incrementar el valor de estas variables en 12, usando el
        //formato abreviado. ¿Qué valores esperas que se obtengan? Contrástalo con el
        //resultado obtenido por el programa.
        public static void Ejercicio7()
        {
            int x = 15;
            int y = -10;
            int z = 214;
            System.Console.WriteLine("La X es igual a: " + x);
            x += 12;
            System.Console.WriteLine("La X es igual a: " + x + " si se incrementa por 12");
            System.Console.WriteLine("La Y es igual a: " + y);
            y += 12;
            System.Console.WriteLine("La Y es igual a: " + y + " si se incrementa por 12");
            System.Console.WriteLine("La Z es igual a: " + z);
            z += 12;
            System.Console.WriteLine("La z es igual a: " + z + " si se incrementa por 12");
        }
        //(3.1.4.2) ¿Cuál sería el resultado de las siguientes operaciones? a=5; b=a+2; b-=3; 
        //c=-3; c*=2; ++c; a*=b; Crea un programa que te lo muestre.
        public static void Ejercicio8()
        {
            int a = 5;
            int b = a + 2;
            int c = -3;

            System.Console.WriteLine("Para int b = a + 2; tenemos: " + b);
            b -= 3;
            System.Console.WriteLine("Para  b -= 3 tenemos: " + b);
            System.Console.WriteLine("Para c  tenemos: " + c);
            c *= 2;
            System.Console.WriteLine("Para c *= 2 tenemos: " + c);
            ++c;
            System.Console.WriteLine("Para ++c tenemos: " + c);
            System.Console.WriteLine("Para a = 5 tenemos: " + a);
            a *= b;
            System.Console.WriteLine("Para a*=b tenemos: " + a);

        }
        //(3.2.1.1) Crea un programa que muestre el resultado de dividir 3 entre 4 usando 
        //números enteros y luego usando números de coma flotante.
        public static void Ejercicio9()
        {
            int a = 3;
            int b = 4;
            int ResultadoInt = a / b;
            System.Console.WriteLine(ResultadoInt);

            float c = 3;
            float d = 4;
            float ResultadoFloat = c / d;
            System.Console.WriteLine(ResultadoFloat);
        }
        //(3.2.1.2) ¿Cuál sería el resultado de las siguientes operaciones, usando números 
        //reales? a = 5; a/=2; a+=1; a*=3; --a;
        public static void ejercicio10()
        {
            int a = 5;
            System.Console.WriteLine("Para a = 5 tenemos: " + a);
            a /= 2;
            System.Console.WriteLine("Paraa a/= 2 tenemos: " + a);
            a += 1;
            System.Console.WriteLine("Paraa a += 1 tenemos: " + a);
            a *= 3;
            System.Console.WriteLine("Paraa  a *= 3 tenemos: " + a);
            --a;
            System.Console.WriteLine("Paraa --a; tenemos: " + a);
        }
        //(3.2.2.1) Crea un programa que muestre el resultado de dividir 13 entre 6 usando 
        //números enteros, luego usando números de coma flotante de simple precisión y
        //luego con números de doble precisión.
        public static void Ejercicio11()
        {
            int a = 13;
            int b = 6;
            int DivisicionInt = a / b;
            System.Console.WriteLine(DivisicionInt);

            float c = 13;
            float d = 6;
            float DivisicionFloat = c / d;
            System.Console.WriteLine(DivisicionFloat);

            double e = 13;
            double f = 6;
            double DivisionDouble = e / f;
            System.Console.WriteLine(DivisionDouble);
        }
        
    }
}
