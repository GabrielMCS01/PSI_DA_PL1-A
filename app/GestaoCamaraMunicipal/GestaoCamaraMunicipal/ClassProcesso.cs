using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCamaraMunicipal
{
    public partial class Processo
    {
        public Processo(DateTime dataInicio, int promotorNIF, int estadoProcessoId)
        {
            this.Projeto = new HashSet<Projeto>();
            this.DataInicio = dataInicio;
            this.PromotorNIF = promotorNIF;
            this.EstadoProcessoId = estadoProcessoId;
        }
        public override string ToString()
        {
            return string.Format("{0}\t{1} ({2})", this.Id, this.DataInicio.ToString(), this.PromotorNIF);
        }
    }
}
