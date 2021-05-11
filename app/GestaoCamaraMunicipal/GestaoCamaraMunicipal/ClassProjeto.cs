using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCamaraMunicipal
{
    public partial class Projeto
    {
        public Projeto(string estadoProjeto, DateTime DataAprovacao, DateTime DataEntrada, int processo)
        {
            this.Documento = new HashSet<Documento>();
            this.Parecer = new HashSet<Parecer>();
            this.ProjetoAtribuido = new HashSet<ProjetoAtribuido>();
            this.EstadoProjeto = estadoProjeto;
            this.DataAprovacao = DataAprovacao;
            this.DataEntrada = DataEntrada;
            this.ProcessoId = processo;
        }
    }
}
