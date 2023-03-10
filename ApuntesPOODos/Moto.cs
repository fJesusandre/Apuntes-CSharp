using System;

namespace ApuntesPOODos {
    partial class Moto{
        private int ruedas;
        private string color;
        private double largo;

        public Moto(){
            ruedas = 2;
            color = "gris";
            largo = 1500;
        }

        public Moto(double largo, string color){
            this.largo = largo;
            this.color = color;
            ruedas = 2;
        }
    }

    partial class Moto{
        public string getCaracteristicas(){
            return $"Caracteristicas de la moto:\n\nColor: {color}\nLargo: {largo}";
        }
    }
}