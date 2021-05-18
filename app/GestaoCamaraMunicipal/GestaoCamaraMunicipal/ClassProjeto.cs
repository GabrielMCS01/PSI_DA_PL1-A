using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCamaraMunicipal
{
    public partial class Projeto
    {
        public Projeto(string estadoProjeto, int tipoProjeto, DateTime DataAprovacao, int processo)
        {
            this.Documento = new HashSet<Documento>();
            this.Parecer = new HashSet<Parecer>();
            this.ProjetoAtribuido = new HashSet<ProjetoAtribuido>();
            this.EstadoProjeto = estadoProjeto;
            this.DataAprovacao = DataAprovacao;
            this.TipoProjetoId = tipoProjeto;
            this.DataEntrada = DateTime.Now;
            this.ProcessoId = processo;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", this.TipoProjeto, this.EstadoProjeto);
        }
    }
}
