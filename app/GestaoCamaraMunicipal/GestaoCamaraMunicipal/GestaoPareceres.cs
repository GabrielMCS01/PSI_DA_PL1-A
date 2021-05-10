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
    public partial class GestaoPareceres : Form
    {
        Form1 formprincipal = new Form1();
        private GestaoCamaraMunicipalContainer camaraMunicipal;
        public GestaoPareceres()
        {
            InitializeComponent();
        }

        // Faz o carregamento da ComboBox com os dados possiveis para chave estrangeira
        private void GestaoPareceres_Load(object sender, EventArgs e)
        {
            camaraMunicipal = new GestaoCamaraMunicipalContainer();
            comboBoxProjeto.DataSource = camaraMunicipal.ProjetoSet.ToList<Projeto>();
            comboBoxFuncionario.DataSource = camaraMunicipal.FuncionarioSet.ToList<Funcionario>();
        }
        // Tem que se selecionar um processo do projeto escolhido
        //comboBoxProjetoProcesso.DataSource = camaraMunicipal.ProcessoSet.ToList<Projeto>();

        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formprincipal.Show();
            this.Hide();
        }

        private void GestaoPareceres_FormClosing(object sender, FormClosingEventArgs e)
        {
            formprincipal.Sair(e);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
