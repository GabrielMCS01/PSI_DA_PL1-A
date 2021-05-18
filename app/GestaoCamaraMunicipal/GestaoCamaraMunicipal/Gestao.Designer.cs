
namespace GestaoCamaraMunicipal
{
    partial class Gestao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestao));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDePromotoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxDependente = new System.Windows.Forms.CheckBox();
            this.textBoxDesignacao = new System.Windows.Forms.TextBox();
            this.numericUpDownDiasAprovacao = new System.Windows.Forms.NumericUpDown();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBoxEspecialistas = new System.Windows.Forms.ListBox();
            this.buttonAddFuncionario = new System.Windows.Forms.Button();
            this.buttonRemoverFuncionario = new System.Windows.Forms.Button();
            this.comboBoxFuncionario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxTiposdeProjeto = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoverDocumento = new System.Windows.Forms.Button();
            this.btnAdicionarDocumento = new System.Windows.Forms.Button();
            this.listBoxDocumentos = new System.Windows.Forms.ListBox();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiasAprovacao)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(805, 28);
            this.menuStrip1.TabIndex = 3;
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
            this.gestãoDePromotoresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left)));
            this.gestãoDePromotoresToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.gestãoDePromotoresToolStripMenuItem.Text = "Voltar ao Menu";
            this.gestãoDePromotoresToolStripMenuItem.Click += new System.EventHandler(this.gestãoDePromotoresToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gestão de Tipos de Projeto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl2);
            this.groupBox2.Controls.Add(this.listBoxTiposdeProjeto);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(791, 388);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipos de Projetos";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(530, 33);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(248, 340);
            this.tabControl2.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.checkBoxDependente);
            this.tabPage3.Controls.Add(this.textBoxDesignacao);
            this.tabPage3.Controls.Add(this.numericUpDownDiasAprovacao);
            this.tabPage3.Controls.Add(this.buttonAdicionar);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.buttonRemover);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(240, 311);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Edição";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Designação:";
            // 
            // checkBoxDependente
            // 
            this.checkBoxDependente.AutoSize = true;
            this.checkBoxDependente.Location = new System.Drawing.Point(9, 122);
            this.checkBoxDependente.Name = "checkBoxDependente";
            this.checkBoxDependente.Size = new System.Drawing.Size(213, 21);
            this.checkBoxDependente.TabIndex = 7;
            this.checkBoxDependente.Text = "Dependente de outro projeto";
            this.checkBoxDependente.UseVisualStyleBackColor = true;
            // 
            // textBoxDesignacao
            // 
            this.textBoxDesignacao.Location = new System.Drawing.Point(9, 23);
            this.textBoxDesignacao.Name = "textBoxDesignacao";
            this.textBoxDesignacao.Size = new System.Drawing.Size(225, 22);
            this.textBoxDesignacao.TabIndex = 1;
            // 
            // numericUpDownDiasAprovacao
            // 
            this.numericUpDownDiasAprovacao.Location = new System.Drawing.Point(62, 83);
            this.numericUpDownDiasAprovacao.Maximum = new decimal(new int[] {
            3700,
            0,
            0,
            0});
            this.numericUpDownDiasAprovacao.Name = "numericUpDownDiasAprovacao";
            this.numericUpDownDiasAprovacao.Size = new System.Drawing.Size(87, 22);
            this.numericUpDownDiasAprovacao.TabIndex = 6;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(14, 149);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(100, 52);
            this.buttonAdicionar.TabIndex = 3;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número de dias de aprovação:";
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(124, 149);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(100, 52);
            this.buttonRemover.TabIndex = 4;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listBoxEspecialistas);
            this.tabPage4.Controls.Add(this.buttonAddFuncionario);
            this.tabPage4.Controls.Add(this.buttonRemoverFuncionario);
            this.tabPage4.Controls.Add(this.comboBoxFuncionario);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(240, 311);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Especialistas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBoxEspecialistas
            // 
            this.listBoxEspecialistas.FormattingEnabled = true;
            this.listBoxEspecialistas.ItemHeight = 16;
            this.listBoxEspecialistas.Location = new System.Drawing.Point(9, 6);
            this.listBoxEspecialistas.Name = "listBoxEspecialistas";
            this.listBoxEspecialistas.Size = new System.Drawing.Size(224, 180);
            this.listBoxEspecialistas.TabIndex = 7;
            // 
            // buttonAddFuncionario
            // 
            this.buttonAddFuncionario.Location = new System.Drawing.Point(14, 253);
            this.buttonAddFuncionario.Name = "buttonAddFuncionario";
            this.buttonAddFuncionario.Size = new System.Drawing.Size(100, 52);
            this.buttonAddFuncionario.TabIndex = 5;
            this.buttonAddFuncionario.Text = "Adicionar";
            this.buttonAddFuncionario.UseVisualStyleBackColor = true;
            this.buttonAddFuncionario.Click += new System.EventHandler(this.buttonAddFuncionario_Click);
            // 
            // buttonRemoverFuncionario
            // 
            this.buttonRemoverFuncionario.Location = new System.Drawing.Point(124, 253);
            this.buttonRemoverFuncionario.Name = "buttonRemoverFuncionario";
            this.buttonRemoverFuncionario.Size = new System.Drawing.Size(100, 52);
            this.buttonRemoverFuncionario.TabIndex = 6;
            this.buttonRemoverFuncionario.Text = "Remover";
            this.buttonRemoverFuncionario.UseVisualStyleBackColor = true;
            this.buttonRemoverFuncionario.Click += new System.EventHandler(this.buttonRemoverFuncionario_Click);
            // 
            // comboBoxFuncionario
            // 
            this.comboBoxFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxFuncionario.FormattingEnabled = true;
            this.comboBoxFuncionario.Location = new System.Drawing.Point(9, 219);
            this.comboBoxFuncionario.Name = "comboBoxFuncionario";
            this.comboBoxFuncionario.Size = new System.Drawing.Size(224, 24);
            this.comboBoxFuncionario.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Funcionário:";
            // 
            // listBoxTiposdeProjeto
            // 
            this.listBoxTiposdeProjeto.FormattingEnabled = true;
            this.listBoxTiposdeProjeto.ItemHeight = 16;
            this.listBoxTiposdeProjeto.Location = new System.Drawing.Point(10, 33);
            this.listBoxTiposdeProjeto.Name = "listBoxTiposdeProjeto";
            this.listBoxTiposdeProjeto.Size = new System.Drawing.Size(514, 340);
            this.listBoxTiposdeProjeto.TabIndex = 2;
            this.listBoxTiposdeProjeto.SelectedIndexChanged += new System.EventHandler(this.listBoxTiposdeProjeto_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestão de Documentos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoverDocumento);
            this.groupBox1.Controls.Add(this.btnAdicionarDocumento);
            this.groupBox1.Controls.Add(this.listBoxDocumentos);
            this.groupBox1.Controls.Add(this.textBoxDocumento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 388);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documentos";
            // 
            // btnRemoverDocumento
            // 
            this.btnRemoverDocumento.Location = new System.Drawing.Point(665, 178);
            this.btnRemoverDocumento.Name = "btnRemoverDocumento";
            this.btnRemoverDocumento.Size = new System.Drawing.Size(100, 52);
            this.btnRemoverDocumento.TabIndex = 4;
            this.btnRemoverDocumento.Text = "Remover";
            this.btnRemoverDocumento.UseVisualStyleBackColor = true;
            this.btnRemoverDocumento.Click += new System.EventHandler(this.btnRemoverDocumento_Click);
            // 
            // btnAdicionarDocumento
            // 
            this.btnAdicionarDocumento.Location = new System.Drawing.Point(555, 178);
            this.btnAdicionarDocumento.Name = "btnAdicionarDocumento";
            this.btnAdicionarDocumento.Size = new System.Drawing.Size(100, 52);
            this.btnAdicionarDocumento.TabIndex = 3;
            this.btnAdicionarDocumento.Text = "Adicionar";
            this.btnAdicionarDocumento.UseVisualStyleBackColor = true;
            this.btnAdicionarDocumento.Click += new System.EventHandler(this.btnAdicionarDocumento_Click);
            // 
            // listBoxDocumentos
            // 
            this.listBoxDocumentos.FormattingEnabled = true;
            this.listBoxDocumentos.ItemHeight = 16;
            this.listBoxDocumentos.Location = new System.Drawing.Point(10, 33);
            this.listBoxDocumentos.Name = "listBoxDocumentos";
            this.listBoxDocumentos.Size = new System.Drawing.Size(515, 340);
            this.listBoxDocumentos.TabIndex = 2;
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(545, 53);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(225, 22);
            this.textBoxDocumento.TabIndex = 1;
            this.textBoxDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDocumento_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo do Documento:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 423);
            this.tabControl1.TabIndex = 5;
            // 
            // Gestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 451);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gestao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administração";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gestao_FormClosing);
            this.Load += new System.EventHandler(this.Gestao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiasAprovacao)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem gestãoDePromotoresToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxDependente;
        private System.Windows.Forms.TextBox textBoxDesignacao;
        private System.Windows.Forms.NumericUpDown numericUpDownDiasAprovacao;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox listBoxEspecialistas;
        private System.Windows.Forms.Button buttonAddFuncionario;
        private System.Windows.Forms.Button buttonRemoverFuncionario;
        private System.Windows.Forms.ComboBox comboBoxFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxTiposdeProjeto;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoverDocumento;
        private System.Windows.Forms.Button btnAdicionarDocumento;
        private System.Windows.Forms.ListBox listBoxDocumentos;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}