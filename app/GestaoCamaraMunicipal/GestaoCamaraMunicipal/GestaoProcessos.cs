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
            InitializeComponent();
            camaraMunicipal = new GestaoCamaraMunicipalContainer();
        }

        public void lerProcessos()
        {
            listBoxProcessos.DataSource = camaraMunicipal.ProcessoSet.ToList<Processo>();
        }

        public void lerPromotor()
        {
            comboBoxPromotor.DataSource = camaraMunicipal.PromotorSet.ToList<Promotor>();
        }

        private void GestaoProcessos_Load(object sender, EventArgs e)
        {
            lerProcessos();
            lerPromotor();
        }

        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formprincipal.Show();
            this.Hide();
        }

        private void GestaoProcessos_FormClosing(object sender, FormClosingEventArgs e)
        {
            formprincipal.Sair(e);
        }

        private void btnCriarProcesso_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPromotor.SelectedIndex != -1 & textBoxEstadoProcesso.Text != "")
                {
                    EstadoProcesso estadoProcesso = new EstadoProcesso();
                    Processo processo = new Processo();
                    Promotor promotor = new Promotor();
                    promotor = (Promotor)comboBoxPromotor.SelectedItem;
                    estadoProcesso = new EstadoProcesso(textBoxEstadoProcesso.Text);
                    processo = new Processo(dateTimePickerInicioProcesso.Value, promotor.NIF, estadoProcesso.Id);
                    camaraMunicipal.EstadoProcessoSet.Add(estadoProcesso);
                    camaraMunicipal.ProcessoSet.Add(processo);
                    camaraMunicipal.SaveChanges();
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

        private void btnRemoverProcesso_Click(object sender, EventArgs e)
        {
            if (listBoxProcessos.SelectedIndex != -1)
            {
                Processo processo = new Processo();
                processo = (Processo)listBoxProcessos.SelectedItem;
                foreach (EstadoProcesso estadoProcesso in camaraMunicipal.EstadoProcessoSet.ToList<EstadoProcesso>())
                {
                    if (processo.EstadoProcessoId == estadoProcesso.Id)
                    {
                        camaraMunicipal.EstadoProcessoSet.Remove(estadoProcesso);
                    }
                }
                camaraMunicipal.ProcessoSet.Remove(processo);
                camaraMunicipal.SaveChanges();
                listBoxEstadoProcesso.DataSource = null;
                lerProcessos();
            }
        }

        private void btnAtualizarProcesso_Click(object sender, EventArgs e)
        {
            if (listBoxEstadoProcesso.SelectedIndex != -1 & textBoxEstadoProcesso.Text != "")
            {
                EstadoProcesso estadoProcesso = new EstadoProcesso();
                estadoProcesso = (EstadoProcesso)listBoxEstadoProcesso.SelectedItem;
                estadoProcesso.DescricaoEstado = textBoxEstadoProcesso.Text;
                camaraMunicipal.SaveChanges();
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
            if (listBoxProcessos.SelectedIndex != -1)
            {
                List<EstadoProcesso> estadoProcessos = new List<EstadoProcesso>();
                Processo processo = new Processo();
                processo = (Processo)listBoxProcessos.SelectedItem;
                foreach (EstadoProcesso estadoProcesso in camaraMunicipal.EstadoProcessoSet.ToList<EstadoProcesso>())
                {
                    if (processo.EstadoProcessoId == estadoProcesso.Id)
                    {
                        estadoProcessos.Add(estadoProcesso);
                    }
                }
                listBoxEstadoProcesso.DataSource = estadoProcessos;
            }
        }
    }
}
