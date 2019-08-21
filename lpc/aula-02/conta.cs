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
        public void Transferencia(Conta destinatario, double valor)
        {
            this.Sacar(valor);
            destinatario.Depositar(valor);
        }
        public void AumentaLimite(double limite)
        {
            this.limite += limite;
        }
        public void DiminuiLimite(double limite)
        {
            this.limite -= limite;
        }
    }
}