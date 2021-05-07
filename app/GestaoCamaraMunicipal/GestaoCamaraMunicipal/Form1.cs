using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoCamaraMunicipal
{
    public partial class Form1 : Form
    {
        private GestaoCamaraMunicipalContainer camaraMunicipal;
        public Form1()
        {
            InitializeComponent();
            camaraMunicipal = new GestaoCamaraMunicipalContainer();

        }

        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoPromotores form = new GestaoPromotores();
            form.Show();
            this.Hide();
        }

        private void gestãoDeProcessosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoProcessos form = new GestaoProcessos();
            form.Show();
            this.Hide();
        }

        private void gestãoDeProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoProjetos form = new GestaoProjetos();
            form.Show();
            this.Hide();
        }

        private void gestãoDePareceresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoPareceres form = new GestaoPareceres();
            form.Show();
            this.Hide();
        }

        private void gestãoDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoFuncionarios form = new GestaoFuncionarios();
            form.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sair(e);
        }

        public void Sair(FormClosingEventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem a certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                camaraMunicipal.Dispose();
                Environment.Exit(1);
            }
        }
    }
}
