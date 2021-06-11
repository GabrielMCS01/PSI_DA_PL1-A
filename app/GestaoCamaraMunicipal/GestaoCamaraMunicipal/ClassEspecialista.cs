namespace GestaoCamaraMunicipal
{
    public partial class Especialista
    {
        public Especialista()
        {

        }

        public Especialista(Funcionario funcionario, TipoProjeto tipoprojeto)
        {
            this.Funcionario = funcionario;
            this.TipoProjeto = tipoprojeto;
        }

        public override string ToString()
        {
            return string.Format("{0}", Funcionario);
        }
    }
}
