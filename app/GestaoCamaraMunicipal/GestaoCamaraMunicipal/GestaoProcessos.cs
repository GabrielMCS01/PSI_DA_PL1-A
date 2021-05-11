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
        }

        private void lerProcessos()
        {
            listBoxProcessos.DataSource = camaraMunicipal.ProcessoSet.ToList<Processo>();
            listBoxProcessos.SelectedIndex = -1;
            LimparDados();
        }

        private void lerPromotor()
        {
            comboBoxPromotor.DataSource = camaraMunicipal.PromotorSet.ToList<Promotor>();
            comboBoxPromotor.SelectedIndex = -1;
            LimparDados();
        }

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
                    Processo processo = new Processo();
                    Promotor promotor = new Promotor();
                    EstadoProcesso estadoProcesso = new EstadoProcesso();

                    promotor = (Promotor)comboBoxPromotor.SelectedItem;

                    // Cria uma instância do Estado de Processo e o Processo
                    estadoProcesso = new EstadoProcesso(textBoxEstadoProcesso.Text);
                    processo = new Processo(dateTimePickerInicioProcesso.Value, promotor.NIF);
                    processo.EstadoProcesso = estadoProcesso;
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
                EstadoProcesso estadoProcesso = new EstadoProcesso();
                processo = (Processo)listBoxProcessos.SelectedItem;
                estadoProcesso = processo.EstadoProcesso;
                camaraMunicipal.EstadoProcessoSet.Remove(estadoProcesso);
                camaraMunicipal.ProcessoSet.Remove(processo);
                camaraMunicipal.SaveChanges();
                lerProcessos();
            }
        }

        // Botão para Guardar as alterações feitas no Funcionário
        private void btnAtualizarProcesso_Click(object sender, EventArgs e)
        {
            if (listBoxProcessos.SelectedIndex != -1 && textBoxEstadoProcesso.Text != "")
            {
                int selecionado = -1;
                Processo processo = new Processo();
                processo = (Processo)listBoxProcessos.SelectedItem;
                processo.EstadoProcesso.DescricaoEstado = textBoxEstadoProcesso.Text;
                camaraMunicipal.SaveChanges();
                selecionado = listBoxProcessos.SelectedIndex;
                lerProcessos();
                listBoxProcessos.SelectedIndex = selecionado;
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
                Processo processo = new Processo();
                processo = (Processo)listBoxProcessos.SelectedItem;
                textBoxEstadoProcesso.Text = processo.EstadoProcesso.DescricaoEstado;
                dateTimePickerInicioProcesso.Value = processo.DataInicio;
                comboBoxPromotor.Text = processo.Promotor.ToString();
            }
        }
    }
}