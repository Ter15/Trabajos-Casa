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
        //(2.1.3.1) Crea un programa que multiplique dos números enteros de la siguiente forma: pedirá al usuario un primer
        //número entero.Si el número que se que teclee es 0, escribirá en pantalla "El producto de 0 por cualquier número es 0". 
        //Si se ha tecleado un número distinto de cero, se pedirá al usuario un segundo número y se mostrará el producto de ambos.
        public static void GetMultiplication45()
        {
            System.Console.WriteLine("Introduce un numero entero");
            int n2 = System.Convert.ToInt32(System.Console.ReadLine());
            if (n2 == 0)
            {
                System.Console.WriteLine("El producto de 0 por cualquier número es 0");
            }
            if (n2 != 0)
            System.Console.WriteLine("Introduce el segundo numero entero");
            int n3 = System.Convert.ToInt32(System.Console.ReadLine());

            int result = n2 * n3;

            System.Console.WriteLine("El resultado es: " + result);
        }
        //(2.1.3.2) Crea un programa que pida al usuario dos números enteros. Si el  segundo no es cero,
        //mostrará el resultado de dividir entre el primero y el segundo. Por el contrario, si el segundo número es cero,
        //escribirá "Error: No se puede dividir entre cero".
        public static void GetDivision46()
        {
            System.Console.WriteLine("Introduce un numero entero");
            int n2 = System.Convert.ToInt32(System.Console.ReadLine());
            
           System.Console.WriteLine("Introduce el segundo numero entero");
           int n3 = System.Convert.ToInt32(System.Console.ReadLine());
            if (n3 == 0)
            {
                System.Console.WriteLine("Error: No se puede dividir entre cero");
            }
            if(n3 !=0)
            {
                int result = n2 / n3;

                System.Console.WriteLine("El resultado es: " + result);
            }              
        }
        //(2.1.4.1) Mejora la solución al ejercicio 2.1.3.1, usando "else".
        public static void GetMultiplication2_47()
        {
            System.Console.WriteLine("Introduce un numero entero");
            int n2 = System.Convert.ToInt32(System.Console.ReadLine());
            if (n2 == 0)
            {
                System.Console.WriteLine("El producto de 0 por cualquier número es 0");
            }
            else
            {
                System.Console.WriteLine("Introduce el segundo numero entero");
                int n3 = System.Convert.ToInt32(System.Console.ReadLine());

                int result = n2 * n3;

                System.Console.WriteLine("El resultado es: " + result);
            }
        }
        //(2.1.4.2) Mejora la solución al ejercicio 2.1.3.2, usando "else".
        public static void GetDivision2_48()
        {
            System.Console.WriteLine("Introduce un numero entero");
            int n2 = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Introduce el segundo numero entero");
            int n3 = System.Convert.ToInt32(System.Console.ReadLine());
            if (n3 == 0)
            {
                System.Console.WriteLine("Error: No se puede dividir entre cero");
            }
            else
            {
                int result = n2 / n3;

                System.Console.WriteLine("El resultado es: " + result);
            }
        }
        //(2.1.5.1) Crea un programa que pida al usuario un número entero y responda si es  múltiplo de 2 o de 3.
        public static void IsMultiple2_3_49()
        {
            System.Console.WriteLine("Introduce un numero entero");
            int n1 = System.Convert.ToInt32(System.Console.ReadLine());
            if ((n1 % 2)==0 )
            {
                System.Console.WriteLine( n1 + " es multiplo de 2 ");
            }
            if ((n1 % 3) == 0)
            {
                System.Console.WriteLine(n1 + "  es multiplo  de 3");
            }
            if ((n1 % 2) != 0 && (n1 % 3) != 0)
            {
                System.Console.WriteLine(n1 + " no  es multiplo  de 2 ni de 3");
            }
        }
        //(2.1.5.2) Crea un programa que pida al usuario un número entero y responda si es múltiplo de 2 y de 3 simultáneamente.
        public static void IsMultiple2__3_50()
        {
            System.Console.WriteLine("Introduce un numero entero");
            int n1 = System.Convert.ToInt32(System.Console.ReadLine());
            if ((n1 % 2) == 0 && (n1 % 3) == 0)
            {
                System.Console.WriteLine(n1 + " es multiplo de 2 y de 3 a la vez ");
            }
            else 
            {
                System.Console.WriteLine(n1 + " no  es multiplo  de 2 ni de 3 a la vez");
            }
        }
        //(2.1.5.3) Crea un programa que pida al usuario un número entero y responda si es múltiplo de 2 pero no de 3.
        public static void IsMultiple2__3_51()
        {
            System.Console.WriteLine("Introduce un numero entero");
            int n1 = System.Convert.ToInt32(System.Console.ReadLine());
            if ((n1 % 2) == 0 && (n1 % 3) != 0)
            {
                System.Console.WriteLine(n1 + " es multiplo de 2  pero no de 3 ");
            }
            else
            {
                System.Console.WriteLine(n1 + " no cumple con la condicion del enunciado ");
            }
        }
        //(2.1.5.4) Crea un programa que pida al usuario un número entero y responda si no es múltiplo de 2 ni de 3.
        public static void IsMultiple2__3_52()
        {
            System.Console.WriteLine("Introduce un numero entero");
            int n1 = System.Convert.ToInt32(System.Console.ReadLine());
            if ((n1 % 2) != 0 && (n1 % 3) != 0)
            {
                System.Console.WriteLine(n1 + " no  es multiplo de 2  ni de 3 ");
            }
            else
            {
                System.Console.WriteLine(n1 + " no cumple con la condicion del enunciado ");
            }
        }
        //(2.1.5.5) Crea un programa que pida al usuario dos números enteros y diga si ambos son pares.
        public static void IsEven_1_53()
        {
            System.Console.WriteLine("Introduce un numero entero");
            int n1 = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Introduce un numero entero");
            int n2 = System.Convert.ToInt32(System.Console.ReadLine());
            if ((n1 % 2) == 0 && (n2 % 2) == 0)
            {
                System.Console.WriteLine(n1 + " , " + n2 +" son pares ");
            }
            else
            {
                System.Console.WriteLine(n1 + " , " + n2 + " uno de los dos es impar ");
            }
        }
        //(2.1.5.6) Crea un programa que pida al usuario dos números enteros y diga si (al menos) uno es par.
        public static void IsEven_2_54()
        {
            System.Console.WriteLine("Introduce un numero entero");
            int n1 = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Introduce un numero entero");
            int n2 = System.Convert.ToInt32(System.Console.ReadLine());
            if ((n1 % 2) == 0 || (n2 % 2) == 0)
            {
                System.Console.WriteLine(" los dos o uno de ellos es par ");
            }
            else
            {
                System.Console.WriteLine("son impares");
            }
        }
        //(2.1.5.7) Crea un programa que pida al usuario dos números enteros y diga si uno  y sólo uno es par.
        public static void IsEven_3_55()
        {
            System.Console.WriteLine("Introduce un numero entero");
            int n1 = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Introduce un numero entero");
            int n2 = System.Convert.ToInt32(System.Console.ReadLine());
            if ((n1 % 2) == 0 )
            {
                System.Console.WriteLine( n1 + " es par ");
            }
            else 
            {
                System.Console.WriteLine(n1 + " es impar");
            }
            if  ((n2 % 2) == 0)
            {
                System.Console.WriteLine(n2 + " es par ");
            }
            else 
            {
                System.Console.WriteLine(n2  + " es impar");
            }
        }
        //(2.1.5.8) Crea un programa que pida al usuario dos números enteros y diga "Uno de los números es positivo", "Los dos números son positivos"
        //o bien "Ninguno de los números es positivo", según corresponda.
        public static void GetPositive_56()
        {
            System.Console.WriteLine("Introduce un numero entero");
            int n1 = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Introduce un numero entero");
            int n2 = System.Convert.ToInt32(System.Console.ReadLine());
            if ((n1 > 0) && (n2 > 0))
            {
                System.Console.WriteLine("los dos son positivos ");
            }
            else if ((n1 > 0) || (n2 > 0))
            {
                System.Console.WriteLine("uno de los dos números es positivo");
            }
            else
            {
                System.Console.WriteLine("ninguno es positivo");
            }
        }
        //(2.1.5.9) Crea un programa que pida al usuario tres números y muestre cuál es el  mayor de los tres.
        public static void IsGreater3_57()
        {
            System.Console.WriteLine("Introduce un numero entero");
            int n1 = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Introduce un numero entero");
            int n2 = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Introduce un numero entero");
            int n3 = System.Convert.ToInt32(System.Console.ReadLine());
            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    System.Console.WriteLine("El mayor es: " + n1);
                }
                else
                {
                    System.Console.WriteLine("El mayor es: " + n3);
                }
            }
            else
            {
                if (n2 > n3)
                {
                    System.Console.WriteLine("El mayor es: " + n2);
                }
                else
                {
                    System.Console.WriteLine("El mayor es: " + n3);
                }
            }
        }
        //(2.1.5.10) Crea un programa que pida al usuario dos números enteros y diga si son iguales o, en caso contrario, cuál es el mayor de ellos.
        public static void IsGreater_2_58()
        {
            System.Console.WriteLine("Introduce un numero entero");
            int n1 = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Introduce un numero entero");
            int n2 = System.Convert.ToInt32(System.Console.ReadLine());
            if (n1 == n2)
            {
                System.Console.WriteLine("los dos son iguales");
            }
            else if (n1 > n2)
            {
               System.Console.WriteLine("El mayor es: " + n1);
            }
            else
            {
                System.Console.WriteLine("El mayor es: " + n2);
            }
        }
    }
}
