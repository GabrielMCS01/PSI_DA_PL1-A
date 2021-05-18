using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCamaraMunicipal
{
    public partial class Parecer
    {
        public Parecer(int numero, string textoParecer, DateTime dataParecer, Projeto projeto, Funcionario funcionario)
        {
            Numero = numero;
            TextoParecer = textoParecer;
            DataParecer = dataParecer;
            Projeto = projeto;
            Funcionario = funcionario;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1} ({2})", Numero, TextoParecer, DataParecer.ToString());
        }
    }
}
