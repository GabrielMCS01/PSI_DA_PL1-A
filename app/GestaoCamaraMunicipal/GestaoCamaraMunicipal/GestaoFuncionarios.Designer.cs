
namespace GestaoCamaraMunicipal
{
    partial class GestaoFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoFuncionarios));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDePromotoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxFuncionarios = new System.Windows.Forms.ListBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btregistar = new System.Windows.Forms.Button();
            this.btguardarAlteracoes = new System.Windows.Forms.Button();
            this.btremover = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxExtensao = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestãoDePromotoresToolStripMenuItem});
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(60, 26);
            this.toolStripMenu.Text = "Menu";
            // 
            // gestãoDePromotoresToolStripMenuItem
            // 
            this.gestãoDePromotoresToolStripMenuItem.Name = "gestãoDePromotoresToolStripMenuItem";
            this.gestãoDePromotoresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left)));
            this.gestãoDePromotoresToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.gestãoDePromotoresToolStripMenuItem.Text = "Voltar ao Menu";
            this.gestãoDePromotoresToolStripMenuItem.Click += new System.EventHandler(this.gestãoDePromotoresToolStripMenuItem_Click);
            // 
            // listBoxFuncionarios
            // 
            this.listBoxFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFuncionarios.FormattingEnabled = true;
            this.listBoxFuncionarios.ItemHeight = 16;
            this.listBoxFuncionarios.Location = new System.Drawing.Point(4, 19);
            this.listBoxFuncionarios.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFuncionarios.Name = "listBoxFuncionarios";
            this.listBoxFuncionarios.Size = new System.Drawing.Size(344, 334);
            this.listBoxFuncionarios.TabIndex = 3;
            this.listBoxFuncionarios.SelectedIndexChanged += new System.EventHandler(this.listBoxFuncionarios_SelectedIndexChanged);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(376, 85);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(403, 22);
            this.textBoxNome.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Extensão:";
            // 
            // btregistar
            // 
            this.btregistar.Location = new System.Drawing.Point(401, 279);
            this.btregistar.Margin = new System.Windows.Forms.Padding(4);
            this.btregistar.Name = "btregistar";
            this.btregistar.Size = new System.Drawing.Size(100, 52);
            this.btregistar.TabIndex = 8;
            this.btregistar.Text = "Registar";
            this.btregistar.UseVisualStyleBackColor = true;
            this.btregistar.Click += new System.EventHandler(this.btregistar_Click);
            // 
            // btguardarAlteracoes
            // 
            this.btguardarAlteracoes.Location = new System.Drawing.Point(528, 279);
            this.btguardarAlteracoes.Margin = new System.Windows.Forms.Padding(4);
            this.btguardarAlteracoes.Name = "btguardarAlteracoes";
            this.btguardarAlteracoes.Size = new System.Drawing.Size(101, 52);
            this.btguardarAlteracoes.TabIndex = 9;
            this.btguardarAlteracoes.Text = "Guardar Alterações";
            this.btguardarAlteracoes.UseVisualStyleBackColor = true;
            this.btguardarAlteracoes.Click += new System.EventHandler(this.btguardarAlteracoes_Click);
            // 
            // btremover
            // 
            this.btremover.Location = new System.Drawing.Point(659, 279);
            this.btremover.Margin = new System.Windows.Forms.Padding(4);
            this.btremover.Name = "btremover";
            this.btremover.Size = new System.Drawing.Size(100, 52);
            this.btremover.TabIndex = 10;
            this.btremover.Text = "Remover";
            this.btremover.UseVisualStyleBackColor = true;
            this.btremover.Click += new System.EventHandler(this.btremover_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxFuncionarios);
            this.groupBox1.Location = new System.Drawing.Point(16, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(352, 357);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionários";
            // 
            // textBoxExtensao
            // 
            this.textBoxExtensao.Location = new System.Drawing.Point(376, 148);
            this.textBoxExtensao.Name = "textBoxExtensao";
            this.textBoxExtensao.Size = new System.Drawing.Size(403, 22);
            this.textBoxExtensao.TabIndex = 13;
            // 
            // GestaoFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.textBoxExtensao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btremover);
            this.Controls.Add(this.btguardarAlteracoes);
            this.Controls.Add(this.btregistar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GestaoFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Funcionários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestaoFuncionarios_FormClosing);
            this.Load += new System.EventHandler(this.GestaoFuncionarios_Load);
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
        private System.Windows.Forms.ListBox listBoxFuncionarios;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btregistar;
        private System.Windows.Forms.Button btguardarAlteracoes;
        private System.Windows.Forms.Button btremover;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxExtensao;
    }
}
