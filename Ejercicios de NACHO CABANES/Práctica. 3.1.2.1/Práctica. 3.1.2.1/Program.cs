using System;
//(3.1.2.1) Pregunta al usuario su edad, que se guardará en un "byte". A
//continuación, le deberás decir que no aparenta tantos años (por ejemplo, "No
//aparentas 20 años")

namespace Práctica._3._1._2._1
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("¿Cuántos años tienes?");
            byte edad = System.Convert.ToByte(System.Console.ReadLine());
            Console.WriteLine("No aparentas tener " + edad +" años");
        }
    }
}
