using System;
using System.Collections.Generic;
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
        int indexProcesso = -1;
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
            LerDadosProcessos();
            // Ler todos os tipos de documentos
            LerTiposDocumentos();
        }

        private void LerTiposDocumentos()
        {
            // Ler todos os tipos de documentos
            comboBoxTipoDocumento.DataSource = camaraMunicipal.TipoDocumentoSet.ToList<TipoDocumento>();

            // Ler pareceres
            comboBoxParecer.DataSource = camaraMunicipal.ParecerSet.ToList<Parecer>();

            // Colocar no index -1 das combobox
            comboBoxTipoDocumento.SelectedIndex = -1;
            comboBoxParecer.SelectedIndex = -1;
        }

        public void MudarBotoesPareceres()
        {
            // Caso não tenha nenhum item selecionado na ListBox
            if (indexProcesso == -1)
            {
                // Gere os butões para quando não existe nenhum processo selecionado
                btRegistarProjeto.Enabled = false;
                btGuardarAlteracoesProjetos.Enabled = false;
                btRemoverProjetos.Enabled = false;
            }
            else
            {
                // Gere os butões para quando existe um processo selecionado
                btRegistarProjeto.Enabled = true;
                btGuardarAlteracoesProjetos.Enabled = false;
                btRemoverProjetos.Enabled = false;
            }
        }

        public void MudarBotoesProjetos()
        {
            if (indexProjeto == -1)
            {
                // Gere os butões para quando não existe um processo selecionado
                btRegistarProjeto.Enabled = true;
                btGuardarAlteracoesProjetos.Enabled = false;
                btRemoverProjetos.Enabled = false;
            }
            else
            {
                // Gere os butões para quando existe um processo selecionado
                btRegistarProjeto.Enabled = false;
                btGuardarAlteracoesProjetos.Enabled = true;
                btRemoverProjetos.Enabled = true;
            }
        }

        public void MudarBotoesDocumentos()
        {
            if (indexDOC == -1)
            {
                // Gere os butões para quando não existe um Documento selecionado
                btRegistarDocumento.Enabled = true;
                btGuardarAlteraçõesDocumento.Enabled = false;
                btRemoverDocumento.Enabled = false;
            }
            else
            {
                // Gere os butões para quando existe um Documento selecionado
                btRegistarDocumento.Enabled = false;
                btGuardarAlteraçõesDocumento.Enabled = true;
                btRemoverDocumento.Enabled = true;
            }
        }

        public void MudarBotoesFuncionarios()
        {
            if (indexFuncionarios == -1)
            {
                // Gere os butões para quando não existe um Funcionario selecionado
                btnRegistarAtribuicao.Enabled = true;
                btnRemoverAtribuicao.Enabled = false;
            }
            else
            {
                // Gere os butões para quando existe um Funcionario selecionado
                btnRegistarAtribuicao.Enabled = false;
                btnRemoverAtribuicao.Enabled = true;
            }
        }

        // Volta ao menu principal
        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            if(comboBoxProcesso.SelectedIndex != -1)
            {
                //Criar um objeto processo para guardar o processo selecionado na combobox processo
                Processo processo = (Processo)comboBoxProcesso.SelectedItem;
                // Ler dados dos projetos
                listBoxProjetos.DataSource = processo.Projeto.ToList<Projeto>();
                comboBoxTiposProjeto.DataSource = camaraMunicipal.TipoProjetoSet.ToList<TipoProjeto>();
                listBoxDocumentos.DataSource = null;
                indexDOC = -1;
                listBoxProjetoAtribuido.DataSource = null;
                indexFuncionarios = -1;
            }
            LimparFormProjetos();
        }

        private void LerDadosProcessos()
        {
            // Ler dados dos processos
            comboBoxProcesso.DataSource = camaraMunicipal.ProcessoSet.ToList<Processo>();

            // Limpar o index da combobox
            comboBoxProcesso.SelectedIndex = -1;

            // Limpar listbox projetos e documentos
            listBoxProjetos.DataSource = null;
            indexProjeto = -1;

            // Limpar listbox dos funcionários com projeto atribuido
            listBoxProjetoAtribuido.DataSource = null;
            
        }

        private void LerDadosDocumentos(Projeto projeto)
        {
            // Apresentar lista de documentos do projeto
            listBoxDocumentos.DataSource = projeto.Documento.ToList<Documento>();
            LimparFormDocumentos();        
        }

        private void LerDadosFuncionarios(Projeto projeto)
        {
            // Ler funcionários registados
            TipoProjeto tipoProjeto = projeto.TipoProjeto;
            comboBoxFuncionario.DataSource = tipoProjeto.Especialista.ToList<Especialista>();
            LimparFormFuncionarios();
        }

        private void LerDadosFuncionariosAtribuidos(Projeto projeto)
        {
            // Ler funcionários registados num projeto atribuido
            listBoxProjetoAtribuido.DataSource = projeto.ProjetoAtribuido.ToList<ProjetoAtribuido>();
        }

        // Limpa todas as TextBoxs do formulário e tira o index selecionado nas ComboBoxs
        private void LimparFormProjetos()
        {
            // Limpar campos dos projetos
            listBoxProjetos.SelectedIndex = -1;
            indexProjeto = -1;
            MudarBotoesPareceres();
            textBoxEstadoProjeto.Clear();
            comboBoxTiposProjeto.SelectedIndex = -1;
            dateTimePickerProjeto.Value = DateTime.Now;
        }       

        private void LimparFormDocumentos()
        {
            // Limpar campos dos documentos
            listBoxDocumentos.SelectedIndex = -1;
            indexDOC = -1;
            textBoxTitulo.Clear();
            comboBoxTipoDocumento.SelectedIndex = -1;
            dateTimePickerDocumento.Value = DateTime.Now;
            comboBoxParecer.SelectedIndex = -1;   
        }

        private void LimparFormFuncionarios()
        {
            // Limpar campos dos projetos atribuidos
            listBoxProjetoAtribuido.SelectedIndex = -1;
            indexFuncionarios = -1;
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
                        projeto.DataAprovacao = dateTimePickerProjeto.Value;

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

                // Carrega na ListBox os documentos do projeto selecionado
                LerDadosDocumentos(projeto);

                // Atualiza a list box de funcionário atribuidos ao projeto
                LerDadosFuncionariosAtribuidos(projeto);

                // Carrega a combobox funcionários apenas com funcionários especialistas no tipo de projeto
                // do projeto selecionado
                LerDadosFuncionarios(projeto);

                // Altera a seleção dos botões caso não tenha tido nenhum projeto selecionado anteriormente
                MudarBotoesPareceres();
                indexProjeto = listBoxProjetos.SelectedIndex;
            }
            else if (listBoxProjetos.SelectedIndex != -1 && indexProjeto == listBoxProjetos.SelectedIndex)
            {
                // Retira a seleção do projeto caso clique duas vezes no mesmo projeto
                LimparFormDocumentos();
                LimparFormFuncionarios();
                LimparFormProjetos();

                MudarBotoesPareceres();

                
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
                    // Varíável que recebe o objeto Projeto selecionado na ListBox
                    Projeto projeto = (Projeto)listBoxProjetos.SelectedItem;
                    LerDadosDocumentos(projeto);
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

                // Recebe o objeto selecionado (Especialista)
                Especialista especialista = (Especialista)comboBoxFuncionario.SelectedItem;

                // Criação do projeto atribuido na Base de Dados
                camaraMunicipal.ProjetoAtribuidoSet.Add(new ProjetoAtribuido(dateTimePickerAtribuicao.Value, projeto, especialista.Funcionario));

                 // Guarda as alterações na base de dados
                camaraMunicipal.SaveChanges();

                // Atualiza o formulário
                LerDadosFuncionarios(projeto);

                // Atualiza a list box de funcionário atribuidos ao projeto
                LerDadosFuncionariosAtribuidos(projeto);
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

                // Recebe o objeto selecionado (Projeto)
                Projeto projeto = (Projeto)listBoxProjetos.SelectedItem;

                // Atualiza o formulário
                LerDadosFuncionarios(projeto);

                // Atualiza a list box de funcionário atribuidos ao projeto
                LerDadosFuncionariosAtribuidos(projeto);
            }
            else
            {
                // Mensagem de erro ao verificar que o utilizador não tem projeto atribuido selecionado
                mensagem.AvisoSelecionarPrimeiro("projeto atribuído.");
            }
        }

        private void comboBoxProcesso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxProcesso.SelectedIndex != -1)
            {
                LerDadosProjetos();
                MudarBotoesPareceres();
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            // Verificar que a list box tem um objeto selecionado
            if(listBoxDocumentos.SelectedIndex != -1)
            {
                // Guardar num objeto o documento selecionado
                Documento documento = (Documento)listBoxDocumentos.SelectedItem;
                // Remover o documento da bd
                camaraMunicipal.DocumentoSet.Remove(documento);
                // guardar alterações na bd
                camaraMunicipal.SaveChanges();
                // Varíável que recebe o objeto Projeto selecionado na ListBox
                Projeto projeto = (Projeto)listBoxProjetos.SelectedItem;
                // Atualiza a listbox documentos
                LerDadosDocumentos(projeto);
            }
            else
            {
                // Caso contrário emitir mensagem de erro
                mensagem.AvisoSelecionarPrimeiro("documento.");
            }
        }

        private void btGuardarAlterações_Click(object sender, EventArgs e)
        {
            // Verificar que a list box tem um objeto selecionado
            if (listBoxDocumentos.SelectedIndex != -1)
            {
                // Guardar num objeto o documento selecionado
                Documento documento = (Documento)listBoxDocumentos.SelectedItem;
                // Atualizar campos do documento
                documento.DataEntrega = dateTimePickerDocumento.Value;
                documento.Titulo = textBoxTitulo.Text;
                documento.Parecer = (Parecer)comboBoxParecer.SelectedItem;
                documento.TipoDocumento = (TipoDocumento)comboBoxTipoDocumento.SelectedItem;
                // guardar alterações na bd
                camaraMunicipal.SaveChanges();
                // Varíável que recebe o objeto Projeto selecionado na ListBox
                Projeto projeto = (Projeto)listBoxProjetos.SelectedItem;
                // Atualiza a listbox documentos
                LerDadosDocumentos(projeto);
            }
            else
            {
                // Caso contrário emitir mensagem de erro
                mensagem.AvisoSelecionarPrimeiro("documento.");
            }
        }
    }
}
