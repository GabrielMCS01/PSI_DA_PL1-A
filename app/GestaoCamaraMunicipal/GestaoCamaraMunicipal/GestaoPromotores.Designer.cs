
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
            this.menuStrip1.SuspendLayout();
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
<<<<<<< Updated upstream
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
=======
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======
            // listBoxPromotores
            // 
            this.listBoxPromotores.FormattingEnabled = true;
            this.listBoxPromotores.Location = new System.Drawing.Point(24, 50);
            this.listBoxPromotores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxPromotores.Name = "listBoxPromotores";
            this.listBoxPromotores.Size = new System.Drawing.Size(215, 329);
            this.listBoxPromotores.TabIndex = 2;
            this.listBoxPromotores.SelectedIndexChanged += new System.EventHandler(this.listBoxPromotores_SelectedIndexChanged);
            // 
            // lblPromotores
            // 
            this.lblPromotores.AutoSize = true;
            this.lblPromotores.Location = new System.Drawing.Point(22, 34);
            this.lblPromotores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromotores.Name = "lblPromotores";
            this.lblPromotores.Size = new System.Drawing.Size(60, 13);
            this.lblPromotores.TabIndex = 3;
            this.lblPromotores.Text = "Promotores";
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Location = new System.Drawing.Point(256, 55);
            this.lblNIF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(24, 13);
            this.lblNIF.TabIndex = 4;
            this.lblNIF.Text = "NIF";
            // 
            // maskedTextBoxNIF
            // 
            this.maskedTextBoxNIF.Location = new System.Drawing.Point(259, 72);
            this.maskedTextBoxNIF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTextBoxNIF.Mask = "999999999";
            this.maskedTextBoxNIF.Name = "maskedTextBoxNIF";
            this.maskedTextBoxNIF.Size = new System.Drawing.Size(62, 20);
            this.maskedTextBoxNIF.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(256, 97);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(259, 113);
            this.txtBoxNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(206, 20);
            this.txtBoxNome.TabIndex = 7;
            // 
            // txtBoxMorada
            // 
            this.txtBoxMorada.Location = new System.Drawing.Point(259, 157);
            this.txtBoxMorada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxMorada.Name = "txtBoxMorada";
            this.txtBoxMorada.Size = new System.Drawing.Size(206, 20);
            this.txtBoxMorada.TabIndex = 9;
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Location = new System.Drawing.Point(258, 141);
            this.lblMorada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(43, 13);
            this.lblMorada.TabIndex = 8;
            this.lblMorada.Text = "Morada";
            // 
            // txtBoxTelemovel
            // 
            this.txtBoxTelemovel.Location = new System.Drawing.Point(259, 201);
            this.txtBoxTelemovel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxTelemovel.MaxLength = 9;
            this.txtBoxTelemovel.Name = "txtBoxTelemovel";
            this.txtBoxTelemovel.Size = new System.Drawing.Size(108, 20);
            this.txtBoxTelemovel.TabIndex = 11;
            // 
            // lblTelemovel
            // 
            this.lblTelemovel.AutoSize = true;
            this.lblTelemovel.Location = new System.Drawing.Point(260, 184);
            this.lblTelemovel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelemovel.Name = "lblTelemovel";
            this.lblTelemovel.Size = new System.Drawing.Size(56, 13);
            this.lblTelemovel.TabIndex = 10;
            this.lblTelemovel.Text = "Telemovel";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(261, 232);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "E-mail";
            // 
            // maskedTextBoxMail
            // 
            this.maskedTextBoxMail.Location = new System.Drawing.Point(260, 248);
            this.maskedTextBoxMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTextBoxMail.Mask = "aaaaaaaaaaaaaaaaaa@aaaaaaaaa.aaa";
            this.maskedTextBoxMail.Name = "maskedTextBoxMail";
            this.maskedTextBoxMail.Size = new System.Drawing.Size(201, 20);
            this.maskedTextBoxMail.TabIndex = 13;
            // 
            // lblCodAcesso
            // 
            this.lblCodAcesso.AutoSize = true;
            this.lblCodAcesso.Location = new System.Drawing.Point(256, 275);
            this.lblCodAcesso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodAcesso.Name = "lblCodAcesso";
            this.lblCodAcesso.Size = new System.Drawing.Size(93, 13);
            this.lblCodAcesso.TabIndex = 14;
            this.lblCodAcesso.Text = "Código de Acesso";
            // 
            // txtBoxCodAcesso
            // 
            this.txtBoxCodAcesso.Location = new System.Drawing.Point(259, 292);
            this.txtBoxCodAcesso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxCodAcesso.Name = "txtBoxCodAcesso";
            this.txtBoxCodAcesso.Size = new System.Drawing.Size(108, 20);
            this.txtBoxCodAcesso.TabIndex = 15;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(256, 319);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(259, 336);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(128, 20);
            this.txtBoxPassword.TabIndex = 17;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(259, 363);
            this.btnRegistar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(102, 24);
            this.btnRegistar.TabIndex = 18;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // btnGuardarAlteracoes
            // 
            this.btnGuardarAlteracoes.Location = new System.Drawing.Point(376, 363);
            this.btnGuardarAlteracoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardarAlteracoes.Name = "btnGuardarAlteracoes";
            this.btnGuardarAlteracoes.Size = new System.Drawing.Size(123, 24);
            this.btnGuardarAlteracoes.TabIndex = 19;
            this.btnGuardarAlteracoes.Text = "Guardar Alterações";
            this.btnGuardarAlteracoes.UseVisualStyleBackColor = true;
            this.btnGuardarAlteracoes.Click += new System.EventHandler(this.btnGuardarAlteracoes_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(514, 363);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(102, 24);
            this.btnRemover.TabIndex = 20;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
>>>>>>> Stashed changes
            // GestaoPromotores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< Updated upstream
            this.ClientSize = new System.Drawing.Size(600, 366);
=======
            this.ClientSize = new System.Drawing.Size(725, 396);
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
            this.Controls.Add(this.lblPromotores);
            this.Controls.Add(this.listBoxPromotores);
>>>>>>> Stashed changes
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GestaoPromotores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Promotores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestaoPromotores_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem gestãoDePromotoresToolStripMenuItem;
    }
}