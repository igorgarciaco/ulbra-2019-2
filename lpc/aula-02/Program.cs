using System;

namespace aula_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta objContaDoJoao = new Conta(1234, new Correntista(001, "João da Silva"), 400);

            objContaDoJoao.Depositar(1000);
            write($"Saldo do Joao é {objContaDoJoao.saldo}");
            objContaDoJoao.Sacar(200);
            write($"Saldo do Joao é {objContaDoJoao.saldo}");

            write ($"Consulta de saldo: {objContaDoJoao.saldo}");


            Cartao cartao = new Cartao(987654321, new DateTime(2020, 12, 10));

            write($"{cartao.validade.ToString("yyyy-MM")}");
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
