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
        
        // Tem que se selecionar um processo do projeto escolhido
        //comboBoxProjetoProcesso.DataSource = camaraMunicipal.ProcessoSet.ToList<Projeto>();

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

        // Coloca os dados na listBox provenientes da Base de Dados, tira a Seleção da ListBox e limpa as TextBoxs do formúlário
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

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

                    // Adiciona o Projeto e guarda as alterações na Base de Dados
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

        // Retorna o número do funcionário a adicionar
        // baseado no número de funcionários existentes e incrementando 1
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

        }
    }
}
