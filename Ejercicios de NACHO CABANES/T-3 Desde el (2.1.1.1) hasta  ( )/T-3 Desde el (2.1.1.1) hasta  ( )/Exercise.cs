using System;
using System.Collections.Generic;
using System.Text;

namespace T_3_Desde_el__2._1._1._1__hasta_____
{
    class Exercise
    {
        //(2.1.1.1) Crea un programa que pida al usuario un número entero y diga si es par 
        //(pista: habrá que comprobar si el resto que se obtiene al dividir entre dos es cero: if (x % 2 == 0) …).
        public static void IsEven41()
        {
            try
            {
                System.Console.WriteLine("Introduce un numero entero");
                int n = System.Convert.ToInt32(System.Console.ReadLine());

                if (((n % 2) == 0))
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

                if ((n1 % n2) == 0)
                {
                    System.Console.WriteLine(n1 + " es múltiplo de " + n2);
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
            if (n3 != 0)
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
            if ((n1 % 2) == 0)
            {
                System.Console.WriteLine(n1 + " es multiplo de 2 ");
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
                System.Console.WriteLine(n1 + " , " + n2 + " son pares ");
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
            if ((n1 % 2) == 0)
            {
                System.Console.WriteLine(n1 + " es par ");
            }
            else
            {
                System.Console.WriteLine(n1 + " es impar");
            }
            if ((n2 % 2) == 0)
            {
                System.Console.WriteLine(n2 + " es par ");
            }
            else
            {
                System.Console.WriteLine(n2 + " es impar");
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
        //(2.1.6.1) Crea una variante del ejemplo 02_01_06a, en la que la comparación de igualdad sea correcta y en la que las variables
        //aparezcan en el lado derecho de la comparación y los números en el lado izquierdo.
        public static void Ejemplo_59()
        {
            int numero;
            Console.WriteLine("Introduce un número");
            numero = Convert.ToInt32(Console.ReadLine());
            if (0 == numero)

                Console.WriteLine("El número es cero.");
            else
             if (0 > numero)
                Console.WriteLine("El número es negativo.");
            else
                Console.WriteLine("El número es positivo.");
        }
        //(2.1.7.1) Crea el diagrama de flujo para el programa que pide dos números al usuario y dice cuál es el mayor de los dos.
        // (EJERCICIO PRÁCTICO)

        // (2.1.7.2) Crea el diagrama de flujo para el programa que pide al usuario dos números y dice si uno de ellos es 
        //positivo, si lo son los dos o si no lo es ninguno.
        //( EJERCICIO PRÁCTICO)

        //(2.1.7.3) Crea el diagrama de flujo para el programa que pide tres números al  usuario y dice cuál es el mayor de los tres.
        // ( EJERCICIO PRÁCTICO)

        //(2.1.8.1) Crea un programa que use el operador condicional para mostrar un el valor absoluto de un número de la siguiente forma: 
        //si el número es positivo, se mostrará tal cual; si es negativo, se mostrará cambiado de signo

        public static void GetValor_63()
        {
            Console.WriteLine("Introduce un número");
            int a = Convert.ToInt32(Console.ReadLine());
            int EsPositivo;
            EsPositivo = a > 0 ? a : a;
            Console.WriteLine(EsPositivo);
        }
        //(2.1.8.2) Usa el operador condicional para calcular el menor de dos números.
        public static void GetMenor_64()
        {
            Console.WriteLine("Introduce un número");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce un número");
            int b = Convert.ToInt32(Console.ReadLine());
            int menor = a < b ? a : b;
            Console.WriteLine(" el menor es: " + menor);
        }
        //(2.1.9.1) Crea un programa que pida un número del 1 al 5 al usuario, y escriba el nombre de ese número, usando "switch" 
        //(por ejemplo, si introduce "1", el programa escribirá "uno").
        public static void Excercise_Switch1_65()
        {
            Console.WriteLine("Introduce un número del 1 al 5");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Has introcucido el número 1");
                    break;
                case 2:
                    Console.WriteLine("Has introcucido el número 2");
                    break;
                case 3:
                    Console.WriteLine("Has introcucido el número 3");
                    break;
                case 4:
                    Console.WriteLine("Has introcucido el número 4");
                    break;
                case 5:
                    Console.WriteLine("Has introcucido el número 5");
                    break;
            }
        }
        //(2.1.9.2) Crea un programa que lea una letra tecleada por el usuario y diga si se trata de un signo de puntuación(. , ; :), 
        //una cifra numérica(del 0 al 9) o algún otro carácter, usando "switch" (pista: habrá que usar un dato de tipo "char").
        public static void Excercise_Switch2_66()
        {
            Console.WriteLine("Teclea una letra");
            char a = Convert.ToChar(Console.ReadLine());
            switch (a)
            {
                case '.':
                case ',':
                case ';':
                case ':':
                    System.Console.WriteLine("El caracter que has utilizado es un signo de puntuación");
                    break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    System.Console.WriteLine("El caracter que has utilizado es un número");
                    break;
                default:
                    Console.WriteLine("has introducido un caracter distinto a un signo de puntuación o un número");
                    break;
            }
        }
        //(2.1.9.3) Crea un programa que lea una letra tecleada por el usuario y diga si se  trata de una vocal, una cifra numérica o una consonante, usando "switch".
        public static void Excercise_Switch3_67()
        {
            System.Console.WriteLine("introcude una letra o numero");
            char a = System.Convert.ToChar(Console.ReadLine());
            switch (a)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    System.Console.WriteLine("El caracter que has utilizado es un número");
                    break;
                case 'a':
                case 'A':
                case 'E':
                case 'e':
                case 'i':
                case 'I':
                case 'O':
                case 'u':
                case 'o':
                case 'U':
                    System.Console.WriteLine("El caracter que has utilizado es una vocal");
                    break;
                default:
                    Console.WriteLine("has introducido una consonante");
                    break;
            }
        }
        //(2.1.9.4) Repite el ejercicio 2.1.9.1, empleando "if" en lugar de "switch".
        public static void Excercise_Switch1_2_68()
        {
            Console.WriteLine("Introduce un número del 1 al 5");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
                Console.WriteLine("Has introcucido el número 1");
            else if (a == 2)
                Console.WriteLine("Has introcucido el número 2");
            else if (a == 3)
                Console.WriteLine("Has introcucido el número 3");
            else if (a == 4)
                Console.WriteLine("Has introcucido el número 4");
            else if (a == 5)
                Console.WriteLine("Has introcucido el número 5");
            else
                Console.WriteLine("Has introcucido un numero distento de 1,2,3,4,5");
        }
        //(2.1.9.5) Repite el ejercicio 2.1.9.2, empleando "if" en lugar de "switch" (pista: como las cfras numéricas del 0 al 9 están ordenadas,
        //no hace falta comprobar los 10 valores, sino que se puede hacer con "if ((simbolo >= '0') && (simbolo <='9'))").
        public static void Excercise_Switch2_2_69()
        {
            Console.WriteLine("Teclea un valor");
            char a = Convert.ToChar(Console.ReadLine());
            if (a == '.')
                System.Console.WriteLine("El caracter que has utilizado es un signo de puntuación: " + ".");
            else if (a == ',')
                System.Console.WriteLine("El caracter que has utilizado es un signo de puntuación: " + ",");
            else if (a == ';')
                System.Console.WriteLine("El caracter que has utilizado es un signo de puntuación: " + ";");
            else if (a == ':')
                System.Console.WriteLine("El caracter que has utilizado es un signo de puntuación: " + ":");

            else if ((a >= '0') && (a <= '9'))
                System.Console.WriteLine("El caracter que has utilizado es un número");
            else
                Console.WriteLine("has introducido un caracter distinto a un signo de puntuación o un número");
        }
        //(2.1.9.6) Repite el ejercicio 2.1.9.3, empleando "if" en lugar de "switch".
        public static void Excercise_Switch3_2_70()
        {
            System.Console.WriteLine("introcude una letra o numero");
            char a = System.Convert.ToChar(Console.ReadLine());

            if ((a >= '0') && (a <= '9'))
                System.Console.WriteLine("El caracter que has utilizado es un número");
            else if (a == 'a')
                System.Console.WriteLine("El caracter que has utilizado es una vocal");
            else if (a == 'e')
                System.Console.WriteLine("El caracter que has utilizado es una vocal");
            else if (a == 'i')
                System.Console.WriteLine("El caracter que has utilizado es una vocal");
            else if (a == 'o')
                System.Console.WriteLine("El caracter que has utilizado es una vocal");
            else if (a == 'u')
                System.Console.WriteLine("El caracter que has utilizado es una vocal");
            else if (a == 'A')
                System.Console.WriteLine("El caracter que has utilizado es una vocal");
            else if (a == 'E')
                System.Console.WriteLine("El caracter que has utilizado es una vocal");
            else if (a == 'I')
                System.Console.WriteLine("El caracter que has utilizado es una vocal");
            else if (a == 'O')
                System.Console.WriteLine("El caracter que has utilizado es una vocal");
            else if (a == 'U')
                System.Console.WriteLine("El caracter que has utilizado es una vocal");
            else
                Console.WriteLine("has introducido una consonante");
        }
        //(2.2.1.1.1) Crea un programa que pida al usuario su contraseña (numérica). Deberá terminar cuando introduzca como 
        //contraseña el número 1111, pero volvérsela a pedir tantas veces como sea necesario.
        public static void Excercise_contraseña_71()
        {
            bool Salir = true;
            while (Salir == true)
            {
                System.Console.WriteLine("introcude la contraseña");
                int a = System.Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1111:
                         Salir = false;
                         System.Console.WriteLine("contraseña correcta");
                         Console.ReadLine();
                         break;
                }
            }
        }
        //(2.2.1.1.2) Crea un "calculador de cuadrados": pedirá al usuario un número y  mostrará su cuadrado. Se repetirá mientras
        //el número introducido no sea cero (usa "while" para conseguirlo).
        public static void Exercise_While_72() //REVISAR 
        {
            System.Console.WriteLine("untroduce un número");
            int n2 = System.Convert.ToInt32(Console.ReadLine());
            while (n2 != 0)
            {
                System.Console.WriteLine("untroduce un número");
                int n1 = System.Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("untroduce un número");
                n1 = System.Convert.ToInt32(Console.ReadLine());
                int cuadrado = n1 * n1;
                System.Console.WriteLine(" El cuadrado es: " + cuadrado);
                break;

            }
        }



        //(2.2.1.1.3) Crea un programa que pida de forma repetitiva pares de números al usuario.Tras introducir cada par de números, 
        //responderá si el primero es múltiplo del segundo.
        public static void Exercise_While_73()
        {
            bool salir = true;
            while (salir == true)
            {
                System.Console.WriteLine("untroduce un par de números");
                int n1 = System.Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("untroduce un par de números");
                int n2 = System.Convert.ToInt32(Console.ReadLine());
                if ((n1 % n2) == 0)
                    System.Console.WriteLine(n1 + " es multiplo de " + n2);
                else
                    System.Console.WriteLine(n1 + " NO es multiplo de " + n2);

                // NO HE PUESTO CONDICIÓN DE SALIDA, ES UN BUCLE INFINITO. ME HE CELLIDO A LO QUE DICE EL ENUNCIADO
            }
        }

        //(2.2.1.1.4) Crea una versión mejorada del programa anterior, que, tras introducir cada par de números, responderá si el primero 
        //es múltiplo del segundo, o el segundo es múltiplo del primero, o ninguno de ellos es múltiplo del otro.
        public static void Exercise_While_74()
        {
            bool salir = true;
            while (salir == true)
            {
                System.Console.WriteLine("untroduce un par de números");
                int n1 = System.Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("untroduce un par de números");
                int n2 = System.Convert.ToInt32(Console.ReadLine());
                if ((n1 % n2) == 0)
                    System.Console.WriteLine(n1 + " es multiplo de " + n2);
                else if ((n2 % n1) == 0)
                    System.Console.WriteLine(n2 + " es multiplo de " + n1);
                else
                    System.Console.WriteLine("ninguno de ellos es múltiplo del otro");

                // NO HE PUESTO CONDICIÓN DE SALIDA, ES UN BUCLE INFINITO. ME HE CELLIDO A LO QUE DICE EL ENUNCIADO
            }
        }

        //(2.2.1.2.1) Crea un programa que escriba en pantalla los números del 1 al 10, usando "while".
        public static void Exercise_While_75()
        {
            int i = 1;
            while (i <= 10)
            {
                System.Console.WriteLine(i);
                i++;
            }
        }

        //(2.2.1.2.2) Crea un programa que escriba en pantalla los números pares del 26 al 10 (descendiendo), usando "while".
        public static void Exercise_While_76()
        {
            int i = 26;
            while (i >= 10)
            {
                if ((i % 2) == 0)
                    System.Console.WriteLine(i);
                i--;
            }
        }

        //(2.2.1.2.3) Crea un programa calcule cuantas cifras tiene un número entero positivo(pista: se puede hacer dividiendo varias veces entre 10).
        public static void Exercise_While_77()
        {
            int n1 = Utils.comodin();
            int contador = 0;
            while ( n1 != 0)
            {
                n1 /= 10;
                contador++;
            }
            System.Console.WriteLine("El número introducido tiene " + contador + " cifras");
        }

        //(2.2.1.2.4) Crea el diagrama de flujo y la versión en C# de un programa que dé al usuario tres oportunidades para adivinar un número del 1 al 10.
        public static void Exercise_While_78() // REVISAR
        {
            bool salir = true;
            while(salir = true)
            {
                System.Console.WriteLine("introduce un numero del 1 al 10 para adivinar el número");
                System.Console.WriteLine(" introduce un número");
                int n1 = System.Convert.ToInt32(Console.ReadLine());
                if (n1 == 3)
                {
                    
                    System.Console.WriteLine("¡MUY BIEN! Es el número 3. Has hacertado a la primera");

                }
                else
                {
                    System.Console.WriteLine("ERROR !!! , segundo intento: introduce un número");
                    int n2 = System.Convert.ToInt32(Console.ReadLine());
                    if (n2 == 3)
                    {
                        System.Console.WriteLine("¡MUY BIEN! Es el número 3. Has hacertado a la segunda");
                    }
                    else
                    {
                        System.Console.WriteLine("ERROR !!! , tercer intento: introduce un número");
                        int n3 = System.Convert.ToInt32(Console.ReadLine());
                        if (n3 == 3 )
                        {
                            System.Console.WriteLine("¡MUY BIEN! Es el número 3. Has hacertado a la tercera");
                        }
                        else
                        {
                            salir = false;
                            System.Console.WriteLine("LO SENTIMOS, NO HAS ACERTADO EL NÚMERO");
                        }
                    }
                }
            }
        }
        //(2.2.2.1) Crear un programa que pida números positivos al usuario, y vaya calculando y mostrando la suma de todos ellos
        //(terminará cuando se teclea un número negativo o cero).
        public static void Exercise_do_While_89() //REVISAR, NO ME SALE
        {
            int n1 = Utils.comodin();
            do
            {
                System.Console.WriteLine(n1);
                n1++;
            }
            while ((n1 < 0) && (n1 == 0));
            {
                System.Console.WriteLine("fin de programa");
            }
        }
        //(2.2.2.2) Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while".

        //(2.2.2.3) Crea un programa que escriba en pantalla los números pares del 26 al 10 (descendiendo), usando "do..while".

        //(2.2.2.4) Crea un programa que pida al usuario su identificador y su contraseña(ambos numéricos), y no le permita seguir hasta 
        //que introduzca como identificador "1234" y como contraseña "1111".

        //(2.2.2.5) Crea un programa que pida al usuario su identificador y su contraseña, y no le permita seguir hasta que 
        //introduzca como nombre "Pedro" y como contraseña "Peter".

        //(2.2.3.1) Crea un programa que muestre los números del 10 al 20, ambos  incluidos
        public static void Exercise_for_84()
        {
            for (int i = 10; i <= 20; i++)
            {
                System.Console.Write(i + ", ");
               // if (i == 20)
               // {
                 //   System.Console.Write(i);
              //  }
            }
        }
        //(2.2.3.2) Crea un programa que escriba en pantalla los números del 1 al 50 que sean múltiplos de 3 
        //(pista: habrá que recorrer todos esos números y ver si el resto de la división entre 3 resulta 0).
        public static void Exercise_for_85()
        {
            for (int i = 1; i <= 50; i++)
            {
                if ((( i % 3)==0))
                    System.Console.Write( i + ", ");
            }
        }
        //(2.2.3.1.3) Crea un programa que muestre los números del 100 al 200 (ambos incluidos) que sean divisibles entre 7 y a la vez entre 3.
        public static void Excercise_for_86()
        {
            for (int i = 100; i <= 200; i++)
            {
                if (((i % 7) == 0) && ((i % 3) == 0))
                {
                    System.Console.Write(i + ", ");
                    
                }
            }
        }
        //(2.2.3.4) Crea un programa que muestre la tabla de multiplicar del 9. 
        public static void Excersise_for_87()
        {
            for (int i = 9; i <= 90; i+=9 )
            {
                System.Console.WriteLine(i + " ");
            }
        }
        //(2.2.3.5) Crea un programa que muestre los primeros ocho números pares: 2 4 6 8 10 12 14 16 (pista: en cada pasada habrá que aumentar 
        //de 2 en 2, o bien mostrar el doble del valor que hace de contador).
        public static void Exercise_for_88()
        {
            for (int i = 2; i <= 16; i+=2)
            {
                System.Console.WriteLine(i + " ");
            }
        }
        //(2.2.3.6) Crea un programa que muestre los números del 15 al 5, descendiendo (pista: en cada pasada habrá que descontar 1, por ejemplo
         //haciendo i = i - 1, que se puede abreviar i--)
         public static void Exercise_for_89()
         {
            for (int i = 15; i >=5; i--)
            {
                System.Console.WriteLine(i + " ");
            }
         }
        //(2.2.4.1) Crea un programa que contenga un bucle sin fin que escriba "Hola " en pantalla, sin avanzar de línea.
        public static void Exercise_Infinity_90()
        {
            for (; ; )
            {
                System.Console.WriteLine("HOLA");
            }
        }
       //(2.2.4.2) Crea un programa que contenga un bucle sin fin que muestre los números enteros positivos a partir del uno.
       public static void  Exercise_Infinity_91()
       {
            for (int i =1; i>0; i++)
            {
                System.Console.Write(i + " ");
            }
       }
        //(2.2.5.1) Crea un programa escriba 4 veces los números del 1 al 5, en una misma  línea, usando "for": 12345123451234512345.
        public static void Exercise_For2_92()
        {
            for ( int i = 1; i <= 4; i++)
            {
                System.Console.Write("12345");
            }
        }
        //(2.2.5.2) Crea un programa escriba 4 veces los números del 1 al 5, en una misma línea, usando "while": 12345123451234512345.
        public static void Exercise_while_93()
        {
            int i = 1;
            while ( i <=4)
            {
                System.Console.Write("12345");
                i++;
            }
        }
        //(2.2.5.3) Crea un programa que, para los números entre el 10 y el 20 (ambos incluidos) diga si son divisibles entre 5, 
        //si son divisibles entre 6 y si son divisibles entre 7.
        public static void exercise_for2_94()
        {
            for (int i = 10; i <=20; i++)
            {
                if ((i % 5) == 0)
                    System.Console.WriteLine(i + " es divisible entre 5");
                else if ((i % 6) == 0)
                    System.Console.WriteLine(i + " es divisible entre 6");
                else if ((i % 7) == 0)
                    System.Console.WriteLine(i + " es divisible entre 7");
                else
                    System.Console.WriteLine(i + "  NO es divisible entre 5,6,7");
            }
        }
        //(2.2.6.1) Crea un programa que escriba 4 líneas de texto, cada una de las cuales estará formada por los números del 1 al 5.
        public static void Exercise_for2_95()
        {
            for ( int i = 1; i <= 4; i++)
            {
                System.Console.WriteLine(" 1 2 3 4 5 ");
            }
        }
        //(2.2.6.2) Crea un programa que pida al usuario el ancho(por ejemplo, 4) y el alto
        //(por ejemplo, 3) y escriba un rectángulo formado por esa cantidad de asteriscos:
        //****
        //****
       // ****
       public static void Exercise_For2_96()
       {
            int n1 = Utils.comodin();
            int n2 = Utils.comodin();
            for (int i = 0; i < n1; i++)
            {
                for (int j = 1; j < n2; j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine("*");
            }
       }
        //(2.2.7.1) Crea un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo).
        public static void Excercise_for2_97()
        {
            for (char letra ='Z'; letra >= 'A'; letra--)
            {
                System.Console.WriteLine(letra);
            }
        }
        //(2.2.7.2) Crea un programa que muestre 5 veces las letras de la L (mayúscula) a la  N(mayúscula), en la misma línea.
        public static void Excercise_for2_98()
        {
            for (char letra = 'L'; letra <= 'N'; letra++)
            {
                for (char j = '1'; j <= '5'; j++)
                {
                    System.Console.Write(letra);
                }
                System.Console.WriteLine("");
            }
        }
        //(2.2.8.1) Crea un programa que escriba 6 líneas de texto, cada una de las cuales 
        //estará formada por los números del 1 al 7. Debes usar dos variables llamadas 
        //"linea" y "numero", y ambas deben estar declaradas en el "for"
        public static void Excercise_for2_99()
        {
            for(int linea = 1; linea<=6; linea++)
            {
                for (int numero = 1; numero<=7; numero++)
                {
                    System.Console.Write(numero);
                }
               System.Console.WriteLine("");
            }
        }
        //(2.2.8.2) Crea un programa que pida al usuario el ancho (por ejemplo, 4) y el alto 
        //(por ejemplo, 3) y escriba un rectángulo formado por esa cantidad de asteriscos,
        //como en el ejercicio 2.2.6.2. Deberás usar las variables "ancho" y "alto" para los
        //datos que pidas al usuario, y las variables "filaActual" y "columnaActual" 
        //(declaradas en el "for") para el bloque repetitivo.
        public static void Excercise_for2_100()//Esta a mitad
        {
            int n1 = Utils.comodin();
            int n2 = Utils.comodin();
            for (int i = 0; i < n1; i++)
            {
                for (int j = 1; j < n2; j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine("*");
            }
        }
    }
}
