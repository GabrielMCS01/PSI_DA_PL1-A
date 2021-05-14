using System;
using System.Linq;
using System.Windows.Forms;

namespace GestaoCamaraMunicipal
{
    public partial class GestaoFuncionarios : Form
    {
        Form1 formprincipal = new Form1();
        private GestaoCamaraMunicipalContainer camaraMunicipal;
        Mensagens mensagem = new Mensagens();

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
            listBoxFuncionarios.DataSource = camaraMunicipal.FuncionarioSet.ToList<Funcionario>();
            listBoxFuncionarios.SelectedIndex = -1;
            LimparForm();
        }

        // Limpa todas as TextBoxs do formulário e tira o index selecionado na ListBox
        private void LimparForm()
        {
            textBoxNome.Clear();
            textBoxExtensao.Clear();
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
                if (textBoxNome.Text != "" && textBoxExtensao.Text != "")
                {
                    try
                    {
                        // Adiciona o Funcionário e guarda as alterações na Base de Dados
                        string nomeFuncionario = textBoxNome.Text;
                        string extensaoFuncionario = textBoxExtensao.Text;
                        int idFuncionario = CalculaNumero();
                        camaraMunicipal.FuncionarioSet.Add(new Funcionario(idFuncionario, nomeFuncionario, extensaoFuncionario));
                        camaraMunicipal.SaveChanges();

                        // Recarrega a ListBox e limpa o formulário
                        LerDados();
                    }
                    catch (Exception ex)
                    {
                        mensagem.Erro(ex);
                    }
                }
                else
                {
                    mensagem.ErroPreencherCampos();
                }
            }
            catch (FormatException ex)
            {
                mensagem.Erro(ex);
            }
        }

        // Retorna o número do funcionário a adicionar
        // baseado no número de funcionários existentes e incrementando 1
        private int CalculaNumero() {
            int num = listBoxFuncionarios.Items.Count;
            listBoxFuncionarios.SelectedIndex = num - 1;
            Funcionario funcionario = (Funcionario)listBoxFuncionarios.SelectedItem;
            
            return funcionario.Numero + 1;
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
                    if (textBoxNome.Text != "" && textBoxExtensao.Text != "")
                    {
                        // Variável para receber o index selecionado na ListBox Funcionários
                        int posicao = listBoxFuncionarios.SelectedIndex;

                        // Varíável que recebe o objeto Funcionário selecionado na ListBox
                        funcionario = (Funcionario)listBoxFuncionarios.SelectedItem;

                        // Atribui ao objeto anterior as alterações executadas anteriormente no formulário
                        funcionario.Nome = textBoxNome.Text;
                        funcionario.Extencao = textBoxExtensao.Text;

                        // Guarda as alterações do objeto na Base de Dados
                        camaraMunicipal.SaveChanges();

                        // Recarrega a ListBox e limpa o formulário
                        LerDados();

                        // Seleciona o index utilizado anteriormente
                        listBoxFuncionarios.SelectedIndex = posicao;
                        mensagem.Sucesso();
                    }
                    else
                    {
                        mensagem.ErroPreencherCampos();
                    }
                }
                else
                {
                    mensagem.AvisoSelecionarPrimeiro("funcionário");
                }
            }
            catch (Exception ex)
            {
                mensagem.Erro(ex);
            }
        }

        // Mudança no index selecionado na ListBox
        private void listBoxFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Se estiver algum Funcionário selecionado faz
                if (listBoxFuncionarios.SelectedIndex != -1)
                {
                    // Varíável que recebe o objeto Funcionário selecionado na ListBox
                    Funcionario funcionario = (Funcionario)listBoxFuncionarios.SelectedItem;

                    // Atribui ás TextBoxs os atributos do objeto selecionado
                    textBoxNome.Text = funcionario.Nome;
                    textBoxExtensao.Text = funcionario.Extencao;
                }
            }
            catch (Exception ex)
            {
                mensagem.Erro(ex);
            }
        }

        // Botão para Remover um Funcionário
        private void btremover_Click(object sender, EventArgs e)
        {
            try
            {
                // Se estiver algum Funcionário selecionado faz
                if (listBoxFuncionarios.SelectedIndex != -1)
                {
                    // Varíável que recebe o objeto Funcionário selecionado na ListBox
                    Funcionario funcionario = (Funcionario)listBoxFuncionarios.SelectedItem;

                    // Remove o Funcionário e guarda as alterações na Base de dados
                    camaraMunicipal.FuncionarioSet.Remove(funcionario);
                    camaraMunicipal.SaveChanges();

                    // Recarrega a ListBox e limpa o formulário
                    LerDados();
                    LimparForm();
                }
                else
                {
                    mensagem.AvisoSelecionarPrimeiro("funcionários");
                }
            }
            catch (Exception ex)
            {
                mensagem.Erro(ex);
            }
        }
    }
}
