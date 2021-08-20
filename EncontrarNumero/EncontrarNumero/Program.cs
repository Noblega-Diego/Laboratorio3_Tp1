using System;

namespace EncontrarNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0, numeroRandom, numeroIngresado;

            numeroRandom = generarNumeroRandom();
            bool esCorrecto = false;
            do {
                contador ++;
                numeroIngresado = ingresarNumero();

                if(numeroIngresado == numeroRandom)
                {
                    Console.WriteLine("Respuesta: numero encontrado: " + numeroRandom);
                    Console.WriteLine("Cantidad de intentos necesarios: " + contador);
                    esCorrecto = true;
                }else if(numeroIngresado < numeroRandom)
                {
                    Console.WriteLine("Respuesta: Es muy abajo");
                }else if(numeroIngresado > numeroRandom)
                {
                    Console.WriteLine("Respuesta: Es muy arriba");
                }

            } while (! esCorrecto);

        }

        static int ingresarNumero()
        {
            try
            {
                Console.WriteLine("Ingrese un numero entre 0 y 100:");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number >= 0 && number <= 100)
                    return number;
                else
                    return ingresarNumero();
            }
            catch (System.FormatException)
            {
                return ingresarNumero();
            }
        }

        static int generarNumeroRandom()
        {
            return new Random().Next(0, 101);
        }
    }
}
