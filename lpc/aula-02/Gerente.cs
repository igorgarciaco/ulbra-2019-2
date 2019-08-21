namespace aula_02
{
    public class Gerente
    {
        public Gerente(int id, string nome, double salario)
        {
            this.id = id;
            this.nome = nome;
            this.salario = salario;

        }
        public int id { get; set; }
        public string nome { get; set; }
        public double salario { get; set; }
        public void AumentaSalario() => this.salario += this.salario * 0.1;

        public void AumentaSalario(double taxa) => this.salario += this.salario * taxa;

    }
}