using System;

namespace aula_02
{
    public class Conta
    {
        public Conta(int numero, Correntista correntista, double saldo)
        {
            this.numero = numero;
            this.correntista = correntista;
            this.saldo = saldo;
            this.limite = limite;

        }
        public int numero { get; private set; }
        public Correntista correntista { get; private set; }
        public double saldo { get; private set; }
        public double limite { get; private set; }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void Sacar(double valor)
        {
            saldo -= valor;
        }

        public void Consulta()
        {
            Console.WriteLine($"Saldo do Joao é {saldo}");
        }

        public void Saque(double valor)
        {
            this.saldo += valor;
        }

        

    }
}