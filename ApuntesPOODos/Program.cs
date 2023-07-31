using System;

namespace ApuntesPOODos{

    class Program{
        static void Main(string[] args){

            //CrearCoche();
            //CrearMoto();
            Banco banco1 = new Banco();
            banco1.Operar();
            banco1.DepositosTotales();
            Console.ReadKey();
        }

        static void CrearCoche(){
            Coche autoOne = new Coche(); //instanciacion. Se dio un estado inicial al autoOne. Se hace uso del constructor.

            Console.WriteLine(autoOne.getInfoCoche());
            System.Console.WriteLine(autoOne.getExtras());

            Coche autoTwo = new Coche(4000.5, 1500.3);

            Console.WriteLine(autoTwo.getInfoCoche());

            autoTwo.setExtras(true, "Piel");
            System.Console.WriteLine(autoTwo.getExtras());
        }

        static void CrearMoto(){
            Moto moto1 = new Moto();
            Moto moto2 = new Moto(2000, "Rojo");

            System.Console.WriteLine(moto1.getCaracteristicas());
            System.Console.WriteLine(moto2.getCaracteristicas());
        }
    }
}