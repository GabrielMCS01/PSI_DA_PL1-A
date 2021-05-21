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
            //Ler dados dos projetos
            listBoxProjetos.DataSource = camaraMunicipal.ProjetoSet.ToList<Projeto>();
            comboBoxTiposProjeto.DataSource = camaraMunicipal.TipoProjetoSet.ToList<TipoProjeto>();
            comboBoxProcesso.DataSource = camaraMunicipal.ProcessoSet.ToList<Processo>();
            
            //Ler dados dos documentos
            listBoxDocumentos.DataSource = camaraMunicipal.DocumentoSet.ToList<Documento>();
            comboBoxTipoDocumento.DataSource = camaraMunicipal.TipoDocumentoSet.ToList<TipoDocumento>();
            comboBoxParecer.DataSource = camaraMunicipal.ParecerSet.ToList<Parecer>();

            //Ler dados dos projetos atribuidos
            listBoxProjetoAtribuido.DataSource = camaraMunicipal.ProjetoAtribuidoSet.ToList<ProjetoAtribuido>();
            comboBoxFuncionario.DataSource = camaraMunicipal.FuncionarioSet.ToList<Funcionario>(); 

            LimparForm();
        }

        // Limpa todas as TextBoxs do formulário e tira o index selecionado nas ComboBoxs
        private void LimparForm()
        {
            //Limpar campos dos projetos
            listBoxProjetos.ClearSelected();
            textBoxEstadoProjeto.Clear();
            comboBoxTiposProjeto.SelectedIndex = -1;
            dateTimePickerProjeto.Value = DateTime.Now;
            comboBoxProcesso.SelectedIndex = -1;

            //Limpar campos dos documentos
            listBoxDocumentos.ClearSelected();
            textBoxTitulo.Clear();
            comboBoxTipoDocumento.SelectedIndex = -1;
            dateTimePickerDocumento.Value = DateTime.Now;
            comboBoxParecer.SelectedIndex = -1;

            //Limpar campos dos projetos atribuidos
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

        private void listBoxProjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProjetos.SelectedIndex != -1)
            {
                Projeto projeto = (Projeto)listBoxProjetos.SelectedItem;
                textBoxEstadoProjeto.Text = projeto.EstadoProjeto;
                comboBoxTiposProjeto.Text = projeto.TipoProjeto.ToString();
                dateTimePickerProjeto.Value = projeto.DataAprovacao;
                comboBoxProcesso.Text = projeto.Processo.ToString();
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
                    LerDados();
                    LimparForm();
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
                    LerDados();
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
                Documento documento = (Documento)listBoxDocumentos.SelectedItem;
                textBoxTitulo.Text = documento.Titulo;
                comboBoxTipoDocumento.Text = documento.TipoDocumento.ToString();
                dateTimePickerDocumento.Value = documento.DataEntrega;
                comboBoxParecer.Text = documento.Parecer.ToString();
            }
        }

        private void btnRegistarAtribuicao_Click(object sender, EventArgs e)
        {
            //Verificar que o utilizador tem projeto e funcionário selecionados
            if(listBoxProjetos.SelectedIndex != -1 && comboBoxFuncionario.SelectedIndex != -1)
            {
                //Buscar o objeto selecionado(Projeto)
                Projeto projeto = (Projeto)listBoxProjetos.SelectedItem;
                //Buscar o objeto selecionado(Funcionario)
                Funcionario funcionario = (Funcionario)comboBoxFuncionario.SelectedItem;
                //Criação do projeto atribuido na Base de Dados
                camaraMunicipal.ProjetoAtribuidoSet.Add(new ProjetoAtribuido(dateTimePickerAtribuicao.Value, projeto, funcionario));
                //Salvar mudanças e guardar o projeto atribuido na base de dados
                camaraMunicipal.SaveChanges();
                //Atualizar o formulário
                LerDados();
            }
            else
            {
                //mensagem de erro ao verificar que o utilizador não tem projeto e funcionário selecionados
                mensagem.AvisoSelecionarPrimeiro("projeto e preencha todos os campos.");
            }
        }

        private void btnRemoverAtribuicao_Click(object sender, EventArgs e)
        {
            //Verificar que o utilizador tem projeto atribuido selecionado
            if (listBoxProjetoAtribuido.SelectedIndex != -1)
            {
                //Buscar o objeto selecionado(Projeto Atribuido)
                ProjetoAtribuido projetoAtribuido = (ProjetoAtribuido)listBoxProjetoAtribuido.SelectedItem;
                //Remoção do projeto atribuido na Base de Dados
                camaraMunicipal.ProjetoAtribuidoSet.Remove(projetoAtribuido);
                //Salvar mudanças e remover o projeto atribuido na base de dados
                camaraMunicipal.SaveChanges();
                //Atualizar o formulário
                LerDados();
            }
            else
            {
                //mensagem de erro ao verificar que o utilizador não tem projeto atribuido selecionado
                mensagem.AvisoSelecionarPrimeiro("projeto atribuído.");
            }
        }
    }
}
