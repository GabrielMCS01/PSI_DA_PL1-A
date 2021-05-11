using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCamaraMunicipal
{
    public partial class Funcionario
    {
        public Funcionario(int id, string nome, string extensao)
        {
            this.Numero = id;
            this.Parecer = new HashSet<Parecer>();
            this.Especialista = new HashSet<Especialista>();
            this.ProjetoAtribuido = new HashSet<ProjetoAtribuido>();
            this.Nome = nome;
            this.Extencao = extensao;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", this.Nome, this.Extencao);
        }
    }
}
