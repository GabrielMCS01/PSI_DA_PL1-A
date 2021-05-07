
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
            this.comboBoxEspecialidade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btregistar = new System.Windows.Forms.Button();
            this.btguardarAlteracoes = new System.Windows.Forms.Button();
            this.btremover = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 2;
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
            // listBoxFuncionarios
            // 
            this.listBoxFuncionarios.FormattingEnabled = true;
            this.listBoxFuncionarios.Location = new System.Drawing.Point(13, 52);
            this.listBoxFuncionarios.Name = "listBoxFuncionarios";
            this.listBoxFuncionarios.Size = new System.Drawing.Size(263, 160);
            this.listBoxFuncionarios.TabIndex = 3;
            this.listBoxFuncionarios.SelectedIndexChanged += new System.EventHandler(this.listBoxFuncionarios_SelectedIndexChanged);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(285, 54);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(303, 20);
            this.textBoxNome.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // comboBoxEspecialidade
            // 
            this.comboBoxEspecialidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEspecialidade.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEspecialidade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxEspecialidade.FormattingEnabled = true;
            this.comboBoxEspecialidade.Items.AddRange(new object[] {
            "Presidente",
            "Vereador",
            "Vice-presidente"});
            this.comboBoxEspecialidade.Location = new System.Drawing.Point(285, 104);
            this.comboBoxEspecialidade.Name = "comboBoxEspecialidade";
            this.comboBoxEspecialidade.Size = new System.Drawing.Size(303, 21);
            this.comboBoxEspecialidade.Sorted = true;
            this.comboBoxEspecialidade.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Especialidade:";
            // 
            // btregistar
            // 
            this.btregistar.Location = new System.Drawing.Point(304, 170);
            this.btregistar.Name = "btregistar";
            this.btregistar.Size = new System.Drawing.Size(75, 42);
            this.btregistar.TabIndex = 8;
            this.btregistar.Text = "Registar";
            this.btregistar.UseVisualStyleBackColor = true;
            this.btregistar.Click += new System.EventHandler(this.btregistar_Click);
            // 
            // btguardarAlteracoes
            // 
            this.btguardarAlteracoes.Location = new System.Drawing.Point(399, 170);
            this.btguardarAlteracoes.Name = "btguardarAlteracoes";
            this.btguardarAlteracoes.Size = new System.Drawing.Size(76, 42);
            this.btguardarAlteracoes.TabIndex = 9;
            this.btguardarAlteracoes.Text = "Guardar Alterações";
            this.btguardarAlteracoes.UseVisualStyleBackColor = true;
            this.btguardarAlteracoes.Click += new System.EventHandler(this.btguardarAlteracoes_Click);
            // 
            // btremover
            // 
            this.btremover.Location = new System.Drawing.Point(497, 170);
            this.btremover.Name = "btremover";
            this.btremover.Size = new System.Drawing.Size(75, 42);
            this.btremover.TabIndex = 10;
            this.btremover.Text = "Remover";
            this.btremover.UseVisualStyleBackColor = true;
            this.btremover.Click += new System.EventHandler(this.btremover_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Funcionários:";
            // 
            // GestaoFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 224);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btremover);
            this.Controls.Add(this.btguardarAlteracoes);
            this.Controls.Add(this.btregistar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEspecialidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.listBoxFuncionarios);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestaoFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Funcionários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestaoFuncionarios_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBoxEspecialidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btregistar;
        private System.Windows.Forms.Button btguardarAlteracoes;
        private System.Windows.Forms.Button btremover;
        private System.Windows.Forms.Label label3;
    }
}