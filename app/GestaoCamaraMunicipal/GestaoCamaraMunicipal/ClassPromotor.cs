using System.Collections.Generic;

namespace GestaoCamaraMunicipal
{
    public partial class Promotor
    {
        public Promotor(int nIF, string nome, string morada, string telemovel, string email, string codigoAcesso, string senha)
        {
            this.Processo = new HashSet<Processo>();
            this.NIF = nIF;
            this.Nome = nome;
            this.Morada = morada;
            this.Telemovel = telemovel;
            this.Email = email;
            this.CodigoAcesso = codigoAcesso;
            this.Senha = senha;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", this.Nome, this.NIF);
        }
    }
}
