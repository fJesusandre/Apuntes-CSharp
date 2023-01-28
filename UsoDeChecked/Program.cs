namespace UsoDeChecked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            int numero = int.MaxValue;
            int resultado = numero + 20;

            Console.WriteLine(resultado); 

            El programa deberia de fallar debido a que no se puede superar el limite de almacenamiento
            de un entero, pero aun asi el programa sigue corriendo, mostrando un resultado erroneo**.
               
            Esto se debe a que el compilador de C# lo hace por rendimiento, para que el programa no tenga
            que detenerse. Para que nos muestre el error o la excepcion se debe usar checked{}.

            **El desbordamiento (Overflow) en este caso del "maxValue "no es un error, de hecho esa es la respuesta correcta. 
            -2147483629 es el numero que se sigue al entero una vez alcanza su tope. El valor int 2147483629 es el 
            MAXIMO VALOR POSITIVO, pero los int tambien almacenan numeros negativos, por lo tanto, la capacidad 
            maxima de un valor INT es 2147483629 * 2 , osea, 4294967295 que es la capacidad maxima que permiten los 
            uint32, que son básicamente los enteros que solo pueden almacenar números positivos. 
            En el caso del video, cuando le sumamos el valor +20 al entero, lo que sucede es que la posicion en memoria 
            del numero se mueve 20 posiciones (los números empieza 1, 2 , 3, 4, 5 ,... 2147483629, -2147483629, -2147483628, 
            -2147483627,...., -2000...., -5, -4, -3, -2, -1, 0.) No es que el programa no "sepa que hacer", sino que al 
            sobrepasar la capacidad de enteros positivos, comienza en memoria la parte donde se almacenan los negativos, 
            por ende, sale ese resultado. Es importante entender debajo de todo el framework, que esta pasando en memoria al 
            declarar valores numéricos, pues cada uno tiene una capacidad diferente, y por tanto una organización distinta en memoria.
             
            checked
            {
                int numero = int.MaxValue;
                int resultado = numero + 20;

                Console.WriteLine(resultado);
            }*/
            /*
                         Visual Studio permite configurarlo para no tener que estar programando un checked a cada rato.
                        Ver a partir del minuto 17:33 del video 24 del curso.
                        Configuracion, compilacion, avanzadas y activar opcion de comprobar desbordamiento y subdesbordamiento aritmetico.

                        forma abreviada checked(numero + 20) y unchecked(numero + 20). Esto solo funciona con Int y Long.
                         */
            int numeroMes = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(NombreDelMes(numeroMes);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Mensaje de la excepcion: {ex.Message}");
            }
            
            Console.ReadKey();
        }

        public static string NombreDelMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}