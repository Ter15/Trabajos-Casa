using System;
//(3.1.2.2) Pide al usuario dos números de dos cifras ("byte"), calcula su
//multiplicación, que se deberá guardar en un "ushort", y muestra el resultado en
//pantalla.

namespace Práctica._3._1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Introduce un número de dos cifras");
                byte n1 = System.Convert.ToByte(System.Console.ReadLine());
                System.Console.WriteLine("Introduce un número de dos cifras");
                byte n2 = System.Convert.ToByte(System.Console.ReadLine());

                ushort resultado = System.Convert.ToByte(n1 * n2);

                System.Console.WriteLine("El resultado es: " + resultado);
            }               
            catch (System.Exception e)
            {
                System.Console.WriteLine("error");
            }
        }
    }
}
