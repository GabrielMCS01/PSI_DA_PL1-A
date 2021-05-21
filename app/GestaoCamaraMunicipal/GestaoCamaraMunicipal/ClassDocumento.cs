using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCamaraMunicipal
{
    public partial class Documento
    {

        public Documento()
        {

        }

        public Documento(string titulo, DateTime dataentrega, TipoDocumento tipodocumento, Projeto projeto, Parecer parecer)
        {
            this.Titulo = titulo;
            this.DataEntrega = dataentrega;
            this.TipoDocumento = tipodocumento;
            this.Projeto = projeto;
            this.Parecer = parecer;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}) - {2}", this.Titulo, this.DataEntrega, this.Projeto);
        }
    }
}
