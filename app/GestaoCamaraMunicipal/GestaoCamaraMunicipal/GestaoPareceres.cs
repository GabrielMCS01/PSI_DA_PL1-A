using System;
using System.Linq;
using System.Windows.Forms;

namespace GestaoCamaraMunicipal
{
    public partial class GestaoPareceres : Form
    {
        Form1 formprincipal = new Form1();
        private GestaoCamaraMunicipalContainer camaraMunicipal;
        Mensagens mensagem = new Mensagens();
        public GestaoPareceres()
        {
            // Inicia os componentes do formulário
            InitializeComponent();
        }

        // Faz o carregamento da ComboBox com os dados possiveis para chave estrangeira
        private void GestaoPareceres_Load(object sender, EventArgs e)
        {
            camaraMunicipal = new GestaoCamaraMunicipalContainer();

            // Recebe todos os projetos existentes
            comboBoxProjeto.DataSource = camaraMunicipal.ProjetoSet.ToList<Projeto>();
            comboBoxProjeto.SelectedIndex = -1;
            
            // Recebe todos os funcionários existentes
            comboBoxFuncionario.DataSource = camaraMunicipal.FuncionarioSet.ToList<Funcionario>();
            comboBoxFuncionario.SelectedIndex = -1;

            LerDados();
        }

        // Volta ao menu principal
        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formprincipal.Show();
            this.Hide();
        }

        // Faz quando o formulário fecha
        private void GestaoPareceres_FormClosing(object sender, FormClosingEventArgs e)
        {
            formprincipal.Sair(e);
        }

        // Coloca os dados na listBox provenientes da Base de Dados, retira a Seleção da ListBox e limpa as TextBoxs do formúlário
        private void LerDados()
        {
            listBoxPareceres.DataSource = camaraMunicipal.ParecerSet.ToList<Parecer>();
            listBoxPareceres.SelectedIndex = -1;
            LimparForm();
        }

        // Limpa todas as TextBoxs do formulário e tira o index selecionado nas ComboBoxs
        private void LimparForm()
        {
            textBoxTextoParecer.Clear();
            dateTimePickerProjeto.Value = DateTime.Now;
            comboBoxProjeto.SelectedIndex = -1;
            comboBoxFuncionario.SelectedIndex = -1;
        }

        // Botão para Registar o Parecer
        private void btRegistarProjeto_Click(object sender, EventArgs e)
        {
            try
            {
                // Se todas as TextBoxs tiverem preenchidas Faz
                if (textBoxTextoParecer.Text != "" && comboBoxFuncionario.SelectedIndex != -1 && comboBoxProjeto.SelectedIndex != -1)
                {
                    Projeto projeto = new Projeto();
                    EstadoProcesso estadoProcesso = new EstadoProcesso();
                    Funcionario funcionario = new Funcionario();

                    // Receber os valores
                    string texto = textBoxTextoParecer.Text;
                    DateTime date = dateTimePickerProjeto.Value;
                    projeto = (Projeto)comboBoxProjeto.SelectedItem;
                    funcionario = (Funcionario)comboBoxFuncionario.SelectedItem;
                    int idParecer = CalculaNumero();

                    // Adiciona o Parecer e guarda as alterações na Base de Dados
                    Parecer parecer = new Parecer(idParecer, texto, date, projeto, funcionario);
                    camaraMunicipal.ParecerSet.Add(parecer);
                    camaraMunicipal.SaveChanges();

                    // Recarrega a ListBox e limpa o formulário
                    LerDados();
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

        // Retorna o número de Pareceres a adicionar
        // baseado no número de pareceres existentes e incrementando 1
        private int CalculaNumero()
        {
            if (listBoxPareceres.Items.Count > 0)
            {
                int num = listBoxPareceres.Items.Count;
                listBoxPareceres.SelectedIndex = num - 1;
                Parecer parecer = (Parecer)listBoxPareceres.SelectedItem;

                return parecer.Numero + 1;
            }
            else
            {
                return 1;
            }
        }

        private void btRemoverProjetos_Click(object sender, EventArgs e)
        {
            try
            {
                // Se estiver algum Parecer selecionado faz
                if (listBoxPareceres.SelectedIndex != -1)
                {
                    // Varíável que recebe o objeto Parecer selecionado na ListBox
                    Parecer parecer = (Parecer)listBoxPareceres.SelectedItem;

                    // Remove o Parecer e guarda as alterações na Base de dados
                    camaraMunicipal.ParecerSet.Remove(parecer);
                    camaraMunicipal.SaveChanges();

                    // Recarrega a ListBox e limpa o formulário
                    LerDados();
                    LimparForm();
                }
                else
                {
                    mensagem.AvisoSelecionarPrimeiro("Pareceres");
                }
            }
            catch (Exception ex)
            {
                mensagem.Erro(ex);
            }
        }

        // Botão para Guardar as alterações feitas no Parecer
        private void btGuardarAlteracoesProjetos_Click(object sender, EventArgs e)
        {
            Parecer parecer = new Parecer();
            try
            {
                // Se estiver algum Parecer selecionado faz
                if (listBoxPareceres.SelectedIndex != -1)
                {
                    // Se todas as Caixas tiverem preenchidas faz
                    if (textBoxTextoParecer.Text != "" && comboBoxProjeto.SelectedIndex != -1 && comboBoxFuncionario.SelectedIndex != -1)
                    {
                        // Variável para receber o index selecionado na ListBox Pareceres
                        int posicao = listBoxPareceres.SelectedIndex;

                        // Varíável que recebe o objeto Parecer selecionado na ListBox
                        parecer = (Parecer)listBoxPareceres.SelectedItem;

                        // Atribui ao objeto anterior as alterações executadas anteriormente no formulário
                        parecer.TextoParecer = textBoxTextoParecer.Text;
                        parecer.DataParecer = dateTimePickerProjeto.Value;
                        parecer.Projeto = (Projeto)comboBoxProjeto.SelectedItem;
                        parecer.Funcionario = (Funcionario)comboBoxFuncionario.SelectedItem;

                        // Guarda as alterações do objeto na Base de Dados
                        camaraMunicipal.SaveChanges();

                        // Recarrega a ListBox e limpa o formulário
                        LerDados();

                        // Seleciona o index utilizado anteriormente
                        listBoxPareceres.SelectedIndex = posicao;
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

        private void listBoxPareceres_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Se estiver algum Parecer selecionado faz
                if (listBoxPareceres.SelectedIndex != -1)
                {
                    // Varíável que recebe o objeto Parecer selecionado na ListBox
                    Parecer parecer = (Parecer)listBoxPareceres.SelectedItem;

                    // Atribui ás TextBoxs os atributos do objeto selecionado
                    textBoxTextoParecer.Text = parecer.TextoParecer;
                    dateTimePickerProjeto.Value = parecer.DataParecer;
                    comboBoxProjeto.SelectedItem = parecer.Projeto;
                    comboBoxFuncionario.SelectedItem = parecer.Funcionario;
                }
            }
            catch (Exception ex)
            {
                mensagem.Erro(ex);
            }
        }
    }
}
