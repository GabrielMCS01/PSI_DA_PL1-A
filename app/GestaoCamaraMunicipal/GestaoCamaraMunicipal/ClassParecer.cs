using System;

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
            return string.Format("{0} ({1})",TextoParecer, DataParecer.ToString());
        }
    }
}
