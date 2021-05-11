using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCamaraMunicipal
{
    public partial class TipoDocumento
    {
        public TipoDocumento(string designacao)
        {
            Designacao = designacao;
        }


        public override string ToString()
        {
            return Designacao;
        }
    }
}
