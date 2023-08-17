using System;

namespace ApuntesPOODos
{
    public class Customer
    {
        private string nombre;
        private int monto;

        public Customer(string nom)
        {
            nombre = nom;
            monto = 0;
        }

        public void Depositar(int m)
        {
            monto = monto + m;
        }

        public void Extraer(int m)
        {
            monto = monto - m;
        }

        public int RetornarMonto()
        {
            return monto;
        }

        public void Imprimir()
        {
            Console.WriteLine($"{nombre} tiene depositado un total de {monto}");
        }
    }

    public class Banco
    {
        private Customer customer1, customer2, customer3;

        public Banco()
        {
            customer1 = new Customer("Juan");
            customer2 = new Customer("Ana");
            customer3 = new Customer("Pedro");
        }

        public void Operar()
        {
            customer1.Depositar(100);
            customer2.Depositar(150);
            customer3.Depositar(200);
            customer3.Extraer(150);
        }

        public void DepositosTotales()
        {
            int t = customer1.RetornarMonto() + customer2.RetornarMonto() + customer3.RetornarMonto();
            Console.WriteLine($"Total de dinero resguardado por el banco es {t}");
            customer1.Imprimir();
            customer2.Imprimir();
            customer3.Imprimir();
        }

    }

}