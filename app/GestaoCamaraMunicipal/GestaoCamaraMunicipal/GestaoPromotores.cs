using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GestaoCamaraMunicipal
{
    public partial class GestaoPromotores : Form
    {
        private GestaoCamaraMunicipalContainer camaraMunicipal;
        Mensagens mensagem = new Mensagens();
        int index = -1;

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
            MudarBotoes();
        }

        public void MudarBotoes()
        {
            // Caso não tenha nenhum item selecionado na ListBox
            if (index == -1)
            {
                // Gere os butões conforme a necessidade
                btnRegistar.Enabled = true;
                btnGuardarAlteracoes.Enabled = false;
                btnRemover.Enabled = false;
            }
            else 
            {
                // Gere os butões conforme a necessidade
                btnRegistar.Enabled = false;
                btnGuardarAlteracoes.Enabled = true;
                btnRemover.Enabled = true;
            }
        }

        // Volta ao menu principal
        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Coloca os dados na listBox provenientes da Base de Dados, retira a Seleção da ListBox e limpa as TextBoxs do formulário
        private void LerDados()
        {
            listBoxPromotores.DataSource = camaraMunicipal.PromotorSet.ToList<Promotor>();
            listBoxPromotores.SelectedIndex = -1;
            index = -1;
            LimparForm();
        }

        // Limpa todas as TextBoxs do formulário
        private void LimparForm()
        {
            maskedTextBoxNIF.Clear();
            txtBoxNome.Clear();
            txtBoxMorada.Clear();
            maskedTextBoxTelemovel.Clear();
            tbEmail.Clear();
            txtBoxCodAcesso.Clear();
            txtBoxPassword.Clear();
            maskedTextBoxNIF.ReadOnly = false;
        }

        public bool VerificarEmail(string Email)
        {
            try
            {
                // Cadeia de verificação de caracteres (Regular expression)
                Regex rg = new Regex(@"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$");

                // Se o email for válido retorna true
                if (rg.IsMatch(Email))
                {
                    return true;
                }
                // Se o email for inválido retorna false
                else
                {
                    return false;
                }
            }
            catch (ArgumentException)
            {
                mensagem.ErroPreencherCampo("Email");
            }

            // Caso não faça o IF retorna false para dar erro na criação do promotor
            return false;
        }


        // Botão para Registar o promotor
        private void btnRegistar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se todas as TextBoxs tiverem preenchidas Faz
                if (maskedTextBoxNIF.Text != "" & txtBoxNome.Text != "" & txtBoxMorada.Text != "" & maskedTextBoxTelemovel.Text != "" & tbEmail.Text != "" & txtBoxCodAcesso.Text != "" & txtBoxPassword.Text != "")
                {
                    string Email = tbEmail.Text;
                    Promotor promotor;

                    // Se a TextBox NIF e Telémovel tiver 9 carateres faz
                    if (maskedTextBoxNIF.Text.Length == 9 && maskedTextBoxTelemovel.Text.Length == 9)
                    {
                        // Recebe as variáveis do formulário
                        int NIF = int.Parse(maskedTextBoxNIF.Text);
                        string Nome = txtBoxNome.Text;
                        string Morada = txtBoxMorada.Text;
                        string Telemovel = maskedTextBoxTelemovel.Text;
                        string Password = txtBoxPassword.Text;
                        string CodAcesso = txtBoxCodAcesso.Text;

                        // Verifica se o Email está válido
                        bool EmailValidacao = VerificarEmail(Email);
                       
                        // Se a validação for verdadeira adiciona o promotor
                        if (EmailValidacao == true)
                        {
                            promotor = new Promotor(NIF, Nome, Morada, Telemovel, Email, CodAcesso, Password);

                            // Adiciona o promotor e guarda as alterações na Base de Dados
                            try
                            {
                                camaraMunicipal.PromotorSet.Add(promotor);
                                camaraMunicipal.SaveChanges();
                            }
                            // Se o mesmo NIF já existir na Base de Dados
                            catch (DbUpdateException)
                            {
                                mensagem.ObjetoDuplicado("NIF ao promotor, devido a este já estar registado na Base de Dados");
                                camaraMunicipal.PromotorSet.Remove(promotor);
                            }

                            // Recarrega a ListBox e limpa o formulário
                            LerDados();
                            MudarBotoes();
                        }
                    }
                    else
                    {
                        mensagem.PreenchaCorretamente("o Promotor devido ao campo NIF e Telemóvel não terem ambos 9 carateres");
                        return;
                    }
                }
                else
                {
                    mensagem.ErroPreencherCampos();
                }
            }
            catch (FormatException ex)
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
                    string Email = tbEmail.Text;

                    // Se todas as TextBoxs tiverem preenchidas Faz
                    if (maskedTextBoxNIF.Text != "" & txtBoxNome.Text != "" & txtBoxMorada.Text != "" & maskedTextBoxTelemovel.Text != "" & tbEmail.Text != "" & txtBoxCodAcesso.Text != "" & txtBoxPassword.Text != "")
                    {
                        // Variável para receber o index selecionado na ListBox promotores
                        int posicao = listBoxPromotores.SelectedIndex;

                        // Varíável que recebe o objeto Promotor selecionado na ListBox
                        promotor = (Promotor)listBoxPromotores.SelectedItem;

                        // Atribui ao objeto anterior as alterações executadas anteriormente no formulário
                        promotor.NIF = Int32.Parse(maskedTextBoxNIF.Text);
                        promotor.Nome = txtBoxNome.Text;
                        promotor.Morada = txtBoxMorada.Text;
                        promotor.Telemovel = maskedTextBoxTelemovel.Text;
                        promotor.Email = Email;
                        promotor.CodigoAcesso = txtBoxCodAcesso.Text;
                        promotor.Senha = txtBoxPassword.Text;

                        // Verifica se o Email está válido
                        bool EmailValidacao = VerificarEmail(Email);

                        if (EmailValidacao == true)
                        {
                            try
                            {
                                // Guarda as alterações do objeto na Base de Dados
                                camaraMunicipal.SaveChanges();

                                // Recarrega a ListBox e limpa o formulário
                                LerDados();

                                // Seleciona o index utilizado anteriormente
                                listBoxPromotores.SelectedIndex = posicao;
                                mensagem.Sucesso();
                            }
                            catch (DbUpdateException)
                            {
                                mensagem.ObjetoDuplicado("Campo NIF, devido a este já estar registado na Base de Dados");
                            }
                        }
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
                    MudarBotoes();
                    LimparForm();
                }
                else
                {
                    mensagem.AvisoSelecionarPrimeiro("Promotor");
                }
            }
            catch (Exception ex)
            {
                mensagem.Erro(ex);
            }
        }

        // Mudança no index selecionado na ListBox
        private void listBoxPromotores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Se estiver algum promotor selecionado e se este for diferente do anterior faz
                if (listBoxPromotores.SelectedIndex != -1 && index != listBoxPromotores.SelectedIndex)
                {
                    // Varíável que recebe o objeto Promotor selecionado na ListBox
                    Promotor promotor = (Promotor)listBoxPromotores.SelectedItem;

                    // Atribui ás TextBoxs os atributos do objeto selecionado
                    maskedTextBoxNIF.Text = promotor.NIF.ToString();
                    txtBoxNome.Text = promotor.Nome;
                    txtBoxMorada.Text = promotor.Morada;
                    maskedTextBoxTelemovel.Text = promotor.Telemovel;
                    tbEmail.Text = promotor.Email;
                    txtBoxCodAcesso.Text = promotor.CodigoAcesso;
                    txtBoxPassword.Text = promotor.Senha;

                    // Bloquear a textBox NIF
                    maskedTextBoxNIF.ReadOnly = true;

                    // Alterar os botões caso necessários
                    index = listBoxPromotores.SelectedIndex;
                    MudarBotoes();
                }
                // Se estiver algum promotor selecionado e se este for igual ao anterior faz
                else if (listBoxPromotores.SelectedIndex != -1 && index == listBoxPromotores.SelectedIndex)
                {
                    // Retira a seleção da listBox promotores
                    listBoxPromotores.SelectedIndex = -1;
                    index = -1;

                    // Muda os botões e limpa o formulário
                    MudarBotoes();
                    LimparForm();
                }

            }
            catch (Exception ex)
            {
                mensagem.Erro(ex);
            }
        }

        // AJUDA
        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Formulário de Gestão de Promotores tem como principal objetivo" +
                " a inserção de Promotores. Para esse efeito existem validações de dados que devem ser respeitadas.", "Ajuda DPM");
        }
    }
}
