using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCamaraMunicipal
{
    public partial class ProjetoAtribuido
    {
        public ProjetoAtribuido()
        {
            
        }
        public ProjetoAtribuido(DateTime data, Projeto projeto, Funcionario funcionario)
        {
            this.Data = data;
            this.Projeto = projeto;
            this.Funcionario = funcionario;
        }

        public override string ToString()
        {
            return string.Format("{0} \t{1} - {2}", this.Data , this.Projeto, this.Funcionario);
        }
    }
    
}
