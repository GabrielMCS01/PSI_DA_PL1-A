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
        
        // Caso se meta os pareceres neste form 
        // int indexParecer = -1;
        int indexProjeto = -1;
        int indexDOC = -1;
        int indexFuncionarios = -1;

        public GestaoProjetos()
        {
            // Inicia os componentes do formulário
            InitializeComponent();
        }

        // Faz o carregamento da ComboBox com os dados possiveis para chave estrangeira
        private void GestaoProjetos_Load(object sender, EventArgs e)
        {
            camaraMunicipal = new GestaoCamaraMunicipalContainer();
            // Talvez Pareceres se fizer-se isso
            LerDadosProjetos();
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
            camaraMunicipal.Dispose();
            formprincipal.Sair(e);
        }

        // Coloca os dados na listBox provenientes da Base de Dados, tira a Seleção da ListBox e limpa as TextBoxs do formúlário
        private void LerDadosProjetos()
        {
            // Ler dados dos projetos
            listBoxProjetos.DataSource = camaraMunicipal.ProjetoSet.ToList<Projeto>();
            comboBoxTiposProjeto.DataSource = camaraMunicipal.TipoProjetoSet.ToList<TipoProjeto>();
            comboBoxProcesso.DataSource = camaraMunicipal.ProcessoSet.ToList<Processo>();
     
            LimparFormProjetos();
        }

        private void LerDadosDocumentos(Projeto projeto)
        {
            // Ler dados dos documentos
            // List documento = (Documento)projeto.Documento.ToList<Documento>();

            // Apresentar lista de documento do projeto
            listBoxDocumentos.DataSource = projeto.Documento.ToList<Documento>();
           // comboBoxTipoDocumento.DataSource = projeto.ToList<TipoDocumento>();
            comboBoxParecer.DataSource = camaraMunicipal.ParecerSet.ToList<Parecer>();

            LimparFormDocumentos();        
        }

        private void LerDadosFuncionarios()
        {
            // Ler dados dos projetos atribuidos
            listBoxProjetoAtribuido.DataSource = camaraMunicipal.ProjetoAtribuidoSet.ToList<ProjetoAtribuido>();
            comboBoxFuncionario.DataSource = camaraMunicipal.FuncionarioSet.ToList<Funcionario>();

            LimparFormFuncionarios();
        }

        // Limpa todas as TextBoxs do formulário e tira o index selecionado nas ComboBoxs
        private void LimparFormProjetos()
        {
            // Limpar campos dos projetos
            listBoxProjetos.ClearSelected();
            textBoxEstadoProjeto.Clear();
            comboBoxTiposProjeto.SelectedIndex = -1;
            dateTimePickerProjeto.Value = DateTime.Now;
            comboBoxProcesso.SelectedIndex = -1;
        }

        private void LimparFormDocumentos()
        {
            // Limpar campos dos documentos
            listBoxDocumentos.ClearSelected();
            textBoxTitulo.Clear();
            comboBoxTipoDocumento.SelectedIndex = -1;
            dateTimePickerDocumento.Value = DateTime.Now;
            comboBoxParecer.SelectedIndex = -1;
        }

        private void LimparFormFuncionarios()
        {
            // Limpar campos dos projetos atribuidos
            listBoxProjetoAtribuido.ClearSelected();
            comboBoxFuncionario.SelectedIndex = -1;
            dateTimePickerAtribuicao.Value = DateTime.Now;
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
                    LerDadosProjetos();
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
                        LerDadosProjetos();

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

        private void listBoxProjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProjetos.SelectedIndex != -1 && indexProjeto != listBoxProjetos.SelectedIndex)
            {
                // Recebe o projeto selecionado na ListBox
                Projeto projeto = (Projeto)listBoxProjetos.SelectedItem;

                // Atribui os valores do projeto ás textBoxs para se poder fazer alterações ou visualizar
                textBoxEstadoProjeto.Text = projeto.EstadoProjeto;
                comboBoxTiposProjeto.Text = projeto.TipoProjeto.ToString();
                dateTimePickerProjeto.Value = projeto.DataAprovacao;
                comboBoxProcesso.Text = projeto.Processo.ToString();

                LerDadosDocumentos();
            }
        }

        private void btRemoverProjetos_Click(object sender, EventArgs e)
        {
            try
            {
                // Se estiver algum Projeto selecionado faz
                if (listBoxProjetos.SelectedIndex != -1)
                {
                    // Varíável que recebe o objeto Projeto selecionado na ListBox
                    Projeto projeto = (Projeto)listBoxProjetos.SelectedItem;

                    // Remove o Projeto e guarda as alterações na Base de dados
                    camaraMunicipal.ProjetoSet.Remove(projeto);
                    camaraMunicipal.SaveChanges();

                    // Recarrega a ListBox e limpa o formulário
                    LerDadosProjetos();
                    LimparFormProjetos();
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

        private void btRegistarDocumentos_Click(object sender, EventArgs e)
        {
            try
            {
                // Se todas as TextBoxs tiverem preenchidas Faz
                if (listBoxProjetos.SelectedIndex != -1 && textBoxTitulo.Text != "" && comboBoxTipoDocumento.SelectedIndex != -1 && comboBoxParecer.SelectedIndex != -1)
                {
                    // Adiciona o Projeto e guarda as alterações na Base de Dados
                    camaraMunicipal.DocumentoSet.Add(new Documento(textBoxTitulo.Text, dateTimePickerDocumento.Value, (TipoDocumento)comboBoxTipoDocumento.SelectedItem, (Projeto)listBoxProjetos.SelectedItem, (Parecer)comboBoxParecer.SelectedItem));
                    camaraMunicipal.SaveChanges();

                    // Recarrega a ListBox e limpa o formulário
                    LerDadosDocumentos();
                }
                else
                {
                    mensagem.AvisoSelecionarPrimeiro("projeto e preencha todos os campos.");
                }
            }
            catch (FormatException ex)
            {
                mensagem.Erro(ex);
            }
        }

        private void listBoxDocumentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDocumentos.SelectedIndex != -1)
            {
                // Recebe o documento selecionado na ListBox
                Documento documento = (Documento)listBoxDocumentos.SelectedItem;

                // Atribui os valores do documento ás textBoxs para se poder fazer alterações ou visualizar
                textBoxTitulo.Text = documento.Titulo;
                comboBoxTipoDocumento.Text = documento.TipoDocumento.ToString();
                dateTimePickerDocumento.Value = documento.DataEntrega;
                comboBoxParecer.Text = documento.Parecer.ToString();
            }
        }

        private void btnRegistarAtribuicao_Click(object sender, EventArgs e)
        {
            // Verifica se o utilizador tem um projeto e funcionário selecionados
            if(listBoxProjetos.SelectedIndex != -1 && comboBoxFuncionario.SelectedIndex != -1)
            {
                // Recebe o objeto selecionado (Projeto)
                Projeto projeto = (Projeto)listBoxProjetos.SelectedItem;

                // Recebe o objeto selecionado (Funcionario)
                Funcionario funcionario = (Funcionario)comboBoxFuncionario.SelectedItem;

                // Criação do projeto atribuido na Base de Dados
                camaraMunicipal.ProjetoAtribuidoSet.Add(new ProjetoAtribuido(dateTimePickerAtribuicao.Value, projeto, funcionario));

                // Guarda as alterações na base de dados
                camaraMunicipal.SaveChanges();

                // Atualiza o formulário
                LerDadosFuncionarios();
            }
            else
            {
                // Mensagem de erro ao verificar que o utilizador não tem projeto e funcionário selecionados
                mensagem.AvisoSelecionarPrimeiro("projeto e preencha todos os campos.");
            }
        }

        private void btnRemoverAtribuicao_Click(object sender, EventArgs e)
        {
            // Verifica se o utilizador tem um projeto atribuido selecionado
            if (listBoxProjetoAtribuido.SelectedIndex != -1)
            {
                // Recebe o objeto selecionado (Projeto Atribuido)
                ProjetoAtribuido projetoAtribuido = (ProjetoAtribuido)listBoxProjetoAtribuido.SelectedItem;

                // Remoção do projeto atribuido na Base de Dados
                camaraMunicipal.ProjetoAtribuidoSet.Remove(projetoAtribuido);

                // Guarda as alterações na base de dados
                camaraMunicipal.SaveChanges();

                // Atualiza o formulário
                LerDadosFuncionarios();
            }
            else
            {
                // Mensagem de erro ao verificar que o utilizador não tem projeto atribuido selecionado
                mensagem.AvisoSelecionarPrimeiro("projeto atribuído.");
            }
        }
    }
}
