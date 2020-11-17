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
        //(3.2.2.2) Calcula el área de un círculo, dado su radio, que será un número entero
        //(área = pi * radio al cuadrado)
        public static void Ejercicio12()
        {
            int radio = 54;
            double area = System.Math.PI * radio * radio;

            System.Console.WriteLine(area);
        }
        //(3.2.3.1) Calcula el volumen de una esfera, dado su radio, que será un número de
        //doble precisión(volumen = pi * radio al cubo * 4/3)
        public static void Ejercicio13()
        {
            double r = 67;
            double volumen = System.Math.PI * r * r * 3 / 4;
            System.Console.WriteLine(volumen);
        }
        //((3.2.3.2) Crea un programa que pida al usuario a una distancia (en metros) y el 
        //tiempo necesario para recorrerla(como tres números: horas, minutos, segundos), 
        //y muestre la velocidad, en metros por segundo, en kilómetros por hora y en millas
        //por hora(pista: 1 milla = 1.609 metros).
        public static void Ejercicio14()
        {
            try
            {
                System.Console.WriteLine("introduce los metros");
                double a = System.Convert.ToDouble(System.Console.ReadLine());
                System.Console.WriteLine("¿ En cuento tiempo quieres recorrerla? introcude las horas");
                double b = System.Convert.ToDouble(System.Console.ReadLine());
                System.Console.WriteLine("introcude los minutos");
                double c = System.Convert.ToDouble(System.Console.ReadLine());
                System.Console.WriteLine("introcude los segundos");
                double d = System.Convert.ToDouble(System.Console.ReadLine());

                double kilometro = a * 0.001;
                double segundos = (b * 3600) + (c * 60) + d;
                double horas = (b + (c * 0.0166667) + (d * 0.000277778));
                double millas = a * 0.000621371;

                System.Console.WriteLine("Este es el resultado en  m/s: " + a + "/" + segundos);
                System.Console.WriteLine("Este es el resultado en  Km/h: " + kilometro + "/" + horas);
                System.Console.WriteLine("Este es el resultado en  millas/h: " + millas + "/" + horas);
            }
            catch
            {
                System.Console.WriteLine("Has introducido un ERROR");
            }

        }
        //(3.2.3.3) Halla las soluciones de una ecuación de segundo grado del tipo y = Ax2 +  Bx + C.
        //Pista: la raíz cuadrada de un número x se calcula con Math.Sqrt(x)
        public static double Ejercicio15(double a, double b, double c)
        {
            double aux;
            double aux2;
            double x;

            aux = b * b - 4.0 * a * c;
            aux2 = System.Math.Sqrt(aux);
            x = (-b * aux) / (2.0 * a);
            return x;
            /*
            aux = b * b - 4.0 * a * c;
            aux2 = System.Math.Sqrt(aux);
            x = (-b * - aux) / (2.0 * a);
            return x;
            */
        }
        // (3.2.3.4) Si se ingresan E euros en el banco a un cierto interés I durante N años, el
        //dinero obtenido viene dado por la fórmula del interés compuesto: Resultado = e(1+ i)n
        // Aplicarlo para calcular en cuanto se convierten 1.000 euros al cabo de 10 
        // años al 3% de interés anual.
        public static void Ejercicio17(double Euros, double Interes, double años)
        {
            double result = Euros * (1.0 + Interes) * años;
            System.Console.WriteLine("el interés anual es: " + result);
        }
        //(3.2.3.5) Crea un programa que muestre los primeros 20 valores de la función y =  x2 - 1
        public static void Ejercico18()
        {
            for (int i = 0; i <= 20; i++)
            {
                int y = (i * i) - 1;
                System.Console.WriteLine(y);
            }
            System.Console.WriteLine();
        }

        //(3.2.3.6) Crea un programa que "dibuje" la gráfica de y = (x-5)2 para valores de x 
        //entre 1 y 10. Deberá hacerlo dibujando varios espacios en pantalla y luego un
        //asterisco.La cantidad de espacios dependerá del valor obtenido para "y".
        public static void Ejercicio19()
        {

            for (int i = 0; i <= 30; i++)
            {
                int c = 10;
                int ASTERISCOS = (c * c) + (5 * i * c) + (i * i);
                for (c = 1; c <= ASTERISCOS; c++)
                {
                    System.Console.Write("*");

                }
                System.Console.Write("");

            }
            System.Console.WriteLine();
        }

        //(3.2.3.7) Escribe un programa que calcule una aproximación de PI mediante la 
        //expresión: pi/4 = 1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13 ... El usuario deberá
        //indicar la cantidad de términos a utilizar, y el programa mostrará todos los
        // resultados hasta esa cantidad de términos.Debes hacer todas las operacion con "double".
        public static double Ejercicio20(int n)
        {
            double denominador = 1.0;
            double result = 0.0;
            for (int i = 0; i < n; i++)
            {
                double NuevaFraccion = 1.0 / denominador;
                if ((i % 2) == 0)
                {
                    result += NuevaFraccion;
                    denominador += 2.0;
                }
                else
                {
                    result -= NuevaFraccion;
                    denominador += 2.0;
                }
                System.Console.WriteLine(result);

            }
            return 0;
        }

        //(3.2.4.1) Crea un programa que calcule la raíz cuadrada del número que
        //introduzca el usuario.La raíz se deberá calcular como "double", pero el resultado
        //se mostrará como "float"
        public static void Ejercicio21()
        {
            System.Console.WriteLine("Introduce un número para hacer su reíz cuadrada");
            double namber = System.Convert.ToDouble(System.Console.ReadLine());

            namber = System.Math.Sqrt(namber);
            float resultado = System.Convert.ToInt32(namber);

            System.Console.WriteLine("El resultado es: " + resultado + " y -" + resultado);
        }


        //(3.2.4.2) Crea una nueva versión del un programa que calcula una aproximación
        //de PI mediante la expresión: pi/4 = 1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13 (...) con
        //tantos términos como indique el usuario.Debes hacer todas las operacion con 
        //"double", pero mostrar el resultado como "float".
        public static float Ejercicio22(int n)
        {
            double denominador = 1.0;
            double result = 0.0;
            for (int i = 0; i < n; i++)
            {
                double NuevaFraccion = 1.0 / denominador;
                if ((i % 2) == 0)
                {
                    result += NuevaFraccion;
                    denominador += 2.0;
                }
                else
                {
                    result -= NuevaFraccion;
                    denominador += 2.0;
                }
                System.Console.WriteLine(System.Convert.ToSingle(result));
            }
            return 0;

        }
        //(3.2.5.1) El usuario de nuestro programa podrá teclear dos números de hasta 12 
        // cifras significativas.El programa deberá mostrar el resultado de dividir el primer
        // número entre el segundo, utilizando tres cifras decimales.
        public static void Ejercicio23()
        {
            try
            {
                System.Console.WriteLine("Introduce un número de hasta 12 cifras");
                double n1 = System.Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("Introduce un número de hasta 12 cifras");
                double n2 = System.Convert.ToInt32(System.Console.ReadLine());

                double resultado = n1 / n2;
                System.Console.WriteLine(resultado.ToString("N3"));

            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("HAS INTRODUCIDO UN ERROR");
            }
        }
        //(3.2.5.2) Crea un programa que use tres variables x,y,z. Las tres serán números 
        // reales, y nos bastará con dos cifras decimales.Se deberá pedir al usuario los
        //valores para las tres variables y mostrar en pantalla el valor de x2 + y - z(con
        //exactamente dos cifras decimales).
        public static void Ejercicio24()
        {
            try
            {
                System.Console.WriteLine("Introduce un número");
                float x = System.Convert.ToSingle(System.Console.ReadLine());
                System.Console.WriteLine("Introduce un número");
                float y = System.Convert.ToSingle(System.Console.ReadLine());
                System.Console.WriteLine("Introduce un número");
                float z = System.Convert.ToSingle(System.Console.ReadLine());

                float resultado = (x * x) + y - z;
                System.Console.WriteLine(resultado.ToString("N2"));
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("HAS INTRODUCIDO UN ERROR");
            }
        }
        //(3.2.5.3)Calcula el perímetro, área y diagonal de un rectángulo, a partir de su 
        // ancho y alto(perímetro = suma de los cuatro lados; área = base x altura; diagonal,
        //usando el teorema de Pitágoras). Muestra todos ellos con una cifra decimal.
        public static void Ejercicio25(double ancho, double alto)
        {
            double perimentro = (2 * ancho) + (2 * alto);
            double area = ancho * alto;
            double diagonal = System.Math.Sqrt((ancho * ancho) + (alto * alto));

            System.Console.WriteLine(" Este es el perimetro: " + perimentro.ToString("N1"));
            System.Console.WriteLine(" Este es el area : " + area.ToString("N1"));
            System.Console.WriteLine(" Este es la diagonal: " + diagonal.ToString("N1"));
        }
        //(3.2.5.4) Calcula la superficie y el volumen de una esfera, a partir de su radio 
        //(superficie = 4 * pi* radio al cuadrado; volumen = 4/3 * pi* radio al cubo). Usa
        // datos "doble" y muestra los resultados con 5 cifras decimales.
        public static void Ejercicio26(double radio)
        {
            double superficie = 4 * System.Math.PI * radio * radio;
            double volumen = (4 * System.Math.PI * radio * radio * radio) / 3;

            System.Console.WriteLine(" Este es el resultado de superficie: " + superficie.ToString("N5"));
            System.Console.WriteLine(" Este es el resultado de volumen: " + volumen.ToString("N5"));
        }

        //(3.2.6.1) Crea un programa que pida números (en base 10) al usuario y muestre su 
        // equivalente en sistema binario y en hexadecimal.Debe repetirse hasta que el
        //usuario introduzca el número 0
        public static void ejercicio27() // DUDILLA LA ULTIMA PARTE
        {
            int n = 1;
            while (n != 0)
            {
                System.Console.WriteLine("Introduce un número");
                n = System.Convert.ToInt32(System.Console.ReadLine());
                Console.WriteLine(Convert.ToString(n, 16));
                Console.WriteLine(Convert.ToString(n, 2));
            }
            System.Console.WriteLine("el programa a finalizado");
        }
        //(3.2.6.2) Crea un programa que pida al usuario la cantidad de rojo (por ejemplo, 
        //255), verde(por ejemplo, 160) y azul(por ejemplo, 0) que tiene un color, y que
        //muestre ese color RGB en notación hexadecimal(por ejemplo, FFA000).
        public static void Ejercicio28()
        {
            System.Console.WriteLine("Introduce de ROJO");
            int R = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Introduce de VERDE");
            int V = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Introduce de AZUL");
            int A = System.Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("este es el resultado en exadecimal: " + System.Convert.ToString(R, 16) + System.Convert.ToString(V, 16) + System.Convert.ToString(A, 16));

        }
        //(3.2.6.3) Crea un programa para mostrar los números del 0 a 255 en hexadecimal,
        //en 16 filas de 16 columnas cada una(la primera fila contendrá los números del 0 al
        //15 –decimal-, la segunda del 16 al 31 –decimal- y así sucesivamente).
        public static void Ejercicio29()
        {
            int c;
            int numero = 255;

            for (int i = 0; i <= numero; i++)
            {
                for (c = 1; c <= 16; c++)
                {
                    System.Console.Write(System.Convert.ToString(i, 16) + " ");
                    i++;
                }
                System.Console.WriteLine("\n");
            }
        }


        //(3.2.6.4) Crea un programa que pida números binarios al usuario y muestre su 
        //equivalente en sistema hexadecimal y en decimal. Debe repetirse hasta que el
        // usuario introduzca la palabra "fin".
        public static void Ejercicio30()
        {
            string n = "";
            while (n != "fin")
            {
                System.Console.WriteLine("Introduce un número binario");
                n = System.Convert.ToString(System.Console.ReadLine());
                int n1 = System.Convert.ToInt32(n, 2);
                System.Console.WriteLine(System.Convert.ToString(n1, 16));
                System.Console.WriteLine(System.Convert.ToString(n1, 10));
            }

        }
        //(3.3.1.1) Crea un programa que pida una letra al usuario y diga si se trata de una vocal.
        public static void Ejercicio31()
        {
            try
            {
                System.Console.WriteLine("Escribe una letra");
                char LETRA;
                switch (LETRA = System.Convert.ToChar(System.Console.ReadLine()))
                {
                    case 'a':
                        System.Console.WriteLine("has introducido una vocal: " + LETRA);
                        break;
                    case 'e':
                        System.Console.WriteLine("has introducido una vocal: " + LETRA);
                        break;
                    case 'i':
                        System.Console.WriteLine("has introducido una vocal: " + LETRA);
                        break;
                    case 'o':
                        System.Console.WriteLine("has introducido una vocal: " + LETRA);
                        break;
                    case 'u':
                        System.Console.WriteLine("has introducido una vocal: " + LETRA);
                        break;
                    case 'A':
                        System.Console.WriteLine("has introducido una vocal: " + LETRA);
                        break;
                    case 'E':
                        System.Console.WriteLine("has introducido una vocal: " + LETRA);
                        break;
                    case 'I':
                        System.Console.WriteLine("has introducido una vocal: " + LETRA);
                        break;
                    case 'O':
                        System.Console.WriteLine("has introducido una vocal: " + LETRA);
                        break;
                    case 'U':
                        System.Console.WriteLine("has introducido una vocal: " + LETRA);
                        break;
                    default:
                        System.Console.WriteLine("has introducido un TERMINO DISTINTO DE VOCAL: " + LETRA);
                        break;
                }
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("HAS INTRODUCIDO UN ERROR");
            }
        }
        //(3.3.1.2) Crea un programa que muestre una de cada dos letras entre la que teclee 
        //el usuario y la "z". Por ejemplo, si el usuario introduce una "a", se escribirá: "aceg...".
        public static void Ejercicio32()
        {
            System.Console.WriteLine("Escribe una letra");
            char LETRA = System.Convert.ToChar(System.Console.ReadLine());
            for (char i = 'a'; i >= LETRA; i++)
            {
                if ((i % 2) == 0)
                {
                    System.Console.WriteLine(i);
                }
                else
                {
                    System.Console.WriteLine(i);
                }
            }
        }
        // Crea un programa que pida al usuario el ancho(por ejemplo, 4) y el alto
        //(por ejemplo, 3) y una letra(por ejemplo, X) y escriba un rectángulo formado por
        //esa cantidad de letras:
        //XXXX
        //XXXX
        //XXXX
        public static void Ejercicio33()
        {
            System.Console.WriteLine("Introduce el ancho");
            int Ancho = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Introduce el largo");
            int Largo = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Escribe una letra");
            char LETRA = System.Convert.ToChar(System.Console.ReadLine());

            for (int i = 1; i <= Ancho; i++)
            {
                for (int c = 1; c <= Largo; c++)
                {

                    System.Console.Write(LETRA);
                }
                System.Console.WriteLine("");
            }

        }
        //(3.3.2.1) Crea un programa que pida al usuario que teclee cuatro letras y las 
        // muestre en pantalla juntas, pero en orden inverso, y entre comillas dobles.Por
        //ejemplo si las letras que se teclean son a, l, o, h, escribiría "hola".
        public static void ejercicio34()
        {
            System.Console.WriteLine("Introduce el ancho");
            int Ancho = System.Convert.ToInt32(System.Console.ReadLine());
        }
        //(3.4.1) Crear un programa que pida al usuario su nombre, y le diga "Hola" si se 
        //llama "Juan", o bien le diga "No te conozco" si teclea otro nombre.
        public static void ejercicio35()
        {
            System.Console.WriteLine("Introduce el nombre");
            string nombre = System.Convert.ToString(System.Console.ReadLine());
            if (nombre.Equals("Juan"))
            {
                System.Console.WriteLine("Hola");
            }
            else
            {
                System.Console.WriteLine("No te conozco");
            }
        }
        //Crear un programa que pida al usuario un nombre y una contraseña. La 
        //contraseña se debe introducir dos veces.Si las dos contraseñas no son iguales, se
        //avisará al usuario y se le volverán a pedir las dos contraseñas.
        public static void Ejercicio36()
        {
            string contraseña;
            string contraseña1;
            System.Console.WriteLine("Introduce el nombre");
            string nombre = System.Convert.ToString(System.Console.ReadLine());
            System.Console.WriteLine("Introduce la contraseña");
            contraseña = System.Convert.ToString(System.Console.ReadLine());
            System.Console.WriteLine("Introduce otra vez la contraseña");
            contraseña1 = System.Convert.ToString(System.Console.ReadLine());

            while (!contraseña.Equals(contraseña1))
            {
                System.Console.WriteLine("no es correcto");

                System.Console.WriteLine("Introduce la contraseña");
                contraseña = System.Convert.ToString(System.Console.ReadLine());
                System.Console.WriteLine("Introduce otra vez la contraseña");
                contraseña1 = System.Convert.ToString(System.Console.ReadLine());
            }
            System.Console.WriteLine("correcto");
        }
        //(3.5.1) Crea un programa que use el operador condicional para dar a una variable 
        //llamada "iguales" (booleana) el valor "true" si los dos números que ha tecleado el
        //usuario son iguales, o "false" si son distintos.
        public static void Ejercicio37()
        {
            try
            { 
                System.Console.WriteLine("Pon el primer número:");
                double a = System.Convert.ToDouble(System.Console.ReadLine());
                System.Console.WriteLine("Pon el segundo numero número:");
                double b = System.Convert.ToDouble(System.Console.ReadLine());

                bool iguales = true;

                iguales = a == b;
                System.Console.WriteLine(iguales);
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("HAS INTRODUCIDO UN ERROR");
            }

        }
        //(3.5.2) Crea una versión alternativa del ejercicio 3.5.1, que use "if" en vez del operador condicional.
        public static void Ejercicio38()
        {
            try
            { 
                System.Console.WriteLine("Pon el primer número:");
                double a = System.Convert.ToDouble(System.Console.ReadLine());
                System.Console.WriteLine("Pon el segundo numero número:");
                double b = System.Convert.ToDouble(System.Console.ReadLine());

                if (a == b)
                {
                    System.Console.WriteLine("True");
                }
                else
                {
                    System.Console.WriteLine("False");
                }
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("HAS INTRODUCIDO UN ERROR");
            }
        }
        //(3.5.3) Crea un programa que use el operador condicional para dar a una variable 
        // llamada "ambosPares" (booleana) el valor "true" si dos números introducidos por
        //  el usuario son pares, o "false" si alguno es impar.
        public static void Ejercicio39()
        {
            try
            {
                System.Console.WriteLine("Pon el primer número:");
                double a = System.Convert.ToDouble(System.Console.ReadLine());
                System.Console.WriteLine("Pon el segundo numero número:");
                double b = System.Convert.ToDouble(System.Console.ReadLine());

                bool ambosPares = true;

                ambosPares = ((a % 2) == 0) && ((b % 2) == 0);

                System.Console.WriteLine("¿ Los números introducidos son pares? " + ambosPares);
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("HAS INTRODUCIDO UN ERROR");
            }


        }
            // Crea una versión alternativa del ejercicio 3.5.3, que use "if" en vez del  operador condicional.
        public static void Ejercicio40()
            {
                try
                {

                    System.Console.WriteLine("Pon el primer número:");
                    double a = System.Convert.ToDouble(System.Console.ReadLine());
                    System.Console.WriteLine("Pon el segundo numero número:");
                    double b = System.Convert.ToDouble(System.Console.ReadLine());

                    if (((a % 2) == 0) && ((b % 2) == 0))
                    {
                        System.Console.WriteLine("¿Los números introducidos son pares?  True");
                    }
                    else
                    {
                        System.Console.WriteLine("¿Los números introducidos son pares?  False");
                    }
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine("HAS INTRODUCIDO UN ERROR");
                }
            }

        
    }
}



