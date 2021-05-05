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
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            camaraMunicipal.PromotorSet.Add(new Promotor(Int32.Parse(maskedTextBoxNIF.Text), txtBoxNome.Text, txtBoxMorada.Text, txtBoxTelemovel.Text, maskedTextBoxMail.Text, txtBoxCodAcesso.Text, txtBoxPassword.Text));
            camaraMunicipal.SaveChanges();
            LerDados();
        }

        private void btnGuardarAlteracoes_Click(object sender, EventArgs e)
        {
            Promotor promotor = new Promotor();
            try
            {
                if (listBoxPromotores.SelectedItem != null)
                {
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro \n" + ex);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Promotor promotor = new Promotor();
            try
            {
                if (listBoxPromotores.SelectedItem != null)
                {
                    promotor = (Promotor)listBoxPromotores.SelectedItem;
                    camaraMunicipal.PromotorSet.Remove(promotor);
                    camaraMunicipal.SaveChanges();
                    LerDados();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro \n" + ex);
            }
        }

        private void listBoxPromotores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Promotor promotor = new Promotor();
            try
            {
                if (listBoxPromotores.SelectedItem != null)
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
                MessageBox.Show("Ocorreu um erro \n" + ex);
            }
        }
    }
}
