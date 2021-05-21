using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoCamaraMunicipal
{
    public class Mensagens
    {
        //Mensagem de erro padrão.
        public void Erro(Exception ex)
        {
            MessageBox.Show("Ocorreu um erro\n\n" + ex.InnerException, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Mensagem de erro por não preencher todos os campos do formulário ao adicionar.
        public void ErroPreencherCampos()
        {
            MessageBox.Show("Tem de Preencher todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Mensagem de aviso para selecionar primeiro algo.
        public void AvisoSelecionarPrimeiro(string objetoVisado)
        {
            MessageBox.Show("Selecione primeiro um " + objetoVisado, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Mensagem de sucesso ao alterar o formulário
        public void Sucesso()
        {
            MessageBox.Show("Alteração guardada com sucesso!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult Sair()
        {
            return MessageBox.Show("Tem a certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
