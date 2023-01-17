namespace BucleWhileDoWhle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();   
            int numeroAleatorio = numero.Next(0, 100);

            int miNumero;
            //int miNumero = 101;

            int intentos = 0;

            Console.WriteLine("Introduce un No. entre 0 y 100");

            /*
            while (numeroAleatorio != miNumero)
            {
                intentos++;

                miNumero = int.Parse(Console.ReadLine());

                if (miNumero > numeroAleatorio) Console.WriteLine("El No. es mas bajo");
                if (miNumero < numeroAleatorio) Console.WriteLine("El No. es mas alto");
            }
            */

            //Bucle Do While

            /*
            El bucle Do While ejecutara el codigo de su interior al menos una vez, 
            aunque la condicion sea false. 
             */
           
            do{
                intentos++;

                miNumero = int.Parse(Console.ReadLine());

                if (miNumero > numeroAleatorio) Console.WriteLine("El No. es mas bajo");
                if (miNumero < numeroAleatorio) Console.WriteLine("El No. es mas alto");
            } while (numeroAleatorio != miNumero);

            Console.WriteLine($"Correcto! Has acertado al intento No. {intentos}");
            Console.ReadKey();
        }
    }
}