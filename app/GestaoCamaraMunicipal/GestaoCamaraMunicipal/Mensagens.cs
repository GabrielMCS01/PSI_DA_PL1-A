using System;
using System.Windows.Forms;

namespace GestaoCamaraMunicipal
{
    public class Mensagens
    {
        // Mensagem de erro padrão.
        public void Erro(Exception ex)
        {
            MessageBox.Show("Ocorreu um erro\n\n" + ex.InnerException, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Mensagem de erro devido a não se preencher todos os campos do formulário ao adicionar.
        public void ErroPreencherCampos()
        {
            MessageBox.Show("Tem de Preencher todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroPreencherCampo(string objeto)
        {
            MessageBox.Show("O campo " + objeto + " não está preenchido corretamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Mensagem de erro por inserir um funcionário que já está adicionado.
        public void ObjetoDuplicado(string objeto)
        {
            MessageBox.Show("já adicionou esse " + objeto, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void PreenchaCorretamente(string objeto)
        {
            MessageBox.Show("Erro ao adicionadar um " + objeto + ", Preencha corretamente os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Mensagem de aviso para selecionar primeiro algo.
        public void AvisoSelecionarPrimeiro(string objetoVisado)
        {
            MessageBox.Show("Selecione primeiro um " + objetoVisado, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Mensagem de sucesso ao alterar o formulário
        public void Sucesso()
        {
            MessageBox.Show("Alteração guardada com sucesso!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Mensagem de confirmação para sair do formulário
        public DialogResult Sair()
        {
            return MessageBox.Show("Tem a certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
