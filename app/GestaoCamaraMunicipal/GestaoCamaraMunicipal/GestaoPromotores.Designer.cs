
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
            this.lblTelemovel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCodAcesso = new System.Windows.Forms.Label();
            this.txtBoxCodAcesso = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.btnGuardarAlteracoes = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxTelemovel = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(785, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestãoDePromotoresToolStripMenuItem});
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(60, 24);
            this.toolStripMenu.Text = "Menu";
            // 
            // gestãoDePromotoresToolStripMenuItem
            // 
            this.gestãoDePromotoresToolStripMenuItem.Name = "gestãoDePromotoresToolStripMenuItem";
            this.gestãoDePromotoresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.gestãoDePromotoresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gestãoDePromotoresToolStripMenuItem.Text = "Fechar";
            this.gestãoDePromotoresToolStripMenuItem.Click += new System.EventHandler(this.gestãoDePromotoresToolStripMenuItem_Click);
            // 
            // listBoxPromotores
            // 
            this.listBoxPromotores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPromotores.FormattingEnabled = true;
            this.listBoxPromotores.ItemHeight = 16;
            this.listBoxPromotores.Location = new System.Drawing.Point(4, 19);
            this.listBoxPromotores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPromotores.Name = "listBoxPromotores";
            this.listBoxPromotores.Size = new System.Drawing.Size(368, 354);
            this.listBoxPromotores.TabIndex = 2;
            this.listBoxPromotores.SelectedIndexChanged += new System.EventHandler(this.listBoxPromotores_SelectedIndexChanged);
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Location = new System.Drawing.Point(448, 50);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(33, 17);
            this.lblNIF.TabIndex = 4;
            this.lblNIF.Text = "NIF:";
            // 
            // maskedTextBoxNIF
            // 
            this.maskedTextBoxNIF.Location = new System.Drawing.Point(451, 66);
            this.maskedTextBoxNIF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxNIF.Mask = "999999999";
            this.maskedTextBoxNIF.Name = "maskedTextBoxNIF";
            this.maskedTextBoxNIF.Size = new System.Drawing.Size(273, 22);
            this.maskedTextBoxNIF.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(448, 92);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(451, 108);
            this.txtBoxNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(273, 22);
            this.txtBoxNome.TabIndex = 7;
            // 
            // txtBoxMorada
            // 
            this.txtBoxMorada.Location = new System.Drawing.Point(451, 153);
            this.txtBoxMorada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxMorada.Name = "txtBoxMorada";
            this.txtBoxMorada.Size = new System.Drawing.Size(273, 22);
            this.txtBoxMorada.TabIndex = 9;
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Location = new System.Drawing.Point(451, 137);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(60, 17);
            this.lblMorada.TabIndex = 8;
            this.lblMorada.Text = "Morada:";
            // 
            // lblTelemovel
            // 
            this.lblTelemovel.AutoSize = true;
            this.lblTelemovel.Location = new System.Drawing.Point(452, 180);
            this.lblTelemovel.Name = "lblTelemovel";
            this.lblTelemovel.Size = new System.Drawing.Size(77, 17);
            this.lblTelemovel.TabIndex = 10;
            this.lblTelemovel.Text = "Telemóvel:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(453, 226);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 17);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblCodAcesso
            // 
            this.lblCodAcesso.AutoSize = true;
            this.lblCodAcesso.Location = new System.Drawing.Point(448, 270);
            this.lblCodAcesso.Name = "lblCodAcesso";
            this.lblCodAcesso.Size = new System.Drawing.Size(126, 17);
            this.lblCodAcesso.TabIndex = 14;
            this.lblCodAcesso.Text = "Código de Acesso:";
            // 
            // txtBoxCodAcesso
            // 
            this.txtBoxCodAcesso.Location = new System.Drawing.Point(451, 287);
            this.txtBoxCodAcesso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxCodAcesso.Name = "txtBoxCodAcesso";
            this.txtBoxCodAcesso.Size = new System.Drawing.Size(273, 22);
            this.txtBoxCodAcesso.TabIndex = 21;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(448, 314);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password:";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(451, 331);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(273, 22);
            this.txtBoxPassword.TabIndex = 17;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(407, 375);
            this.btnRegistar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(101, 52);
            this.btnRegistar.TabIndex = 18;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // btnGuardarAlteracoes
            // 
            this.btnGuardarAlteracoes.Location = new System.Drawing.Point(535, 375);
            this.btnGuardarAlteracoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarAlteracoes.Name = "btnGuardarAlteracoes";
            this.btnGuardarAlteracoes.Size = new System.Drawing.Size(101, 52);
            this.btnGuardarAlteracoes.TabIndex = 19;
            this.btnGuardarAlteracoes.Text = "Guardar Alterações";
            this.btnGuardarAlteracoes.UseVisualStyleBackColor = true;
            this.btnGuardarAlteracoes.Click += new System.EventHandler(this.btnGuardarAlteracoes_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(663, 375);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(101, 52);
            this.btnRemover.TabIndex = 20;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxPromotores);
            this.groupBox1.Location = new System.Drawing.Point(16, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(376, 377);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Promotores";
            // 
            // maskedTextBoxTelemovel
            // 
            this.maskedTextBoxTelemovel.Location = new System.Drawing.Point(498, 199);
            this.maskedTextBoxTelemovel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxTelemovel.Mask = "999999999";
            this.maskedTextBoxTelemovel.Name = "maskedTextBoxTelemovel";
            this.maskedTextBoxTelemovel.Size = new System.Drawing.Size(226, 22);
            this.maskedTextBoxTelemovel.TabIndex = 23;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(451, 245);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(273, 22);
            this.tbEmail.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "+351";
            // 
            // GestaoPromotores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.maskedTextBoxTelemovel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnGuardarAlteracoes);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtBoxCodAcesso);
            this.Controls.Add(this.lblCodAcesso);
            this.Controls.Add(this.lblEmail);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GestaoPromotores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DPM - Gestão de Promotores";
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
        private System.Windows.Forms.Label lblTelemovel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCodAcesso;
        private System.Windows.Forms.TextBox txtBoxCodAcesso;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Button btnGuardarAlteracoes;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelemovel;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label1;
    }
}
