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
    public partial class GestaoProjetos : Form
    {
        Form1 formprincipal = new Form1();
        private GestaoCamaraMunicipalContainer camaraMunicipal;
        public GestaoProjetos()
        {
            InitializeComponent();
        }

        // Faz o carregamento da ComboBox com os dados possiveis para chave estrangeira
        private void GestaoProjetos_Load(object sender, EventArgs e)
        {
            camaraMunicipal = new GestaoCamaraMunicipalContainer();
            
            comboBoxFuncionario.DataSource = camaraMunicipal.FuncionarioSet.ToList<Funcionario>();
            comboBoxFuncionario.SelectedIndex = -1;

            comboBoxProcesso.DataSource = camaraMunicipal.ProcessoSet.ToList<Processo>();
            comboBoxProcesso.SelectedIndex = -1;
        }

        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formprincipal.Show();
            this.Hide();
        }

        private void GestaoProjetos_FormClosing(object sender, FormClosingEventArgs e)
        {
            formprincipal.Sair(e);
        }

        private void LerDados()
        {
            listBoxProjetos.DataSource = camaraMunicipal.ProjetoSet.ToList<Projeto>();
            listBoxProjetos.SelectedIndex = -1;
            LimparForm();
        }

        // Limpa todas as TextBoxs do formulário e tira o index selecionado na ListBox
        private void LimparForm()
        {
            textBoxEstadoProjeto.Clear();
            comboBoxFuncionario.SelectedIndex = -1;
            dateTimePickerProjeto.Value = DateTime.Now;
            comboBoxProcesso.SelectedIndex = -1;
            checkBoxDependente.Checked = false;
        }

        private void btRegistarProjeto_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxEstadoProjeto.Text != "" || comboBoxFuncionario.SelectedIndex != -1 || comboBoxProcesso.SelectedIndex != -1)
                {
                    /*camaraMunicipal.ProjetoSet.Add(new Projeto(textBoxEstadoProjeto.Text, comboBoxFuncionario.Text));
                    camaraMunicipal.SaveChanges();
                    LerDados();*/
                }
                else
                {
                    MessageBox.Show("Tem de Preencher todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gestãoDePromotoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            formprincipal.Show();
            this.Hide();
        }

        private void textBoxEstadoProjeto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
