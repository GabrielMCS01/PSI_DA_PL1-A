using System;
using System.Collections.Generic;

namespace GestaoCamaraMunicipal
{
    public partial class Processo
    {
        public Processo(DateTime dataInicio, int promotorNIF)
        {
            this.Projeto = new HashSet<Projeto>();
            this.DataInicio = dataInicio;
            this.PromotorNIF = promotorNIF;
        }
        public override string ToString()
        {
            return string.Format("{0}\t {1} ({2})", this.Id, this.DataInicio.ToString(), this.PromotorNIF);
        }
    }
}
