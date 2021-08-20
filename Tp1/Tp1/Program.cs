using System;

namespace Tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            mostrarNumerosDivisiblesPorCincoYDos();
        }


        //static void mostrarnumerosdivisiblesporcincoydos()
        //{
        //    for (int i = 1; i <= 100; i++)
        //    {
        //        if (i % 2 == 0 && i % 5 == 0)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}

        //static void mostrarNumerosDivisiblesPorCincoYDos()
        //{
        //    int i = 1;
        //    while ( i <= 100)
        //    {
        //        if (i % 2 == 0 && i % 5 == 0)
        //            Console.WriteLine(i);
        //        i++;
        //    }
        //}


        static void mostrarNumerosDivisiblesPorCincoYDos()
        {

            int i = 1;
            do
            {
                if (i % 2 == 0 && i % 5 == 0)
                    Console.WriteLine(i);
                i++;
            } while (i <= 100);
        }

    }
}
