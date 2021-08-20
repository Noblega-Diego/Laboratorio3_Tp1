using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            mostrarOperaciones();
            elegirOperacion();
        }

        private static void elegirOperacion()
        {
            string opcion;
            Console.WriteLine("ingrese la opcion:");
            opcion = Console.ReadLine();
            switch (opcion) {
                case "a":
                    calcular("+");
                    break;
                case "b":
                    calcular("-");
                    break;
                case "c":
                    calcular("*");
                    break;
                case "d":
                    calcular("/");
                    break;
                case "e":
                    calcular("%");
                    break;
                default:
                    Console.WriteLine("La operacion elegida no es valida");
                    elegirOperacion();
                    break;
            }
        }

        private static void mostrarOperaciones()
        {
            Console.WriteLine("a- Suma +");
            Console.WriteLine("b- Resta –");
            Console.WriteLine("c- Multiplicación *");
            Console.WriteLine("d- División /");
            Console.WriteLine("e- Modulo %");
        }


        private static void calcular(string operacion)
        {
            double numeroOne = ingresarDouble();
            double numeroTwo = ingresarDouble();
            
            double resultado = sumar(numeroOne, numeroTwo);
            switch (operacion)
            {
                case "+":
                    resultado = sumar(numeroOne, numeroTwo);
                    break;
                case "-":
                    resultado = restar(numeroOne, numeroTwo);
                    break;
                case "*":
                    resultado = multiplicar(numeroOne, numeroTwo);
                    break;
                case "/":
                    resultado = dividir(numeroOne, numeroTwo);
                    break;
                case "%":
                    resultado = obtenerModulo(numeroOne, numeroTwo);
                    break;

            }
            Console.WriteLine("El resultado de " + numeroOne + " "+operacion+" " + numeroTwo + ": " + resultado);
        }


        private static double obtenerModulo(double numeroOne, double numeroTwo)
        {
            return numeroOne * numeroTwo;
        }

        private static double restar(double numeroOne, double numeroTwo)
        {
            return numeroOne * numeroTwo;
        }

        private static double sumar(double numeroOne, double numeroTwo)
        {
            return numeroOne + numeroTwo;
        }

        private static double dividir(double numeroOne, double numeroTwo)
        {
            return numeroOne / numeroTwo;
        }


        private static double multiplicar(double numeroOne, double numeroTwo)
        {
            return numeroOne * numeroTwo;
        }

        static double ingresarDouble()
        {
            try
            {
                Console.WriteLine("Ingrese un numero:");
                double number = Convert.ToDouble(Console.ReadLine());
                if (number >= 0 && number <= 100)
                    return number;
                else
                    return ingresarDouble();
            }
            catch (System.FormatException)
            {
                return ingresarDouble();
            }
        }

    }
}
