using System.Diagnostics;

namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numeros = new int[4];
            int[] numeros = { 12, 34, 543, 3};
            //Circulo[] circulos = new Circulo[10];
            Circulo[] circulos = { new Circulo(30), new Circulo(15), new Circulo(25)};

            for (int i = 0; i < circulos.Length; i++)
            {
                Console.WriteLine(circulos[i].radio);
            }

            foreach (Circulo circulo in circulos) 
            {
                Console.WriteLine($"El radio de este circulo es: {circulo.radio}");
            }

            var circulos2 = Inicializar();
            Console.WriteLine(circulos2[2]);
        }

        static void GenerarReporte(Circulo[] circulos)
        {

        }

        static int[] Inicializar()
        {
            Console.WriteLine("Numero de circulos: ");  
            string entrada = Console.ReadLine();
            int cantidad = int.Parse(entrada);

            int[] circulos = new int[cantidad];

           for(int i = 0;i < circulos.Length; i++)
            {
                Console.WriteLine("Radio para el circulo: ");
                entrada = Console.ReadLine();
                int radio = int.Parse(entrada);

                circulos[i] = radio;    
            }

           return circulos;

        }
    }
}