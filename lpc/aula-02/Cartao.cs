using System;

namespace aula_02
{
    public class Cartao
    {
        public Cartao(int numero, DateTime validade)
        {
            this.numero = numero;
            this.validade = validade;

        }

        public long numero { get; private set; }
        public DateTime validade { get; private set; }
        public Correntista cliente { get; set; }

    }
}