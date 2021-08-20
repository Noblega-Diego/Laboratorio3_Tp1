using System;

namespace CalculoDeSueldos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la hora de inicio con formato hh:mm :");
            int[] horaDeIngreso = pedirTime();
            Console.WriteLine("Ingrese la hora de salida con formato hh:mm :");
            int[] horaDeSalida = pedirTime();

            int ingreso = convertir(horaDeIngreso);
            int egreso = convertir(horaDeSalida);
            double totalAPagar = 0;
            int cantTiempoTrabajado = egreso - ingreso;
            if (cantTiempoTrabajado <= 8 * 60)
            {
                if (ingreso >= 8 * 60)
                {
                    totalAPagar = (cantTiempoTrabajado / 60) * 10;
                }
                else
                {
                    totalAPagar = (cantTiempoTrabajado / 60) * 15;
                }
            } else
                Console.WriteLine("Maximo de horas de trabajo exedido");
            Console.WriteLine("Total a pagar:" + totalAPagar);
        }


        private static int convertir(int[] horaDeIngreso)
        {
            return (horaDeIngreso[0] * 60) + horaDeIngreso[1];
        }

        private static int[] pedirTime()
        {

            String inputData = Console.ReadLine();
            if( inputData.Split(':').Length == 2)
            {
                try 
                {
                    String[] hourAndMinutes = inputData.Split(':');
                    int hora = Convert.ToInt32( hourAndMinutes[0] );
                    int minuto = Convert.ToInt32( hourAndMinutes[1] );
                    if( hora >= 0 && hora < 24 &&
                        minuto >= 0 && minuto < 60)
                    {
                        int[] time = { hora, minuto };
                        return time;
                    }

                }
                catch
                {
                    return pedirTime();
                }
            }

            return pedirTime();
        }
    }
}
