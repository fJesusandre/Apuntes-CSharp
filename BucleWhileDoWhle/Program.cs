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

                try
                {
                    miNumero = int.Parse(Console.ReadLine());
                }
                /* 
                // Para poder capturar todas las excepciones pero ademas queremos capturar una en especifico y darle un trato especial, primero se
                // se debe de poner el catch con la excepcion en especifico y despues el catch con la clase Excepcion para capturar todas las demas en general.
                // De manera inversa el codigo generara error.
                // Primeros especificos, al final los genericos.

                catch(FormatException ex) 
                {
                    Console.WriteLine("No has introducido un valor numerico valido.\nIntentalo de nuevo: ");
                    miNumero= 101;
                    intentos--;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("El numero que introduciste es muy grande. Introduce un numero entre el rango permitido (0 - 100).");
                    miNumero = 101;
                    intentos--;
                }
                 catch (Exception ex o e) 
                {
                    codigo
                }
                 */

                // Otra forma de lo anterior pero mas nuevo, pro y elegante.
                //Captura de  excepciones con filtro.

                catch (Exception e) when (e.GetType() != typeof(FormatException)) // cuando la exccepcion que capturaste sea diferente de esta excepcion en especifico, realiza esto.
                {
                    Console.WriteLine("Ha ocurrido un error. Intenta de nuevo:");
                    miNumero = 101;
                    intentos--;
                }
                catch(FormatException e) 
                {
                    Console.WriteLine("Has introducido texto idiota, ingresa un numero. Intenta de nuevo:");
                    miNumero = 101;
                    intentos--;
                }

                if (miNumero > numeroAleatorio && miNumero != 101) Console.WriteLine("El No. es mas bajo");
                else if (miNumero < numeroAleatorio) Console.WriteLine("El No. es mas alto");

            } while (numeroAleatorio != miNumero);

            Console.WriteLine($"Correcto! Has acertado al intento No. {intentos}");
            Console.ReadKey();
        }
    }
}