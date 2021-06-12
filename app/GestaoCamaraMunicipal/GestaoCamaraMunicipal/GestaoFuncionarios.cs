using System;
using System.Linq;
using System.Windows.Forms;

namespace GestaoCamaraMunicipal
{
    public partial class GestaoFuncionarios : Form
    {
        private GestaoCamaraMunicipalContainer camaraMunicipal;
        Mensagens mensagem = new Mensagens();
        int index = -1;

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
            MudarBotoes();
        }

        // Coloca os dados na listBox provenientes da Base de Dados, tira a Seleção da ListBox e limpa as TextBoxs do formúlário
        private void LerDados()
        {
            listBoxFuncionarios.DataSource = camaraMunicipal.FuncionarioSet.ToList<Funcionario>();
            listBoxFuncionarios.SelectedIndex = -1;
            index = -1;
            LimparForm();
        }

        public void MudarBotoes()
        {
            // Caso não tenha nenhum item selecionado na ListBox
            if (index == -1)
            {
                // Gere os butões conforme a necessidade
                btregistar.Enabled = true;
                btguardarAlteracoes.Enabled = false;
                btremover.Enabled = false;
            }
            else
            {
                // Gere os butões conforme a necessidade
                btregistar.Enabled = false;
                btguardarAlteracoes.Enabled = true;
                btremover.Enabled = true;
            }
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
            this.Close();
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
                        // Recebe os valores do formulário
                        string nomeFuncionario = textBoxNome.Text;
                        string extensaoFuncionario = textBoxExtensao.Text;

                        // Faz um cálculo para selecionar o ID de Funcionário
                        int idFuncionario = CalculaNumero();

                        // Adiciona o Funcionário e guarda as alterações na Base de Dados
                        camaraMunicipal.FuncionarioSet.Add(new Funcionario(idFuncionario, nomeFuncionario, extensaoFuncionario));
                        camaraMunicipal.SaveChanges();

                        // Recarrega a ListBox e limpa o formulário
                        LerDados();
                        MudarBotoes();
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
        // Recebe o ID do último Funcionário e incrementa 1
        private int CalculaNumero() {
            // Se existir algum funcionário faz
            if (listBoxFuncionarios.Items.Count > 0)
            {
                // Recebe o Numero de Funcionários na ListBox
                int num = listBoxFuncionarios.Items.Count;
                listBoxFuncionarios.SelectedIndex = num - 1;
                Funcionario funcionario = (Funcionario)listBoxFuncionarios.SelectedItem;

                return funcionario.Numero + 1;
            }
            // Se não existir nenhum funcionário é atribuido o ID 1
            else
            {
                return 1;
            }
            
        }

        // Botão para Guardar as alterações feitas no Funcionário
        private void btguardarAlteracoes_Click(object sender, EventArgs e)
        {
            Funcionario funcionario;
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
                // Se estiver algum Funcionário selecionado e se este não for o mesmo que o anterior faz
                if (listBoxFuncionarios.SelectedIndex != -1 && index != listBoxFuncionarios.SelectedIndex)
                {
                    // Varíável que recebe o objeto Funcionário selecionado na ListBox
                    Funcionario funcionario = (Funcionario)listBoxFuncionarios.SelectedItem;

                    // Atribui ás TextBoxs os atributos do objeto selecionado
                    textBoxNome.Text = funcionario.Nome;
                    textBoxExtensao.Text = funcionario.Extencao;

                    // Alterar os botões caso necessários
                    index = listBoxFuncionarios.SelectedIndex;
                    MudarBotoes();
                }
                // Se estiver algum Funcionário selecionado e se este for o mesmo que o anterior faz
                else if (listBoxFuncionarios.SelectedIndex != -1 && index == listBoxFuncionarios.SelectedIndex)
                {
                    // Retira a seleção na ListBox
                    listBoxFuncionarios.SelectedIndex = -1;
                    index = -1;

                    // Limpa o formulário e altera os butões
                    MudarBotoes();
                    LimparForm();
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
                    if (funcionario.ProjetoAtribuido.Count == 0)
                    {
                        camaraMunicipal.FuncionarioSet.Remove(funcionario);
                        camaraMunicipal.SaveChanges();

                        // Recarrega a ListBox e limpa o formulário
                        LerDados();
                        MudarBotoes();
                    }
                    else
                    {
                        mensagem.AvisoEliminarPrimeiro("os projetos atribuidos a este funcionário.");
                    }
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

        // AJUDA
        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Formulário de Gestão de Funcionários tem " +
                "como principal objetivo a inserção de novos Funcionários. " +
                "Para esse efeito existem validações de dados que devem ser " +
                "respeitadas. Deste modo, todos os dados são validados e " +
                "verificados, devendo estes estarem corretos. Ao adicionar " +
                "um funcionário, quando o mesmo for criado, serão guardados " +
                "os seus dados na base de dados e" +
                " mostrados na respetiva lista disponível no formulário.", "Ajuda DPM");
        }
    }
}
