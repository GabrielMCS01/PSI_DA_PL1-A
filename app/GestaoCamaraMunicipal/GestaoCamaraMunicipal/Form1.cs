using System;
using System.Windows.Forms;

namespace GestaoCamaraMunicipal
{
    public partial class Form1 : Form
    {
        private GestaoCamaraMunicipalContainer camaraMunicipal;
        Mensagens mensagem = new Mensagens();
        public Form1()
        {
            // Inicia os componentes do formulário
            InitializeComponent();
            camaraMunicipal = new GestaoCamaraMunicipalContainer();
        }

        // Opção do menu que carrega o formulário de Gestão de Promotores
        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoPromotores form = new GestaoPromotores();
            form.Show();

            // Esconde este menu
            this.Hide();
        }

        // Opção do menu que carrega o formulário de Gestão de Processos
        private void gestãoDeProcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoProcessos form = new GestaoProcessos();
            form.Show();

            // Esconde este menu
            this.Hide();
        }

        // Opção do menu que carrega o formulário de Gestão de Projetos
        private void gestãoDeProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoProjetos form = new GestaoProjetos();
            form.Show();

            // Esconde este menu
            this.Hide();
        }

        // Opção do menu que carrega o formulário de Gestão de Pareceres
        private void gestãoDePareceresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoPareceres form = new GestaoPareceres();
            form.Show();

            // Esconde este menu
            this.Hide();
        }

        // Opção do menu que carrega o formulário de Gestão de Funcionários
        private void gestãoDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoFuncionarios form = new GestaoFuncionarios();
            form.Show();

            // Esconde este menu
            this.Hide();
        }

        // Opção do menu que permite Terminar o programa
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Faz quando o formulário fecha
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sair(e);
        }

        public void Sair(FormClosingEventArgs e)
        {
            // Confirma ao utilizador se este quer Sair do programa
            DialogResult resposta = mensagem.Sair();
            
            // Caso a Resposta seja não
            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }
            // Caso a Resposta seja Sim
            else 
            {
                camaraMunicipal.Dispose();
                Environment.Exit(1);
            }
        }

        private void gestãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestao form = new Gestao();
            form.Show();

            // Esconde este menu
            this.Hide();
        }
    }
}
