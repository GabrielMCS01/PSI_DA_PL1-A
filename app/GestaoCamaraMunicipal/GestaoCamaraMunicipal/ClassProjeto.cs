using System;
using System.Collections.Generic;

namespace GestaoCamaraMunicipal
{
    public partial class Projeto
    {
        public Projeto(string estadoProjeto, TipoProjeto tipoProjeto, DateTime DataAprovacao, Processo processo)
        {
            this.Documento = new HashSet<Documento>();
            this.Parecer = new HashSet<Parecer>();
            this.ProjetoAtribuido = new HashSet<ProjetoAtribuido>();
            this.EstadoProjeto = estadoProjeto;
            this.DataAprovacao = DataAprovacao;
            this.TipoProjeto = tipoProjeto;
            this.DataEntrada = DateTime.Now;
            this.Processo = processo;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", this.TipoProjeto, this.EstadoProjeto);
        }
    }
}
