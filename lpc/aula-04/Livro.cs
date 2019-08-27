namespace aula04ExercicioDC
{
    public class Livro : Material
    {
        public Livro(int codigo, string assunto, string editora) 
            : base(codigo,assunto)
        {
            this.editora = editora;

        }
        public string editora { get; set; }

    }
}