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
            // Inicia os componentes do formulário
            InitializeComponent();
        }

        // lê os dados da Base de Dados e coloca-os na ListBox
        private void GestaoFuncionarios_Load(object sender, EventArgs e)
        {
            camaraMunicipal = new GestaoCamaraMunicipalContainer();
            LerDados();
        }

        // Coloca os dados na listBox provenientes da Base de Dados, tira a Seleção da ListBox e limpa as TextBoxs do formúlário
        private void LerDados()
        {
            comboBoxEspecialidade.DataSource = camaraMunicipal.TipoProjetoSet.ToList<TipoProjeto>();
            listBoxFuncionarios.DataSource = camaraMunicipal.FuncionarioSet.ToList<Funcionario>();
            listBoxFuncionarios.SelectedIndex = -1;
            LimparForm();
        }

        // Limpa todas as TextBoxs do formulário e tira o index selecionado na ListBox
        private void LimparForm()
        {
            textBoxNome.Clear();
            comboBoxEspecialidade.SelectedIndex = -1;
        }

        // Volta ao menu principal
        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formprincipal.Show();
            this.Hide();
        }

        // Faz quando o formulário fecha
        private void GestaoFuncionarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            formprincipal.Sair(e);
        }

        // Botão para Registar o Funcionário
        private void btregistar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se todas as TextBoxs tiverem preenchidas Faz
                if (textBoxNome.Text != "" & comboBoxEspecialidade.SelectedIndex != -1)
                {
                    try
                    {
                        // Adiciona o Funcionário e guarda as alterações na Base de Dados
                        camaraMunicipal.FuncionarioSet.Add(new Funcionario(CalculaNumero(), textBoxNome.Text, comboBoxEspecialidade.Text));
                        camaraMunicipal.SaveChanges();

                        // Recarrega a ListBox e limpa o formulário
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

        // Retorna o número do funcionário a adicionar
        // baseado no número de funcionários existentes e incrementando 1
        private int CalculaNumero()
        {
            return listBoxFuncionarios.Items.Count +1;
        }

        // Botão para Guardar as alterações feitas no Funcionário
        private void btguardarAlteracoes_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            try
            {
                // Se estiver algum Funcionário selecionado faz
                if (listBoxFuncionarios.SelectedIndex != -1)
                {
                    // Se todas as TextBoxs tiverem preenchidas faz
                    if (textBoxNome.Text != "" & comboBoxEspecialidade.SelectedIndex != -1)
                    {
                        // Variável para receber o index selecionado na ListBox Funcionários
                        int posicao = listBoxFuncionarios.SelectedIndex;

                        // Varíável que recebe o objeto Funcionário selecionado na ListBox
                        funcionario = (Funcionario)listBoxFuncionarios.SelectedItem;

                        // Atribui ao objeto anterior as alterações executadas anteriormente no formulário
                        funcionario.Nome = textBoxNome.Text;
                        funcionario.Extencao = comboBoxEspecialidade.Text;

                        // Guarda as alterações do objeto na Base de Dados
                        camaraMunicipal.SaveChanges();

                        // Recarrega a ListBox e limpa o formulário
                        LerDados();

                        // Seleciona o index utilizado anteriormente
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

        // Mudança no index selecionado na ListBox
        private void listBoxFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            try
            {
                // Se estiver algum Funcionário selecionado faz
                if (listBoxFuncionarios.SelectedIndex != -1)
                {
                    // Varíável que recebe o objeto Funcionário selecionado na ListBox
                    funcionario = (Funcionario)listBoxFuncionarios.SelectedItem;

                    // Atribui ás TextBoxs os atributos do objeto selecionado
                    textBoxNome.Text = funcionario.Nome;
                    comboBoxEspecialidade.Text = funcionario.Extencao;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botão para Remover um Funcionário
        private void btremover_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            try
            {
                // Se estiver algum Funcionário selecionado faz
                if (listBoxFuncionarios.SelectedIndex != -1)
                {
                    // Varíável que recebe o objeto Funcionário selecionado na ListBox
                    funcionario = (Funcionario)listBoxFuncionarios.SelectedItem;

                    // Remove o Funcionário e guarda as alterações na Base de dados
                    camaraMunicipal.FuncionarioSet.Remove(funcionario);
                    camaraMunicipal.SaveChanges();

                    // Recarrega a ListBox e limpa o formulário
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
