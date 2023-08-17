namespace CondicionalesIfSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que parte quiere ejecutar:\n\nOpcion 1:\nCondicional if\n\nOpcion 2:\nCondicional Switch");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1) condicionalIf();
            else if (opcion == 2) condicionalSwitch();
            else Console.WriteLine("Selecciona una opcion correcta.");

            Console.ReadKey();
        }

        static void condicionalIf()
        {
            Console.WriteLine("Introduce tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            //Forma opcional de simplificarlo solo con una linea de codigo. Mas de una linea de codigo es necesario las llaves.
            if (edad < 18) Console.WriteLine("Eres un infante");
            else if (edad < 30) Console.WriteLine("Eres joven");
            else if (edad < 60) Console.WriteLine("Eres un viejo");
            else Console.WriteLine("Eres un anciano bro, wft.");
        }

        static void condicionalSwitch()
        {
            //Switch

            /* 
            Solo se puede usar el switch para evaluar:
            - int
            - char
            - string

            float y double han de utilizar if.

            Todos los case y el default deben llevar su break. Se puede utilizar return y throw.
             */

            Console.WriteLine("Elige un medio de transporte (Coche, tren, avion): ");
            string transporte = Console.ReadLine();

            switch (transporte)
            {
                case "coche":
                    Console.WriteLine("Medio de transporte seleccionado: coche.");
                    break;

                case "tren":
                    Console.WriteLine("Medio de transporte seleccionado: tren.");
                    break;

                case "avion":
                    Console.WriteLine("Medio de transporte seleccionado: avion.");
                    break;

                default:
                    Console.WriteLine("Sin medio de transporte");
                    break;

            }
        }

    }
}