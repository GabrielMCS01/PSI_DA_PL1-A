
namespace GestaoCamaraMunicipal
{
    partial class GestaoPromotores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoPromotores));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDePromotoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxPromotores = new System.Windows.Forms.ListBox();
            this.lblNIF = new System.Windows.Forms.Label();
            this.maskedTextBoxNIF = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxMorada = new System.Windows.Forms.TextBox();
            this.lblMorada = new System.Windows.Forms.Label();
            this.txtBoxTelemovel = new System.Windows.Forms.TextBox();
            this.lblTelemovel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.maskedTextBoxMail = new System.Windows.Forms.MaskedTextBox();
            this.lblCodAcesso = new System.Windows.Forms.Label();
            this.txtBoxCodAcesso = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.btnGuardarAlteracoes = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(589, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestãoDePromotoresToolStripMenuItem});
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenu.Text = "Menu";
            // 
            // gestãoDePromotoresToolStripMenuItem
            // 
            this.gestãoDePromotoresToolStripMenuItem.Name = "gestãoDePromotoresToolStripMenuItem";
            this.gestãoDePromotoresToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.gestãoDePromotoresToolStripMenuItem.Text = "Voltar ao Menu";
            this.gestãoDePromotoresToolStripMenuItem.Click += new System.EventHandler(this.gestãoDePromotoresToolStripMenuItem_Click);
            // 
            // listBoxPromotores
            // 
            this.listBoxPromotores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPromotores.FormattingEnabled = true;
            this.listBoxPromotores.Location = new System.Drawing.Point(3, 16);
            this.listBoxPromotores.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPromotores.Name = "listBoxPromotores";
            this.listBoxPromotores.Size = new System.Drawing.Size(276, 287);
            this.listBoxPromotores.TabIndex = 2;
            this.listBoxPromotores.SelectedIndexChanged += new System.EventHandler(this.listBoxPromotores_SelectedIndexChanged);
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Location = new System.Drawing.Point(336, 41);
            this.lblNIF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(27, 13);
            this.lblNIF.TabIndex = 4;
            this.lblNIF.Text = "NIF:";
            // 
            // maskedTextBoxNIF
            // 
            this.maskedTextBoxNIF.Location = new System.Drawing.Point(338, 54);
            this.maskedTextBoxNIF.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxNIF.Mask = "999999999";
            this.maskedTextBoxNIF.Name = "maskedTextBoxNIF";
            this.maskedTextBoxNIF.Size = new System.Drawing.Size(206, 20);
            this.maskedTextBoxNIF.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(336, 75);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(338, 88);
            this.txtBoxNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(206, 20);
            this.txtBoxNome.TabIndex = 7;
            // 
            // txtBoxMorada
            // 
            this.txtBoxMorada.Location = new System.Drawing.Point(338, 124);
            this.txtBoxMorada.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxMorada.Name = "txtBoxMorada";
            this.txtBoxMorada.Size = new System.Drawing.Size(206, 20);
            this.txtBoxMorada.TabIndex = 9;
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Location = new System.Drawing.Point(338, 111);
            this.lblMorada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(46, 13);
            this.lblMorada.TabIndex = 8;
            this.lblMorada.Text = "Morada:";
            // 
            // txtBoxTelemovel
            // 
            this.txtBoxTelemovel.Location = new System.Drawing.Point(338, 159);
            this.txtBoxTelemovel.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxTelemovel.MaxLength = 9;
            this.txtBoxTelemovel.Name = "txtBoxTelemovel";
            this.txtBoxTelemovel.Size = new System.Drawing.Size(206, 20);
            this.txtBoxTelemovel.TabIndex = 11;
            // 
            // lblTelemovel
            // 
            this.lblTelemovel.AutoSize = true;
            this.lblTelemovel.Location = new System.Drawing.Point(339, 146);
            this.lblTelemovel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelemovel.Name = "lblTelemovel";
            this.lblTelemovel.Size = new System.Drawing.Size(59, 13);
            this.lblTelemovel.TabIndex = 10;
            this.lblTelemovel.Text = "Telemóvel:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(340, 184);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "E-mail:";
            // 
            // maskedTextBoxMail
            // 
            this.maskedTextBoxMail.Location = new System.Drawing.Point(339, 198);
            this.maskedTextBoxMail.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxMail.Mask = "aaaaaaaaaaaaaaaaaa@aaaaaaaaa.aaa";
            this.maskedTextBoxMail.Name = "maskedTextBoxMail";
            this.maskedTextBoxMail.Size = new System.Drawing.Size(205, 20);
            this.maskedTextBoxMail.TabIndex = 13;
            // 
            // lblCodAcesso
            // 
            this.lblCodAcesso.AutoSize = true;
            this.lblCodAcesso.Location = new System.Drawing.Point(336, 219);
            this.lblCodAcesso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodAcesso.Name = "lblCodAcesso";
            this.lblCodAcesso.Size = new System.Drawing.Size(96, 13);
            this.lblCodAcesso.TabIndex = 14;
            this.lblCodAcesso.Text = "Código de Acesso:";
            // 
            // txtBoxCodAcesso
            // 
            this.txtBoxCodAcesso.Location = new System.Drawing.Point(338, 233);
            this.txtBoxCodAcesso.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxCodAcesso.Name = "txtBoxCodAcesso";
            this.txtBoxCodAcesso.Size = new System.Drawing.Size(206, 20);
            this.txtBoxCodAcesso.TabIndex = 21;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(336, 255);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password:";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(338, 269);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(206, 20);
            this.txtBoxPassword.TabIndex = 17;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(305, 305);
            this.btnRegistar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(76, 42);
            this.btnRegistar.TabIndex = 18;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // btnGuardarAlteracoes
            // 
            this.btnGuardarAlteracoes.Location = new System.Drawing.Point(401, 305);
            this.btnGuardarAlteracoes.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarAlteracoes.Name = "btnGuardarAlteracoes";
            this.btnGuardarAlteracoes.Size = new System.Drawing.Size(76, 42);
            this.btnGuardarAlteracoes.TabIndex = 19;
            this.btnGuardarAlteracoes.Text = "Guardar Alterações";
            this.btnGuardarAlteracoes.UseVisualStyleBackColor = true;
            this.btnGuardarAlteracoes.Click += new System.EventHandler(this.btnGuardarAlteracoes_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(497, 305);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(76, 42);
            this.btnRemover.TabIndex = 20;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxPromotores);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 306);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Promotores";
            // 
            // GestaoPromotores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 364);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnGuardarAlteracoes);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtBoxCodAcesso);
            this.Controls.Add(this.lblCodAcesso);
            this.Controls.Add(this.maskedTextBoxMail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtBoxTelemovel);
            this.Controls.Add(this.lblTelemovel);
            this.Controls.Add(this.txtBoxMorada);
            this.Controls.Add(this.lblMorada);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.maskedTextBoxNIF);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestaoPromotores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Promotores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestaoPromotores_FormClosing);
            this.Load += new System.EventHandler(this.GestaoPromotores_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem gestãoDePromotoresToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxPromotores;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNIF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxMorada;
        private System.Windows.Forms.Label lblMorada;
        private System.Windows.Forms.TextBox txtBoxTelemovel;
        private System.Windows.Forms.Label lblTelemovel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMail;
        private System.Windows.Forms.Label lblCodAcesso;
        private System.Windows.Forms.TextBox txtBoxCodAcesso;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Button btnGuardarAlteracoes;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
