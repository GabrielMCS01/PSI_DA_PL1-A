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
    public partial class GestaoProcessos : Form
    {
        private GestaoCamaraMunicipalContainer camaraMunicipal;
        Form1 formprincipal = new Form1();

        public GestaoProcessos()
        {
            // Inicia os componentes do formulário e cria uma instância do container
            InitializeComponent();
            camaraMunicipal = new GestaoCamaraMunicipalContainer();
        }

        // Coloca os dados dos Processos na listBox provenientes da Base de Dados
        public void lerProcessos()
        {
            listBoxProcessos.DataSource = camaraMunicipal.ProcessoSet.ToList<Processo>();
        }

        // Coloca os dados dos Promotores na listBox provenientes da Base de Dados
        public void lerPromotor()
        {
            comboBoxPromotor.DataSource = camaraMunicipal.PromotorSet.ToList<Promotor>();
        }

        // Chamas as funções que colocam os dados nas listBox provenientes da Base de Dados
        private void GestaoProcessos_Load(object sender, EventArgs e)
        {
            lerProcessos();
            lerPromotor();
        }

        // Volta ao menu principal
        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formprincipal.Show();
            this.Hide();
        }

        // Faz quando o formulário fecha
        private void GestaoProcessos_FormClosing(object sender, FormClosingEventArgs e)
        {
            formprincipal.Sair(e);
        }

        // Botão para Registar o Processo
        private void btnCriarProcesso_Click(object sender, EventArgs e)
        {
            try
            {
                // Se todas as TextBoxs tiverem preenchidas Faz
                if (comboBoxPromotor.SelectedIndex != -1 & textBoxEstadoProcesso.Text != "")
                {
                    // Cria um Novo Processo, Estado Processo e um Promotor
                    EstadoProcesso estadoProcesso = new EstadoProcesso();
                    Processo processo = new Processo();
                    Promotor promotor = new Promotor();

                    // Recebe o promotor selecionado na ComboBox
                    promotor = (Promotor)comboBoxPromotor.SelectedItem;

                    // Cria uma instância do Estado de Processo e o Processo
                    estadoProcesso = new EstadoProcesso(textBoxEstadoProcesso.Text);
                    processo = new Processo(dateTimePickerInicioProcesso.Value, promotor.NIF, estadoProcesso.Id);

                    // Adiciona o Estado de Processo e o Processo e guarda as alterações na Base de Dados
                    camaraMunicipal.EstadoProcessoSet.Add(estadoProcesso);
                    camaraMunicipal.ProcessoSet.Add(processo);
                    camaraMunicipal.SaveChanges();

                    // Recarrega as ListBoxs e limpa o formulário
                    lerProcessos();
                }
                else
                {
                    MessageBox.Show("Tem de Preencher todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                processo = (Processo)listBoxProcessos.SelectedItem;

                // Para cada estado de Processo no Processo
                foreach (EstadoProcesso estadoProcesso in camaraMunicipal.EstadoProcessoSet.ToList<EstadoProcesso>())
                {
                    // Se o Processo ID for Igual
                    if (processo.EstadoProcessoId == estadoProcesso.Id)
                    {
                        // Remove o Estado de Processo do Processo
                        camaraMunicipal.EstadoProcessoSet.Remove(estadoProcesso);
                    }
                }

                // Remove o Processo e guarda as alterações na Base de dados
                camaraMunicipal.ProcessoSet.Remove(processo);
                camaraMunicipal.SaveChanges();

                // Elimina da ListBox os estados do Projeto
                listBoxEstadoProcesso.DataSource = null;

                // Recarrega as ListBoxs e limpa o formulário
                lerProcessos();
            }
        }

        // Botão para Guardar as alterações feitas no Funcionário
        private void btnAtualizarProcesso_Click(object sender, EventArgs e)
        {
            // Se estiver algum Funcionário selecionado e as TextBoxs tiverem preenchidas faz 
            if (listBoxEstadoProcesso.SelectedIndex != -1 & textBoxEstadoProcesso.Text != "")
            {
                // Varíável que recebe o objeto Estado de Processo selecionado na ListBox
                EstadoProcesso estadoProcesso = new EstadoProcesso();
                estadoProcesso = (EstadoProcesso)listBoxEstadoProcesso.SelectedItem;

                // Atribui ao objeto anterior as alterações executadas anteriormente no formulário
                estadoProcesso.DescricaoEstado = textBoxEstadoProcesso.Text;

                // Guarda as alterações do objeto na Base de Dados
                camaraMunicipal.SaveChanges();

                // Recarrega as ListBox
                lerProcessos();

                MessageBox.Show("Alteração guardada com sucesso!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Tem de Selecionar um Processo e Preencher Todos os Campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxProcessos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se estiver algum Processo selecionado faz
            if (listBoxProcessos.SelectedIndex != -1)
            {
                // Variável de lista de Estados de Processos 
                List<EstadoProcesso> estadoProcessos = new List<EstadoProcesso>();

                // Cria uma instância nova de Processo e recebe o item selecionado na ListBox
                Processo processo = new Processo();
                processo = (Processo)listBoxProcessos.SelectedItem;

                // Para cada Estado de Processo do Processo selecionado anteriormente
                foreach (EstadoProcesso estadoProcesso in camaraMunicipal.EstadoProcessoSet.ToList<EstadoProcesso>())
                {
                    // Se o Processo ID for Igual
                    if (processo.EstadoProcessoId == estadoProcesso.Id)
                    {
                        // Adiciona o Estado Processo á Lista
                        estadoProcessos.Add(estadoProcesso);
                    }
                }

                // Carrega na ListBox a lista de Estados de Processos selecionados anteriormente
                listBoxEstadoProcesso.DataSource = estadoProcessos;
            }
        }
    }
}