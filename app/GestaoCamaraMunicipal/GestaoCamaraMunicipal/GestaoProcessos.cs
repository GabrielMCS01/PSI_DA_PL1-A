using System;
using System.Linq;
using System.Windows.Forms;

namespace GestaoCamaraMunicipal
{
    public partial class GestaoProcessos : Form
    {
        private GestaoCamaraMunicipalContainer camaraMunicipal;
        Mensagens mensagem = new Mensagens();
        int index = -1;

        public GestaoProcessos()
        {
            // Inicia os componentes do formulário
            InitializeComponent();
        }

        // Preenche a listBox com os dados da Base de Dados e retira a seleção
        private void lerProcessos()
        {
            listBoxProcessos.DataSource = camaraMunicipal.ProcessoSet.ToList<Processo>();
            listBoxProcessos.ClearSelected();
            index = -1;
            LimparDados();
        }

        // Preenche a ComboBox com os valores possiveis e tira a seleção
        private void lerPromotor()
        {
            comboBoxPromotor.DataSource = camaraMunicipal.PromotorSet.ToList<Promotor>();
            comboBoxPromotor.SelectedIndex = -1;
            LimparDados();
        }

        // Limpa todas as TextBoxs do formulário e tira o index selecionado nas ComboBoxs
        private void LimparDados()
        {
            dateTimePickerInicioProcesso.Value = DateTime.Now;
            comboBoxPromotor.SelectedIndex = -1;
            textBoxEstadoProcesso.Clear();
        }

        // Chamas as funções que colocam os dados nas listBox provenientes da Base de Dados
        private void GestaoProcessos_Load(object sender, EventArgs e)
        {
            // Cria uma instância do container (Ligação da Base de Dados)
            camaraMunicipal = new GestaoCamaraMunicipalContainer();
            lerProcessos();
            lerPromotor();
            MudarBotoes();
        }

        public void MudarBotoes()
        {
            // Caso não tenha nenhum item selecionado na ListBox
            if (index == -1)
            {
                // Gere os butões conforme a necessidade
                btnCriarProcesso.Enabled = true;
                btnAtualizarProcesso.Enabled = false;
                btnRemoverProcesso.Enabled = false;
            }
            else
            {
                // Gere os butões conforme a necessidade
                btnCriarProcesso.Enabled = false;
                btnAtualizarProcesso.Enabled = true;
                btnRemoverProcesso.Enabled = true;
            }
        }

        // Volta ao menu principal
        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Botão para Registar o Processo
        private void btnCriarProcesso_Click(object sender, EventArgs e)
        {
            try
            {
                // Se tiver algum Processo selecionado e a TextBox de estado de processo não estiver vazia faz
                if (comboBoxPromotor.SelectedIndex != -1 & textBoxEstadoProcesso.Text != "")
                {
                    // Recebe o promotor selecionado na listBox
                    Promotor promotor = (Promotor)comboBoxPromotor.SelectedItem;

                    // Cria uma instância do Estado de Processo e do Processo
                    EstadoProcesso estadoProcesso = new EstadoProcesso(textBoxEstadoProcesso.Text);
                    Processo processo = new Processo(dateTimePickerInicioProcesso.Value, promotor.NIF);

                    // Atribui o estado de processo ao atributo de estado de processo do processo anterior
                    processo.EstadoProcesso = estadoProcesso;

                    // Adiciona o processo e guarda as alterações na base de dados
                    camaraMunicipal.ProcessoSet.Add(processo);
                    camaraMunicipal.SaveChanges();

                    // Recarrega as ListBoxs, limpa o formulário e altera os botões
                    lerProcessos();
                    MudarBotoes();
                }
                else
                {
                    mensagem.ErroPreencherCampos();
                }
            }
            catch( Exception ex)
            {
                mensagem.Erro(ex);
            }
        }

        // Botão para Remover um Processo
        private void btnRemoverProcesso_Click(object sender, EventArgs e)
        {
            // Se estiver algum Processo selecionado faz
            if (listBoxProcessos.SelectedIndex != -1)
            {
                // Recebe o processo selecionado na listBox
                Processo processo = (Processo)listBoxProcessos.SelectedItem;

                // Atribui á variável estado de processo, o estado do processo do processo selecionado anteriormente 
                EstadoProcesso estadoProcesso = processo.EstadoProcesso;

                // Verificar se existem projetos atribuidos a este processo
                if (processo.Projeto.Count == 0)
                {
                    // Remove o estado de processo do processo selecionado para poder-se remover o processo
                    camaraMunicipal.EstadoProcessoSet.Remove(estadoProcesso);

                    // Remove o processo selecionado anteriormente e guarda as alterações
                    camaraMunicipal.ProcessoSet.Remove(processo);
                    camaraMunicipal.SaveChanges();

                    // Recarrega a listBox processos, limpa o formulário e altera os botões
                    lerProcessos();
                    MudarBotoes();
                }
                else
                {
                    mensagem.AvisoEliminarPrimeiro("os projetos atribuidos a este processo.");
                }
            }
            else
            {
                mensagem.AvisoSelecionarPrimeiro("processo");
            }
        }

        // Botão para Guardar as alterações feitas no Funcionário
        private void btnAtualizarProcesso_Click(object sender, EventArgs e)
        {
            // Se tiver algum Processo selecionado e a TextBox de estado de processo não estiver vazia faz
            if (listBoxProcessos.SelectedIndex != -1 && textBoxEstadoProcesso.Text != "")
            {
                // Recebe o processo selecionado na listBox
                Processo processo = (Processo)listBoxProcessos.SelectedItem;

                // Atualiza a descrição do estado de processo
                processo.DataInicio = dateTimePickerInicioProcesso.Value;
                processo.Promotor = (Promotor)comboBoxPromotor.SelectedItem;
                processo.EstadoProcesso.DescricaoEstado = textBoxEstadoProcesso.Text;

                // Guarda as alterações na base de dados e recebe o index da listBox que estava selecionado
                camaraMunicipal.SaveChanges();
                int selecionado = listBoxProcessos.SelectedIndex;

                // Recarrega a listBox processos e limpa o formulário
                lerProcessos();

                // Seleciona o processo que estava selecionado anteriormente
                listBoxProcessos.SelectedIndex = selecionado;

                // Confirma que o processo foi atualizado com sucesso
                mensagem.Sucesso();
            }
            else
            {
                mensagem.AvisoSelecionarPrimeiro("Processo e Preencher Todos os Campos");
            }
        }

        private void listBoxProcessos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se estiver algum Processo selecionado e se este for diferente do anterior faz
            if (listBoxProcessos.SelectedIndex != -1 && index != listBoxProcessos.SelectedIndex)
            {
                // Recebe o processo selecionado na ListBox
                Processo processo = (Processo)listBoxProcessos.SelectedItem;

                // Atribui ao formulários os atributos do objeto selecionado para se poder fazer alterações
                textBoxEstadoProcesso.Text = processo.EstadoProcesso.DescricaoEstado;
                dateTimePickerInicioProcesso.Value = processo.DataInicio;
                comboBoxPromotor.Text = processo.Promotor.ToString();

                // Alterar os botões caso necessários
                index = listBoxProcessos.SelectedIndex;
                MudarBotoes();
            }
            // Se estiver algum Processo selecionado e se este for igual ao anterior faz
            else if (listBoxProcessos.SelectedIndex != -1 && index == listBoxProcessos.SelectedIndex)
            {
                // Retira a seleção da ListBox
                listBoxProcessos.SelectedIndex = -1;
                index = -1;

                // Muda os Botões e limpa o formulário
                MudarBotoes();
                LimparDados();
            }
        }

        // AJUDA
        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Formulário de Gestão de Processos tem como principal " +
                "objetivo a inserção de Processos para que mais tarde, na criação" +
                " de um Projeto se possa atribuir um Processo. Para esse efeito " +
                "existem validações de dados que devem ser respeitadas. Deste modo, " +
                "todos os dados são validados e verificados, devendo estes estarem " +
                "corretos. Ao adicionar um Processo, quando o mesmo for criado, " +
                "serão guardados os seus dados na base de dados e mostrados na " +
                "respetiva lista disponível no formulário. A criação de processos " +
                "é um ponto muito importante deste projeto para que, mais tarde, " +
                "quando se criar um projeto, poder-se associar ao projeto um processo. " +
                "Ao processo está também associado um promotor.", "Ajuda DPM");
        }
    }
}