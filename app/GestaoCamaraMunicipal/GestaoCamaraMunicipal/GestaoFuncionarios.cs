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
    public partial class GestaoFuncionarios : Form
    {
        Form1 formprincipal = new Form1();
        private GestaoCamaraMunicipalContainer camaraMunicipal;
        public GestaoFuncionarios()
        {
            InitializeComponent();
            
        }

        private void GestaoFuncionarios_Load(object sender, EventArgs e)
        {
            camaraMunicipal = new GestaoCamaraMunicipalContainer();
            LerDados();
        }

        private void LerDados()
        {
            listBoxFuncionarios.DataSource = camaraMunicipal.FuncionarioSet.ToList<Funcionario>();
            listBoxFuncionarios.SelectedIndex = -1;
            LimparForm();
        }

        private void LimparForm()
        {
            textBoxNome.Clear();
            comboBoxEspecialidade.SelectedIndex = -1;
        }

        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formprincipal.Show();
            this.Hide();
        }

        private void GestaoFuncionarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            formprincipal.Sair(e);
        }

        private void btregistar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNome.Text != "" & comboBoxEspecialidade.SelectedIndex != -1)
                {
                    try
                    {
                        camaraMunicipal.FuncionarioSet.Add(new Funcionario(CalculaNumero(), textBoxNome.Text, comboBoxEspecialidade.Text));
                        camaraMunicipal.SaveChanges();
                        LerDados();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private int CalculaNumero()
        {
            return listBoxFuncionarios.Items.Count +1;
        }

        private void btguardarAlteracoes_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            try
            {
                if (listBoxFuncionarios.SelectedIndex != -1)
                {
                    if (textBoxNome.Text != "" & comboBoxEspecialidade.SelectedIndex != -1)
                    {
                        int posicao = listBoxFuncionarios.SelectedIndex;
                        funcionario = (Funcionario)listBoxFuncionarios.SelectedItem;
                        funcionario.Nome = textBoxNome.Text;
                        funcionario.Extencao = comboBoxEspecialidade.Text;
                        camaraMunicipal.SaveChanges();
                        LerDados();
                        listBoxFuncionarios.SelectedIndex = posicao;
                        MessageBox.Show("Alteração guardada com sucesso!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tem de Preencher todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione primeiro um funcionário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            try{
                if (listBoxFuncionarios.SelectedIndex != -1)

                {
                    funcionario = (Funcionario)listBoxFuncionarios.SelectedItem;
                    textBoxNome.Text = funcionario.Nome;
                    comboBoxEspecialidade.Text = funcionario.Extencao;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btremover_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            try
            {
                if (listBoxFuncionarios.SelectedIndex != -1)
                {
                    funcionario = (Funcionario)listBoxFuncionarios.SelectedItem;
                    camaraMunicipal.FuncionarioSet.Remove(funcionario);
                    camaraMunicipal.SaveChanges();
                    LerDados();
                    LimparForm();
                }
                else
                {
                    MessageBox.Show("Selecione primeiro um promotor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
