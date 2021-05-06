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
    public partial class GestaoPromotores : Form
    {
        Form1 formprincipal = new Form1();
        private GestaoCamaraMunicipalContainer camaraMunicipal;
        public GestaoPromotores()
        {
            InitializeComponent();
            camaraMunicipal = new GestaoCamaraMunicipalContainer();
            LerDados();
        }

        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formprincipal.Show();
            this.Hide();
        }

        private void GestaoPromotores_FormClosing(object sender, FormClosingEventArgs e)
        {
            camaraMunicipal.Dispose();
            formprincipal.Sair(e);
        }

        private void LerDados()
        {
            listBoxPromotores.DataSource = camaraMunicipal.PromotorSet.ToList<Promotor>();
            listBoxPromotores.SelectedIndex = -1;
            LimparForm();
        }

        private void LimparForm()
        {
            maskedTextBoxNIF.Clear();
            txtBoxNome.Clear();
            txtBoxMorada.Clear();
            txtBoxTelemovel.Clear();
            maskedTextBoxMail.Clear();
            txtBoxCodAcesso.Clear();
            txtBoxPassword.Clear();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (maskedTextBoxNIF.Text != "" & txtBoxNome.Text != "" & txtBoxMorada.Text != "" & txtBoxTelemovel.Text != "" & maskedTextBoxMail.Text != "" & txtBoxCodAcesso.Text != "" & txtBoxPassword.Text != "")
                {
                    camaraMunicipal.PromotorSet.Add(new Promotor(Int32.Parse(maskedTextBoxNIF.Text), txtBoxNome.Text, txtBoxMorada.Text, txtBoxTelemovel.Text, maskedTextBoxMail.Text, txtBoxCodAcesso.Text, txtBoxPassword.Text));
                    camaraMunicipal.SaveChanges();
                    LerDados();
                }
                else
                {
                    MessageBox.Show("Tem de Preencher todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarAlteracoes_Click(object sender, EventArgs e)
        {
            Promotor promotor = new Promotor();
            try
            {
                if (listBoxPromotores.SelectedIndex != -1)
                {
                    if (maskedTextBoxNIF.Text != "" & txtBoxNome.Text != "" & txtBoxMorada.Text != "" & txtBoxTelemovel.Text != "" & maskedTextBoxMail.Text != "" & txtBoxCodAcesso.Text != "" & txtBoxPassword.Text != "")
                    {
                        int posicao = listBoxPromotores.SelectedIndex;
                        promotor = (Promotor)listBoxPromotores.SelectedItem;
                        promotor.NIF = Int32.Parse(maskedTextBoxNIF.Text);
                        promotor.Nome = txtBoxNome.Text;
                        promotor.Morada = txtBoxMorada.Text;
                        promotor.Telemovel = txtBoxTelemovel.Text;
                        promotor.Email = maskedTextBoxMail.Text;
                        promotor.CodigoAcesso = txtBoxCodAcesso.Text;
                        promotor.Senha = txtBoxPassword.Text;
                        camaraMunicipal.SaveChanges();
                        LerDados();
                        listBoxPromotores.SelectedIndex = posicao;
                        MessageBox.Show("Alteração guardada com sucesso!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tem de Preencher todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                   
                }
                else
                {
                    MessageBox.Show("Selecione primeiro um promotor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Promotor promotor = new Promotor();
            try
            {
                if (listBoxPromotores.SelectedIndex != -1)
                {
                    promotor = (Promotor)listBoxPromotores.SelectedItem;
                    camaraMunicipal.PromotorSet.Remove(promotor);
                    camaraMunicipal.SaveChanges();
                    LerDados();
                    LimparForm();
                }
                else
                {
                    MessageBox.Show("Selecione primeiro um promotor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxPromotores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Promotor promotor = new Promotor();
            try
            {
                if (listBoxPromotores.SelectedIndex != -1)

                {
                    promotor = (Promotor)listBoxPromotores.SelectedItem;
                    maskedTextBoxNIF.Text = promotor.NIF.ToString();
                    txtBoxNome.Text = promotor.Nome;
                    txtBoxMorada.Text = promotor.Morada;
                    txtBoxTelemovel.Text = promotor.Telemovel;
                    maskedTextBoxMail.Text = promotor.Email;
                    txtBoxCodAcesso.Text = promotor.CodigoAcesso;
                    txtBoxPassword.Text = promotor.Senha;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
