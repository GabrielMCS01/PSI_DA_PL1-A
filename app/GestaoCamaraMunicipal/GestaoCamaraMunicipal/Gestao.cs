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
    public partial class Gestao : Form
    {
        Form1 formprincipal = new Form1();
        private GestaoCamaraMunicipalContainer camaraMunicipal;
        Mensagens mensagem = new Mensagens();
          
        public Gestao()
        {
            InitializeComponent();
        }
        private void Gestao_Load(object sender, EventArgs e)
        {
            camaraMunicipal = new GestaoCamaraMunicipalContainer();
            lerDados();
        }

        private void lerDados()
        {
            listBoxDocumentos.DataSource = camaraMunicipal.TipoDocumentoSet.ToList<TipoDocumento>();
            listBoxTiposdeProjeto.DataSource = camaraMunicipal.TipoProjetoSet.ToList<TipoProjeto>();
            comboBoxFuncionario.DataSource = camaraMunicipal.FuncionarioSet.ToList<Funcionario>();

            listBoxDocumentos.ClearSelected();
            listBoxTiposdeProjeto.ClearSelected();
            comboBoxFuncionario.SelectedIndex = -1;

        }

        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formprincipal.Show();
            this.Hide();
        }

        private void btnAdicionarDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDocumento.Text != "")
                {
                    camaraMunicipal.TipoDocumentoSet.Add(new TipoDocumento(textBoxDocumento.Text));
                    camaraMunicipal.SaveChanges();
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
                if (listBoxDocumentos.SelectedIndex != -1)
                {
                    TipoDocumento tipoDocumento = new TipoDocumento();
                    tipoDocumento = (TipoDocumento)listBoxDocumentos.SelectedItem;
                    camaraMunicipal.TipoDocumentoSet.Remove(tipoDocumento);
                    camaraMunicipal.SaveChanges();
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

        private void Gestao_FormClosing(object sender, FormClosingEventArgs e)
        {
            formprincipal.Sair(e);
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDesignacao.Text != "")
                {
                    if(checkBoxDependente.Checked == true)
                    {
                        if (listBoxTiposdeProjeto.SelectedIndex != -1)
                        {
                            TipoProjeto tipoprojeto = new TipoProjeto();
                            tipoprojeto = (TipoProjeto)listBoxTiposdeProjeto.SelectedItem;
                            camaraMunicipal.TipoProjetoSet.Add(new TipoProjeto(textBoxDesignacao.Text, Convert.ToInt32(numericUpDownDiasAprovacao.Value), tipoprojeto.Id));
                        }
                        else
                        {
                            mensagem.AvisoSelecionarPrimeiro("tipo de projeto");
                        }
                    }
                    else
                    {
                        camaraMunicipal.TipoProjetoSet.Add(new TipoProjeto(textBoxDesignacao.Text, Convert.ToInt32(numericUpDownDiasAprovacao.Value)));
                    }
                   
                    camaraMunicipal.SaveChanges();
                    lerDados();
                    textBoxDesignacao.Clear();
                    numericUpDownDiasAprovacao.Value = 0;
                    checkBoxDependente.Checked = false;
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
                if (listBoxTiposdeProjeto.SelectedIndex != -1)
                {
                    // Varíável que recebe o objeto Tipo de projeto selecionado na ListBox
                    TipoProjeto tipoprojeto = (TipoProjeto)listBoxTiposdeProjeto.SelectedItem;

                    // Atribui ás TextBoxs os atributos do objeto selecionado
                    textBoxDesignacao.Text = tipoprojeto.Designacao;
                    numericUpDownDiasAprovacao.Value = tipoprojeto.NrDiasAprovacao;
                    checkBoxDependente.Checked = (tipoprojeto.TipoProjetoId != null) ? true : false;

                    listBoxEspecialistas.DataSource = tipoprojeto.Especialista.ToList<Especialista>();
                }
                else
                {
                    textBoxDesignacao.Clear();
                    numericUpDownDiasAprovacao.Value = 0;
                    checkBoxDependente.Checked = false;
                    listBoxEspecialistas.DataSource = null;
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
                    textBoxDesignacao.Clear();
                    numericUpDownDiasAprovacao.Value = 0;
                    checkBoxDependente.Checked = false;
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
                if (comboBoxFuncionario.SelectedIndex != -1 && listBoxTiposdeProjeto.SelectedIndex != -1)
                {
                    TipoProjeto tipoprojeto = (TipoProjeto)listBoxTiposdeProjeto.SelectedItem;
                    Funcionario funcionario = (Funcionario)comboBoxFuncionario.SelectedItem;
                    Especialista especialista = new Especialista();
                    especialista.TipoProjetoId = tipoprojeto.Id;
                    especialista.FuncionarioNumero1 = funcionario.Numero;
                    camaraMunicipal.EspecialistaSet.Add(especialista);
                    camaraMunicipal.SaveChanges();
                    int posicao = listBoxEspecialistas.SelectedIndex;
                    lerDados();
                    listBoxEspecialistas.SelectedIndex = posicao;
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
    }
}
