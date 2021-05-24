using System.Collections.Generic;

namespace GestaoCamaraMunicipal
{
    public partial class TipoDocumento
    {
        public TipoDocumento(string designacao)
        {
            this.Documento = new HashSet<Documento>();
            Designacao = designacao;
        }

        public override string ToString()
        {
            return string.Format("{0}", Designacao);
        }
    }
}
