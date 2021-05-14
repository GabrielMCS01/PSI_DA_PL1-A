using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCamaraMunicipal
{
    public partial class TipoProjeto
    {
        public TipoProjeto(string designacao, int nDias, int TipoProjetoDependente)
        {
            this.Projeto = new HashSet<Projeto>();
            this.Especialista = new HashSet<Especialista>();
            this.NrDiasAprovacao = nDias;
            this.Designacao = designacao;
            this.TipoProjetoId = TipoProjetoDependente;
        }

        public TipoProjeto(string designacao, int nDias)
        {
            this.Projeto = new HashSet<Projeto>();
            this.Especialista = new HashSet<Especialista>();
            this.NrDiasAprovacao = nDias;
            this.Designacao = designacao;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} ({2} dias de aprovação)", this.Projeto, this.Especialista, this.NrDiasAprovacao);
        }
    }
}
