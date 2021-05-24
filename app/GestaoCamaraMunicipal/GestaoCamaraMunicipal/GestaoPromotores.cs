using System;
using System.Linq;
using System.Windows.Forms;

namespace GestaoCamaraMunicipal
{
    public partial class GestaoPromotores : Form
    {
        Form1 formprincipal = new Form1();
        private GestaoCamaraMunicipalContainer camaraMunicipal;
        Mensagens mensagem = new Mensagens();

        public GestaoPromotores()
        {
            // Inicia os componentes do formulário e lê os dados da Base de Dados e coloca-os na ListBox
            InitializeComponent();
        }

        // Faz o carregamento das listBoxs com os dados existentes na base de dados
        private void GestaoPromotores_Load(object sender, EventArgs e)
        {
            camaraMunicipal = new GestaoCamaraMunicipalContainer();
            LerDados();
        }

        // Volta ao menu principal
        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formprincipal.Show();
            this.Hide();
        }

        // Faz quando o formulário fecha
        private void GestaoPromotores_FormClosing(object sender, FormClosingEventArgs e)
        {
            camaraMunicipal.Dispose();
            formprincipal.Sair(e);
        }

        // Coloca os dados na listBox provenientes da Base de Dados, tira a Seleção da ListBox e limpa as TextBoxs do formúlário
        private void LerDados()
        {
            listBoxPromotores.DataSource = camaraMunicipal.PromotorSet.ToList<Promotor>();
            listBoxPromotores.SelectedIndex = -1;
            LimparForm();
        }

        // Limpa todas as TextBoxs do formulário
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

        // Botão para Registar o promotor
        private void btnRegistar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se todas as TextBoxs tiverem preenchidas Faz
                if (maskedTextBoxNIF.Text != "" & txtBoxNome.Text != "" & txtBoxMorada.Text != "" & txtBoxTelemovel.Text != "" & maskedTextBoxMail.Text != "" & txtBoxCodAcesso.Text != "" & txtBoxPassword.Text != "")
                {
                    // Adiciona o promotor e guarda as alterações na Base de Dados
                    camaraMunicipal.PromotorSet.Add(new Promotor(Int32.Parse(maskedTextBoxNIF.Text), txtBoxNome.Text, txtBoxMorada.Text, txtBoxTelemovel.Text, maskedTextBoxMail.Text, txtBoxCodAcesso.Text, txtBoxPassword.Text));
                    camaraMunicipal.SaveChanges();

                    // Recarrega a ListBox e limpa o formulário
                    LerDados();
                }
                else
                {
                    mensagem.ErroPreencherCampos();
                }
            }
            catch(FormatException ex)
            {
                mensagem.Erro(ex);
            }
        }

        // Botão para Guardar as alterações feitas no Promotor
        private void btnGuardarAlteracoes_Click(object sender, EventArgs e)
        {
            Promotor promotor = new Promotor();
            try
            {
                // Se estiver algum promotor selecionado faz
                if (listBoxPromotores.SelectedIndex != -1)
                {
                    // Se todas as TextBoxs tiverem preenchidas Faz
                    if (maskedTextBoxNIF.Text != "" & txtBoxNome.Text != "" & txtBoxMorada.Text != "" & txtBoxTelemovel.Text != "" & maskedTextBoxMail.Text != "" & txtBoxCodAcesso.Text != "" & txtBoxPassword.Text != "")
                    {
                        // Variável para receber o index selecionado na ListBox promotores
                        int posicao = listBoxPromotores.SelectedIndex;

                        // Varíável que recebe o objeto Promotor selecionado na ListBox
                        promotor = (Promotor)listBoxPromotores.SelectedItem;

                        // Atribui ao objeto anterior as alterações executadas anteriormente no formulário
                        promotor.NIF = Int32.Parse(maskedTextBoxNIF.Text);
                        promotor.Nome = txtBoxNome.Text;
                        promotor.Morada = txtBoxMorada.Text;
                        promotor.Telemovel = txtBoxTelemovel.Text;
                        promotor.Email = maskedTextBoxMail.Text;
                        promotor.CodigoAcesso = txtBoxCodAcesso.Text;
                        promotor.Senha = txtBoxPassword.Text;

                        // Guarda as alterações do objeto na Base de Dados
                        camaraMunicipal.SaveChanges();

                        // Recarrega a ListBox e limpa o formulário
                        LerDados();

                        // Seleciona o index utilizado anteriormente
                        listBoxPromotores.SelectedIndex = posicao;
                        mensagem.Sucesso();
                    }
                    else
                    {
                        mensagem.ErroPreencherCampos();
                    }                   
                }
                else
                {
                    mensagem.AvisoSelecionarPrimeiro("promotor");
                }
            }
            catch (Exception ex)
            {
                mensagem.Erro(ex);
            }
        }
        // Botão para Remover um promotor
        private void btnRemover_Click(object sender, EventArgs e)
        {
            Promotor promotor = new Promotor();
            try
            {
                // Se estiver algum promotor selecionado faz
                if (listBoxPromotores.SelectedIndex != -1)
                {
                    // Varíável que recebe o objeto Promotor selecionado na ListBox
                    promotor = (Promotor)listBoxPromotores.SelectedItem;

                    // Remove o Promotor e guarda as alterações na Base de dados
                    camaraMunicipal.PromotorSet.Remove(promotor);
                    camaraMunicipal.SaveChanges();

                    // Recarrega a ListBox e limpa o formulário
                    LerDados();
                    LimparForm();
                }
                else
                {
                    mensagem.AvisoSelecionarPrimeiro("promotor");
                }
            }
            catch(Exception ex)
            {
                mensagem.Erro(ex);
            }
        }

        // Mudança no index selecionado na ListBox
        private void listBoxPromotores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Se estiver algum promotor selecionado faz
                if (listBoxPromotores.SelectedIndex != -1)
                {
                    // Varíável que recebe o objeto Promotor selecionado na ListBox
                    Promotor promotor = (Promotor)listBoxPromotores.SelectedItem;

                    // Atribui ás TextBoxs os atributos do objeto selecionado
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
                mensagem.Erro(ex);
            }
        }
    }
}
