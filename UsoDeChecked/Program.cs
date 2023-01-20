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
             de un entero, pero aun asi el programa sigue corriendo, mostrando un resultado erroneo.
               
             Esto se debe a que el compilador de C# lo hace por rendimiento, para que el programa no tenga
             que detenerse. Para que nos muestre el error o la excepcion se debe usar checked{}.

            */
            checked
            {
                int numero = int.MaxValue;
                int resultado = numero + 20;

                Console.WriteLine(resultado);
                
            }

            /*
             Visual Studio permite configurarlo para no tener que estar programando un checked a cada rato.
            Ver a partir del minuto 17:33 del video 24 del curso.
            Configuracion, compilacion, avanzadas y activar opcion de comprobar desbordamiento y subdesbordamiento aritmetico.
             */


            Console.ReadKey();
        }
    }
}