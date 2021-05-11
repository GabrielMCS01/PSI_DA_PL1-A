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
    }
}
