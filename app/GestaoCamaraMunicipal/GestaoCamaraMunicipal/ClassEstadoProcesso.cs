using System.Collections.Generic;

namespace GestaoCamaraMunicipal
{
    public partial class EstadoProcesso
    {
        public EstadoProcesso(string descricaoEstado)
        {
            this.Processo = new HashSet<Processo>();
            this.DescricaoEstado = descricaoEstado;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}", this.Id, this.DescricaoEstado);
        }
    }
}
