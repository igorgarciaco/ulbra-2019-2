using System.Collections.Generic;

namespace aula04ExercicioDC
{
    public  class Material
    {
        public Material(){}

        public Material(int codigo, string assunto)
        {
            this.codigo = codigo;
            this.assunto = assunto;

        }
        public int codigo { get;  set; }
        public string assunto { get;  set; }
        public List<Reserva> reservas { get; set; }

        public virtual Material MostrarDetalhes()
        {
            return null;
        }
        
    }
}