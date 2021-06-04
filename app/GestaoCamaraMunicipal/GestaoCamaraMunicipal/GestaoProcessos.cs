using System;
using System.Linq;
using System.Windows.Forms;

namespace GestaoCamaraMunicipal
{
    public partial class GestaoProcessos : Form
    {
        private GestaoCamaraMunicipalContainer camaraMunicipal;
        Form1 formprincipal = new Form1();
        Mensagens mensagem = new Mensagens();
        int index = -1;

        public GestaoProcessos()
        {
            // Inicia os componentes do formulário e cria uma instância do container
            InitializeComponent();
        }

        // Preenche a ComboBox com os valores possiveis e tira a seleção
        private void lerProcessos()
        {
            listBoxProcessos.DataSource = camaraMunicipal.ProcessoSet.ToList<Processo>();
            listBoxProcessos.SelectedIndex = -1;
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
                // Se todas as TextBoxs tiverem preenchidas Faz
                if (comboBoxPromotor.SelectedIndex != -1 & textBoxEstadoProcesso.Text != "")
                {
                    Processo processo = new Processo();
                    Promotor promotor = new Promotor();
                    EstadoProcesso estadoProcesso = new EstadoProcesso();

                    // Recebe o promotor selecionado na listBox
                    promotor = (Promotor)comboBoxPromotor.SelectedItem;

                    // Cria uma instância do Estado de Processo e do Processo
                    estadoProcesso = new EstadoProcesso(textBoxEstadoProcesso.Text);
                    processo = new Processo(dateTimePickerInicioProcesso.Value, promotor.NIF);

                    // Atribui o estado de processo ao atributo de estado de processo do processo anterior
                    processo.EstadoProcesso = estadoProcesso;

                    // Adiciona o processo e guarda as alterações na base de dados
                    camaraMunicipal.ProcessoSet.Add(processo);
                    camaraMunicipal.SaveChanges();

                    // Recarrega as ListBoxs e limpa o formulário
                    lerProcessos();
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
                // Varíável que recebe o objeto Processo selecionado na ListBox
                Processo processo = new Processo();
                EstadoProcesso estadoProcesso = new EstadoProcesso();

                // Recebe o processo selecionado na listBox
                processo = (Processo)listBoxProcessos.SelectedItem;

                // Atribui á variável estado de processo, o estado do processo do processo selecionado anteriormente 
                estadoProcesso = processo.EstadoProcesso;

                // Remove o estado de processo do processo selecionado para poder-se remover o processo
                camaraMunicipal.EstadoProcessoSet.Remove(estadoProcesso);

                // Remove o processo selecionado anteriormente e guarda as alterações
                camaraMunicipal.ProcessoSet.Remove(processo);
                camaraMunicipal.SaveChanges();

                // Recarrega a listBox processos e limpa o formulário
                lerProcessos();
            }
            else
            {
                mensagem.AvisoSelecionarPrimeiro("processo");
            }
        }

        // Botão para Guardar as alterações feitas no Funcionário
        private void btnAtualizarProcesso_Click(object sender, EventArgs e)
        {
            if (listBoxProcessos.SelectedIndex != -1 && textBoxEstadoProcesso.Text != "")
            {
                int selecionado = -1;

                // Recebe o processo selecionado na listBox
                Processo processo = new Processo();
                processo = (Processo)listBoxProcessos.SelectedItem;

                // Atualiza a descrição do estado de processo e guarda as alterações na base de dados
                processo.DataInicio = dateTimePickerInicioProcesso.Value;
                processo.Promotor = (Promotor)comboBoxPromotor.SelectedItem;
                processo.EstadoProcesso.DescricaoEstado = textBoxEstadoProcesso.Text;


                camaraMunicipal.SaveChanges();
                selecionado = listBoxProcessos.SelectedIndex;

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
            // Se estiver algum Processo selecionado faz
            if (listBoxProcessos.SelectedIndex != -1 && index != listBoxProcessos.SelectedIndex)
            {
                // Recebe o processo selecionado na ListBox
                Processo processo = new Processo();
                processo = (Processo)listBoxProcessos.SelectedItem;

                // Atribui ao formulários os atributos do objeto selecionado para se poder fazer alterações
                textBoxEstadoProcesso.Text = processo.EstadoProcesso.DescricaoEstado;
                dateTimePickerInicioProcesso.Value = processo.DataInicio;
                comboBoxPromotor.Text = processo.Promotor.ToString();

                // Alterar os botões caso necessários
                index = listBoxProcessos.SelectedIndex;
                MudarBotoes();
            }
            else if (listBoxProcessos.SelectedIndex != -1 && index == listBoxProcessos.SelectedIndex)
            {
                listBoxProcessos.SelectedIndex = -1;
                index = -1;
                MudarBotoes();

                LimparDados();
            }
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Formulário de Gestão de Processos tem como principal objetivo" +
                " a inserção de Processos para que mais tarde, na criação de um Projeto se possa atribuir um Processo. " +
                " Para esse efeito existem validações de dados que devem ser respeitadas.", "Ajuda DPM");

        }
    }
}