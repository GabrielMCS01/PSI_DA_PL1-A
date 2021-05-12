using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCamaraMunicipal
{
    public partial class TipoProjeto
    {
        public TipoProjeto(int nDias)
        {
            this.Projeto = new HashSet<Projeto>();
            this.Especialista = new HashSet<Especialista>();
            this.NrDiasAprovacao = nDias;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} ({2} dias de aprovação)", this.Projeto, this.Especialista, this.NrDiasAprovacao);
        }
    }
}
