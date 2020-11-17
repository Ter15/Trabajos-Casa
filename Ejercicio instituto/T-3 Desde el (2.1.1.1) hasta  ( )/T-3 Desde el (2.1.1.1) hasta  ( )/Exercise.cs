using System;
using System.Collections.Generic;
using System.Text;

namespace T_3_Desde_el__2._1._1._1__hasta_____
{
    class Exercise
    {
        //(2.1.1.1) Crea un programa que pida al usuario un número entero y diga si es par 
        //(pista: habrá que comprobar si el resto que se obtiene al dividir entre dos es cero: if (x % 2 == 0) …).
         public static void IsEven41 ()
         {
            try
            {
                System.Console.WriteLine("Introduce un numero entero");
                int n = System.Convert.ToInt32(System.Console.ReadLine());

                if (((n % 2)==0))
                {
                    System.Console.WriteLine("Es par");
                }
                else
                {
                    System.Console.WriteLine("Es impar");
                }

            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("HAS INTRODUCIDO UN ERROR");
            }
         }
        //(2.1.1.2) Crea un programa que pida al usuario dos números enteros y diga cuál es el mayor de ellos.

        public static void IsGreater42()
        {
            try
            {
                System.Console.WriteLine("Introduce un numero entero");
                int n1 = System.Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("Introduce un numero entero");
                int n2 = System.Convert.ToInt32(System.Console.ReadLine());

                if (n1 > n2)
                {
                    System.Console.WriteLine("El mayor es: " + n1);
                }
                else
                {
                    System.Console.WriteLine("El mayor es: " + n2);
                }
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("HAS INTRODUCIDO UN ERROR");
            }
        }
        //(2.1.1.3) Crea un programa que pida al usuario dos números enteros y diga si el  primero es múltiplo del segundo
        //(pista: igual que antes, habrá que ver si el resto  de la división es cero: a % b == 0)
        public static void IsMultiple43()
        {
            try
            {
                System.Console.WriteLine("Introduce un numero entero");
                int n1 = System.Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("Introduce un numero entero");
                int n2 = System.Convert.ToInt32(System.Console.ReadLine());

                if ((n1 % n2)==0)
                {
                    System.Console.WriteLine( n1 + " es múltiplo de " + n2);
                }
                else
                {
                    System.Console.WriteLine(n1 + " NO es múltiplo de " + n2);
                }
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("HAS INTRODUCIDO UN ERROR");
            }
        }
        //(2.1.2.1) Crea un programa que pida al usuario un número entero.Si es múltiplo de 10, informará al usuario y 
        //pedirá un segundo número, para decir continuación si este segundo número también es múltiplo de 10.
        public static void IsMultiple10_44()
        {
            try
            {
                System.Console.WriteLine("Introduce un numero entero");
                int n1 = System.Convert.ToInt32(System.Console.ReadLine());

                if ((n1 % 10) == 0)
                {
                    System.Console.WriteLine(n1 + " es múltiplo de 10");
                    System.Console.WriteLine("Introduce un numero entero");
                    int n2 = System.Convert.ToInt32(System.Console.ReadLine());

                    if (((n2 % 10) == 0))
                    {
                        System.Console.WriteLine(n2 + " es múltiplo de 10");
                    }
                    else
                    {
                        System.Console.WriteLine(" NO es múltiplo de 10");
                    }

                }
                else
                {
                    System.Console.WriteLine(" NO es múltiplo de 10");
                }
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("HAS INTRODUCIDO UN ERROR");
            }
        }






    }
}
