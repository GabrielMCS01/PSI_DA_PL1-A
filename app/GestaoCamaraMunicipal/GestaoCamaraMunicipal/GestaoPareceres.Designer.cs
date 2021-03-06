
namespace GestaoCamaraMunicipal
{
    partial class GestaoPareceres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoPareceres));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDePromotoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxProjeto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerProjeto = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnGuardarAlteracoes = new System.Windows.Forms.Button();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxFuncionario = new System.Windows.Forms.ComboBox();
            this.textBoxTextoParecer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxPareceres = new System.Windows.Forms.ListBox();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(388, 28);
            this.menuStrip1.TabIndex = 2;
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
            this.gestãoDePromotoresToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.gestãoDePromotoresToolStripMenuItem.Text = "Fechar";
            this.gestãoDePromotoresToolStripMenuItem.Click += new System.EventHandler(this.gestãoDePromotoresToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxProjeto);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dateTimePickerProjeto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnRemover);
            this.groupBox3.Controls.Add(this.btnGuardarAlteracoes);
            this.groupBox3.Controls.Add(this.btnRegistar);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBoxFuncionario);
            this.groupBox3.Controls.Add(this.textBoxTextoParecer);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(16, 272);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(356, 310);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parecer";
            // 
            // comboBoxProjeto
            // 
            this.comboBoxProjeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxProjeto.FormattingEnabled = true;
            this.comboBoxProjeto.Location = new System.Drawing.Point(8, 143);
            this.comboBoxProjeto.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxProjeto.Name = "comboBoxProjeto";
            this.comboBoxProjeto.Size = new System.Drawing.Size(333, 24);
            this.comboBoxProjeto.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Projeto";
            // 
            // dateTimePickerProjeto
            // 
            this.dateTimePickerProjeto.Location = new System.Drawing.Point(8, 89);
            this.dateTimePickerProjeto.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerProjeto.MinDate = new System.DateTime(2021, 5, 7, 0, 0, 0, 0);
            this.dateTimePickerProjeto.Name = "dateTimePickerProjeto";
            this.dateTimePickerProjeto.Size = new System.Drawing.Size(333, 22);
            this.dateTimePickerProjeto.TabIndex = 15;
            this.dateTimePickerProjeto.Value = new System.DateTime(2021, 5, 7, 10, 33, 35, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Funcionario:";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(243, 249);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(100, 52);
            this.btnRemover.TabIndex = 13;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btRemoverProjetos_Click);
            // 
            // btnGuardarAlteracoes
            // 
            this.btnGuardarAlteracoes.Location = new System.Drawing.Point(125, 249);
            this.btnGuardarAlteracoes.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarAlteracoes.Name = "btnGuardarAlteracoes";
            this.btnGuardarAlteracoes.Size = new System.Drawing.Size(100, 52);
            this.btnGuardarAlteracoes.TabIndex = 12;
            this.btnGuardarAlteracoes.Text = "Guardar Alterações";
            this.btnGuardarAlteracoes.UseVisualStyleBackColor = true;
            this.btnGuardarAlteracoes.Click += new System.EventHandler(this.btGuardarAlteracoesProjetos_Click);
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(8, 249);
            this.btnRegistar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(100, 52);
            this.btnRegistar.TabIndex = 11;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btRegistarProjeto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Parecer";
            // 
            // comboBoxFuncionario
            // 
            this.comboBoxFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxFuncionario.FormattingEnabled = true;
            this.comboBoxFuncionario.Location = new System.Drawing.Point(8, 203);
            this.comboBoxFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFuncionario.Name = "comboBoxFuncionario";
            this.comboBoxFuncionario.Size = new System.Drawing.Size(333, 24);
            this.comboBoxFuncionario.TabIndex = 9;
            // 
            // textBoxTextoParecer
            // 
            this.textBoxTextoParecer.Location = new System.Drawing.Point(8, 41);
            this.textBoxTextoParecer.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTextoParecer.Name = "textBoxTextoParecer";
            this.textBoxTextoParecer.Size = new System.Drawing.Size(333, 22);
            this.textBoxTextoParecer.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Texto Parecer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxPareceres);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(356, 235);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pareceres";
            // 
            // listBoxPareceres
            // 
            this.listBoxPareceres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPareceres.FormattingEnabled = true;
            this.listBoxPareceres.ItemHeight = 16;
            this.listBoxPareceres.Location = new System.Drawing.Point(4, 19);
            this.listBoxPareceres.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPareceres.Name = "listBoxPareceres";
            this.listBoxPareceres.Size = new System.Drawing.Size(348, 212);
            this.listBoxPareceres.TabIndex = 3;
            this.listBoxPareceres.SelectedIndexChanged += new System.EventHandler(this.listBoxPareceres_SelectedIndexChanged);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // GestaoPareceres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 591);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GestaoPareceres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DPM - Gestão de Pareceres";
            this.Load += new System.EventHandler(this.GestaoPareceres_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem gestãoDePromotoresToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxProjeto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerProjeto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnGuardarAlteracoes;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxFuncionario;
        private System.Windows.Forms.TextBox textBoxTextoParecer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxPareceres;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
    }
}