using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            String fecha = "7/8/2014";

            // mediante el lenght obtendremos la longitud de la cadena
            Console.WriteLine(fecha.Length);

            // mediante el metodo contains podremos saber si la cadena contiene o no un determinado carcter
            Console.WriteLine(fecha);
            Console.WriteLine("Contiene el carcter " + "/ : " + (( fecha.Contains('/') )? "si":"no"));

            // podemos realizar la busqueda de un caracter usando indexOf, si loe encuentra devolvera la posicion de la primera ocurrencia, en caso contrario devolvera un -1 
            Console.WriteLine("Posicion del " + "/ : " + fecha.IndexOf('/'));
            Console.WriteLine("Posicion del " + "- : " + fecha.IndexOf('-'));

            // podemos remover un conjunto de caracteres indicandole el lugar donde empieza, y la cantidad de caracteres a cortar
            Console.WriteLine(fecha.Remove(0, 4));

            // si queremos cambiar cierto caracter, podemos hacer uso de Replace
            Console.WriteLine(fecha.Replace("/", "-"));

            // podemos obtener una sub cadena ingresandole la posicion incial, y de forma opcional la ngitud que tendra.
            Console.WriteLine(fecha.Substring(4));

            // podremos concatenar de la siguiente forma
            String genero = "reggueton";
            String detalle = "la musica es del genero ";

            Console.WriteLine(detalle + genero);

            // si necesitaramos normalizar la entrada de algun nombre o campo que sea alfanumerico
            // podemos hacer uso de los metodos to ToUpper o Tolower
            String opcionElegida = "a";

            if(opcionElegida.ToUpper() == "A")
            {
                Console.WriteLine("La opcion elegida es: " + opcionElegida.ToUpper());
            }


        }
    }
}
