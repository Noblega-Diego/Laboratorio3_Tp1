using System;

namespace ejercico6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero:");
            int numero = Convert.ToInt32( Console.ReadLine() );
            Rec(numero);
        }

        static void Rec(long num)
        {

            if(num <= 100000000)
            {
                Console.WriteLine(num +" * "+ num +" = "+ num*num);
                Rec(num * num);
            }
            else
                Console.WriteLine("Fin");
            
        }
    }
}
