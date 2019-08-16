using System;

namespace aula_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta objContaDoJoao = new Conta(1234, new Correntista(001, "João da Silva"));

            objContaDoJoao.Depositar(1000);
            write($"Saldo do Joao é {objContaDoJoao.saldo}");
            objContaDoJoao.Sacar(200);
            write($"Saldo do Joao é {objContaDoJoao.saldo}");

        }

        static void write(string msg){
            Console.WriteLine(msg);
        }

        static void read(){
            Console.ReadLine();
        }
    }
}

// o que é metodo estatico, quando utilizar porque utilizar prova cassio
