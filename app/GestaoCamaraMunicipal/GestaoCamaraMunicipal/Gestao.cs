using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace GestaoCamaraMunicipal
{
    public partial class Gestao : Form
    {
        Form1 formprincipal = new Form1();
        private GestaoCamaraMunicipalContainer camaraMunicipal;
        Mensagens mensagem = new Mensagens();
        int index = -1;
        int indexTipo = -1;
        int indexEspecialista = -1;

        public Gestao()
        {
            // Inicia os componentes do formulário
            InitializeComponent();
        }

        // Faz o carregamento da ComboBox com os dados possiveis para chave estrangeira
        private void Gestao_Load(object sender, EventArgs e)
        {
            camaraMunicipal = new GestaoCamaraMunicipalContainer();
            lerDados();
            btnAdicionarDocumento.Enabled = true;
            btnRemoverDocumento.Enabled = false;
            MudarBotoesTipos();
        }

        public void MudarBotoesTipos()
        {
            // Caso não tenha nenhum item selecionado na ListBox Tipos de Projetos
            if (indexTipo == -1)
            {
                // Gere os butões conforme a necessidade
                buttonAdicionar.Enabled = true;
                buttonRemover.Enabled = false;
                buttonAddFuncionario.Enabled = false;
                buttonRemoverFuncionario.Enabled = false;
            }
            else
            {
                // Gere os butões conforme a necessidade
                buttonAdicionar.Enabled = true;
                buttonRemover.Enabled = true;
                buttonAddFuncionario.Enabled = true;
            }
        }

        public void MudarBotoesEspecialistas()
        {
            // Caso não tenha nenhum item selecionado na ListBox Especialistas e Tipos de Projetos
            if (indexEspecialista == -1 && indexTipo == -1)
            {
                // Gere os butões conforme a necessidade
                buttonAddFuncionario.Enabled = false;
                buttonRemoverFuncionario.Enabled = false;
            }
            // Caso tenha um item selecionado na ListBox Especialistas e Tipos de Projetos
            else if (indexEspecialista != -1 && indexTipo != -1)
            {
                // Gere os butões conforme a necessidade
                buttonAddFuncionario.Enabled = false;
                buttonRemoverFuncionario.Enabled = true;
            }
            else if (indexEspecialista == -1 && indexTipo != -1)
            {
                // Gere os butões conforme a necessidade
                buttonAddFuncionario.Enabled = true;
                buttonRemoverFuncionario.Enabled = false;
            }
        }

        public void MudarBotoesDOC()
        {
            // Caso não tenha nenhum item selecionado na ListBox Documentos
            if (index == -1)
            {
                // Gere os butões conforme a necessidade
                btnAdicionarDocumento.Enabled = true;
                btnRemoverDocumento.Enabled = false;
            }
            else
            {
                // Gere os butões conforme a necessidade
                btnAdicionarDocumento.Enabled = false;
                btnRemoverDocumento.Enabled = true;
            }
        }

        // Coloca os dados na listBox provenientes da Base de Dados, retira a Seleção da ListBox e limpa as TextBoxs do formúlário
        private void lerDados()
        {
            listBoxDocumentos.DataSource = camaraMunicipal.TipoDocumentoSet.ToList<TipoDocumento>();
            listBoxTiposdeProjeto.DataSource = camaraMunicipal.TipoProjetoSet.ToList<TipoProjeto>();
            comboBoxFuncionario.DataSource = camaraMunicipal.FuncionarioSet.ToList<Funcionario>();

            listBoxDocumentos.ClearSelected();
            listBoxEspecialistas.ClearSelected();
            listBoxTiposdeProjeto.ClearSelected();
            LimparForm();
        }

        private void LimparForm()
        {
            comboBoxFuncionario.SelectedIndex = -1;
            textBoxDesignacao.Clear();
            numericUpDownDiasAprovacao.Value = 0;
            checkBoxDependente.Checked = false;
        }

        // Volta ao menu principal
        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Botão para Adicionar o Documento
        private void btnAdicionarDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                // Se todas as TextBoxs tiverem preenchidas Faz
                if (textBoxDocumento.Text != "")
                {
                    // Adiciona o Projeto e guarda as alterações na Base de Dados
                    camaraMunicipal.TipoDocumentoSet.Add(new TipoDocumento(textBoxDocumento.Text));
                    camaraMunicipal.SaveChanges();

                    // Recarrega as ListBox e limpa o formulário
                    lerDados();
                    textBoxDocumento.Clear();
                }
                else
                {
                    mensagem.ErroPreencherCampos();
                }
            }
            catch (Exception ex)
            {
                mensagem.Erro(ex);
            }
        }

        private void btnRemoverDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                // Se estiver algum Documento selecionado faz
                if (listBoxDocumentos.SelectedIndex != -1)
                {
                    // Varíável que recebe o objeto Documento selecionado na ListBox
                    TipoDocumento tipoDocumento = new TipoDocumento();
                    tipoDocumento = (TipoDocumento)listBoxDocumentos.SelectedItem;

                    // Remove o Documento e guarda as alterações na Base de dados
                    camaraMunicipal.TipoDocumentoSet.Remove(tipoDocumento);
                    camaraMunicipal.SaveChanges();

                    // Recarrega a ListBox e limpa o formulário
                    lerDados();
                    textBoxDocumento.Clear();
                }
                else
                {
                    mensagem.AvisoSelecionarPrimeiro("documento");
                }
            }
            catch (Exception ex)
            {
                mensagem.Erro(ex);
            }
        }

        // Botão que adiciona um Tipo de Projeto
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se todas as TextBoxs tiverem preenchidas Faz
                if (textBoxDesignacao.Text != "")
                {
                    // Se a CheckBox que diz se é dependente de outro projeto estiver selecionada faz
                    if(checkBoxDependente.Checked == true)
                    {
                        // Se tiver um tipo de projeto selecionado faz
                        if (listBoxTiposdeProjeto.SelectedIndex != -1)
                        {
                            // Recebe o objeto selecionado e Adiciona o tipo de Projeto
                            TipoProjeto tipoprojeto = new TipoProjeto();
                            tipoprojeto = (TipoProjeto)listBoxTiposdeProjeto.SelectedItem;
                            camaraMunicipal.TipoProjetoSet.Add(new TipoProjeto(textBoxDesignacao.Text, Convert.ToInt32(numericUpDownDiasAprovacao.Value), tipoprojeto.Id));
                        }
                        else
                        {
                            mensagem.AvisoSelecionarPrimeiro("tipo de projeto");
                        }
                    }
                    // Se não for dependente de outro projeto faz
                    else
                    {
                        // Adiciona o tipo de Projeto
                        camaraMunicipal.TipoProjetoSet.Add(new TipoProjeto(textBoxDesignacao.Text, Convert.ToInt32(numericUpDownDiasAprovacao.Value)));
                    }

                    // Guarda as alterações na Base de Dados, lê os dados
                    camaraMunicipal.SaveChanges();
                    lerDados();

                    // Limpa o formulário
                    LimparForm();
                }
                else
                {
                    mensagem.ErroPreencherCampos();
                }
            }
            catch (Exception ex)
            {
                mensagem.Erro(ex);
            }
        }

        private void listBoxTiposdeProjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Se estiver algum Tipo de projeto selecionado faz
                if (listBoxTiposdeProjeto.SelectedIndex != -1 && indexTipo != listBoxTiposdeProjeto.SelectedIndex)
                {
                    // Varíável que recebe o objeto Tipo de projeto selecionado na ListBox
                    TipoProjeto tipoprojeto = (TipoProjeto)listBoxTiposdeProjeto.SelectedItem;

                    // Atribui ás TextBoxs os atributos do objeto selecionado
                    textBoxDesignacao.Text = tipoprojeto.Designacao;
                    numericUpDownDiasAprovacao.Value = tipoprojeto.NrDiasAprovacao;
                    checkBoxDependente.Checked = (tipoprojeto.TipoProjetoId != null) ? true : false;

                    // Carrega os especialistas do tipo de projeto selecionado para a listBox
                    listBoxEspecialistas.DataSource = tipoprojeto.Especialista.ToList<Especialista>();
                    listBoxEspecialistas.ClearSelected();

                    // colocar o index selecionado na variável e trocar os butões caso necessário
                    indexEspecialista = -1;
                    indexTipo = listBoxTiposdeProjeto.SelectedIndex;
                    MudarBotoesTipos();
                }
                else if (listBoxTiposdeProjeto.SelectedIndex != -1 && indexTipo == listBoxTiposdeProjeto.SelectedIndex)
                {
                    // Limpa o formulário
                    LimparForm();
                    listBoxEspecialistas.SelectedIndex = -1;
                    listBoxEspecialistas.DataSource = null;

                    // Tirar a seleção da listBox
                    listBoxTiposdeProjeto.SelectedIndex = -1;
                    indexEspecialista = -1;
                    indexTipo = -1;
                    MudarBotoesTipos();
                }
            }
            catch (Exception ex)
            {
                mensagem.Erro(ex);
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            try
            {
                // Se estiver algum Tipo de projeto selecionado faz
                if (listBoxTiposdeProjeto.SelectedIndex != -1)
                {
                    // Varíável que recebe o objeto Tipo de projeto selecionado na ListBox
                    TipoProjeto tiposprojeto = (TipoProjeto)listBoxTiposdeProjeto.SelectedItem;

                    // Remove o Tipo de projetos e guarda as alterações na Base de dados
                    camaraMunicipal.TipoProjetoSet.Remove(tiposprojeto);
                    camaraMunicipal.SaveChanges();

                    // Recarrega a ListBox e limpa o formulário
                    lerDados();
                    LimparForm();
                    indexEspecialista = -1;
                    indexTipo = -1;
                    listBoxTiposdeProjeto.SelectedIndex = -1;
                    listBoxEspecialistas.SelectedIndex = -1;
                    MudarBotoesTipos();
                }
                else
                {
                    mensagem.AvisoSelecionarPrimeiro("tipo de projeto");
                }
            }
            catch (Exception ex)
            {
                mensagem.Erro(ex);
            }
        }

        private void buttonAddFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                // Se tiver algum funcionário e tipo de projeto selecionado faz
                if (comboBoxFuncionario.SelectedIndex != -1 && listBoxTiposdeProjeto.SelectedIndex != -1)
                {
                    // Recebe o tipo de projeto selecionado na ListBox
                    TipoProjeto tipoprojeto = (TipoProjeto)listBoxTiposdeProjeto.SelectedItem;
                   
                    // Recebe o funcionário selecionado na comboBox
                    Funcionario funcionario = (Funcionario)comboBoxFuncionario.SelectedItem;

                    // Cria um novo especialista
                    Especialista especialista = new Especialista();

                    // Atribui o ID de cada objeto selecionado anteriormente aos devidos atributos do especialista
                    especialista.TipoProjetoId = tipoprojeto.Id;
                    especialista.FuncionarioNumero1 = funcionario.Numero;

                    // Adiciona o Especialista e guarda as alterações na Base de Dados
                    try
                    {
                        camaraMunicipal.EspecialistaSet.Add(especialista);
                        camaraMunicipal.SaveChanges();
                    }
                    catch (DbUpdateException ex)
                    {
                        mensagem.ObjetoDuplicado("funcionário ao tipo de projeto, devido a este funcionário já estar adicionado a este");
                        camaraMunicipal.EspecialistaSet.Remove(especialista);
                    }

                    // Recebe o index da listBox de tipos de projeto que está selecionado
                    int posicao = listBoxTiposdeProjeto.SelectedIndex;

                    // Recarrega as listBoxs
                    lerDados();

                    // Seleciona o tipo de Projeto que estava selecionado anteriormente
                    listBoxTiposdeProjeto.SelectedIndex = posicao;
                }
                else
                {
                    mensagem.AvisoSelecionarPrimeiro("tipo de projeto e um funcionário");
                }
            }
            catch (Exception ex)
            {
                mensagem.Erro(ex);
            }
        }

        private void buttonRemoverFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                // Se estiver algum Tipo de projeto selecionado faz
                if (listBoxTiposdeProjeto.SelectedIndex != -1 && listBoxEspecialistas.SelectedIndex != -1)
                {
                    // Varíável que recebe o objeto Tipo de projeto selecionado na ListBox
                    Especialista especialista = (Especialista)listBoxEspecialistas.SelectedItem;

                    // Remove o Tipo de projetos e guarda as alterações na Base de dados
                    camaraMunicipal.EspecialistaSet.Remove(especialista);
                    camaraMunicipal.SaveChanges();

                    // Recarrega a ListBox
                    TipoProjeto tipoprojeto = (TipoProjeto)listBoxTiposdeProjeto.SelectedItem;
                    listBoxEspecialistas.DataSource = tipoprojeto.Especialista.ToList<Especialista>();
                    listBoxEspecialistas.ClearSelected();
                }
                else
                {
                    mensagem.AvisoSelecionarPrimeiro("tipo de projeto e um especialista");
                }
            }
            catch (Exception ex)
            {
                mensagem.Erro(ex);
            }
        }

        private void textBoxDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdicionarDocumento.PerformClick();
            }
        }

        private void listBoxDocumentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDocumentos.SelectedIndex != -1 && index != listBoxDocumentos.SelectedIndex)
            {
                index = listBoxDocumentos.SelectedIndex;
                MudarBotoesDOC();
            }
            else if (listBoxDocumentos.SelectedIndex != -1 && index == listBoxDocumentos.SelectedIndex)
            {
                listBoxDocumentos.SelectedIndex = -1;
                index = -1;
                MudarBotoesDOC();
            }
        }

        private void listBoxEspecialistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEspecialistas.SelectedIndex != -1 && indexEspecialista != listBoxEspecialistas.SelectedIndex)
            {
                indexEspecialista = listBoxEspecialistas.SelectedIndex;
                MudarBotoesEspecialistas();
            }
            else if (listBoxEspecialistas.SelectedIndex != -1 && indexEspecialista == listBoxEspecialistas.SelectedIndex)
            {
                listBoxEspecialistas.SelectedIndex = -1;
                indexEspecialista = -1;
                MudarBotoesEspecialistas();
            }
        }
    }
}
