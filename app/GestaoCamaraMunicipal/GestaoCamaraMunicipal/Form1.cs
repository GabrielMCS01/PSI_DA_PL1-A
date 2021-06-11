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
        }

        // Opção do menu que carrega o formulário de Gestão de Processos
        private void gestãoDeProcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoProcessos form = new GestaoProcessos();
            form.Show();
        }

        // Opção do menu que carrega o formulário de Gestão de Projetos
        private void gestãoDeProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoProjetos form = new GestaoProjetos();
            form.Show();
        }

        // Opção do menu que carrega o formulário de Gestão de Pareceres
        private void gestãoDePareceresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoPareceres form = new GestaoPareceres();
            form.Show();
        }

        // Opção do menu que carrega o formulário de Gestão de Funcionários
        private void gestãoDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoFuncionarios form = new GestaoFuncionarios();
            form.Show();
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O formulário de Menu, permite a navegação " +
                "entre os variados formulários do projeto. O Menu permite " +
                "ainda a deslocação entre vários formulários com atalhos " +
                "facilitando a otimizando o tempo útil do utilizador. Deste modo, " +
                "o Menu está bastante simples para facilitar a sua funcionalidade " +
                "e a sua clareza.", "Ajuda DPM");
        }
    }
}
