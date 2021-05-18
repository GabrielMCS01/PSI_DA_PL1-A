using System;
using System.Linq;
using System.Windows.Forms;

namespace GestaoCamaraMunicipal
{
    public partial class GestaoProjetos : Form
    {
        Form1 formprincipal = new Form1();
        private GestaoCamaraMunicipalContainer camaraMunicipal;
        Mensagens mensagem = new Mensagens();

        public GestaoProjetos()
        {
            // Inicia os componentes do formulário
            InitializeComponent();
        }

        // Faz o carregamento da ComboBox com os dados possiveis para chave estrangeira
        private void GestaoProjetos_Load(object sender, EventArgs e)
        {
            camaraMunicipal = new GestaoCamaraMunicipalContainer();
            LerDados();
        }

        // Volta ao menu principal
        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formprincipal.Show();
            this.Hide();
        }

        // Faz quando o formulário fecha
        private void GestaoProjetos_FormClosing(object sender, FormClosingEventArgs e)
        {
            formprincipal.Sair(e);
        }

        // Coloca os dados na listBox provenientes da Base de Dados, tira a Seleção da ListBox e limpa as TextBoxs do formúlário
        private void LerDados()
        {
            listBoxProjetos.DataSource = camaraMunicipal.ProjetoSet.ToList<Projeto>();
            listBoxProjetos.SelectedIndex = -1;

            comboBoxTiposProjeto.DataSource = camaraMunicipal.TipoProjetoSet.ToList<TipoProjeto>();
            comboBoxTiposProjeto.SelectedIndex = -1;

            comboBoxProcesso.DataSource = camaraMunicipal.ProcessoSet.ToList<Processo>();
            comboBoxProcesso.SelectedIndex = -1;

            comboBoxTipoDocumento.DataSource = camaraMunicipal.TipoDocumentoSet.ToList<TipoDocumento>();
            comboBoxTipoDocumento.SelectedIndex = -1;

            LimparForm();
        }

        // Limpa todas as TextBoxs do formulário e tira o index selecionado nas ComboBoxs
        private void LimparForm()
        {
            textBoxEstadoProjeto.Clear();
            comboBoxTiposProjeto.SelectedIndex = -1;
            dateTimePickerProjeto.Value = DateTime.Now;
            comboBoxProcesso.SelectedIndex = -1;
        }

        // Botão para Registar o Projeto
        private void btRegistarProjeto_Click(object sender, EventArgs e)
        {
            try
            {
                // Se todas as TextBoxs tiverem preenchidas Faz
                if (textBoxEstadoProjeto.Text != "" && comboBoxTiposProjeto.SelectedIndex != -1 && comboBoxProcesso.SelectedIndex != -1)
                {
                    // Adiciona o Projeto e guarda as alterações na Base de Dados
                    TipoProjeto tipoprojeto = (TipoProjeto)comboBoxTiposProjeto.SelectedItem;
                    Processo processo = (Processo)comboBoxProcesso.SelectedItem;
                    camaraMunicipal.ProjetoSet.Add(new Projeto(textBoxEstadoProjeto.Text, tipoprojeto.Id, dateTimePickerProjeto.Value, processo.Id));
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

        private void btGuardarAlteracoesProjetos_Click(object sender, EventArgs e)
        {
            Projeto projeto = new Projeto();
            try
            {
                // Se estiver algum Projeto selecionado faz
                if (listBoxProjetos.SelectedIndex != -1)
                {
                    // Se todas as TextBoxs tiverem preenchidas faz
                    if (textBoxEstadoProjeto.Text != "" && comboBoxTiposProjeto.SelectedIndex != -1 && comboBoxProcesso.SelectedIndex != -1)
                    {
                        // Variável para receber o index selecionado na ListBox Projetos
                        int posicao = listBoxProjetos.SelectedIndex;

                        // Varíável que recebe o objeto Projetos selecionado na ListBox
                        projeto = (Projeto)listBoxProjetos.SelectedItem;

                        // Atribui ao objeto anterior as alterações executadas anteriormente no formulário
                        projeto.EstadoProjeto = textBoxEstadoProjeto.Text;
                        TipoProjeto tipoprojeto = (TipoProjeto)comboBoxTiposProjeto.SelectedItem;
                        projeto.TipoProjetoId = tipoprojeto.Id;

                        // Guarda as alterações do objeto na Base de Dados
                        camaraMunicipal.SaveChanges();

                        // Recarrega a ListBox e limpa o formulário
                        LerDados();

                        // Seleciona o index utilizado anteriormente
                        listBoxProjetos.SelectedIndex = posicao;
                        mensagem.Sucesso();
                    }
                    else
                    {
                        mensagem.ErroPreencherCampos();
                    }
                }
                else
                {
                    mensagem.AvisoSelecionarPrimeiro("projeto");
                }
            }
            catch (Exception ex)
            {
                mensagem.Erro(ex);
            }
        }
    }
}
