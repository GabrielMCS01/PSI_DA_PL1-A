using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCamaraMunicipal
{
    public partial class Parecer
    {
        public Parecer(int numero, string textoParecer, DateTime dataParecer, int projetoId, int projetoProcessoId, int funcionarioNumero)
        {
            Numero = numero;
            TextoParecer = textoParecer;
            DataParecer = dataParecer;
            ProjetoId = projetoId;
            ProjetoProcessoId = projetoProcessoId;
            FuncionarioNumero = funcionarioNumero;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1} ({2})", Numero, TextoParecer, DataParecer.ToString());
        }
    }
}
