using System;

namespace NumeroPar
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = ingresarNumero();
            Console.WriteLine( esPar(number) );

        }
        static int ingresarNumero()
        {
            try
            {
                Console.WriteLine("Ingrese un numero aleatorio:");
                int number = Convert.ToInt32(Console.ReadLine());
                return number;
            }
            catch (System.FormatException)
            {
                return ingresarNumero();
            }
        }

        static bool esPar(int numero)
        {
            return (numero % 2 == 0) ? true:false; 
        }
    }
}
