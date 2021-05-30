﻿
namespace GestaoCamaraMunicipal
{
    partial class GestaoProjetos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoProjetos));
            this.listBoxProjetos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxParecer = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.btRemover = new System.Windows.Forms.Button();
            this.btGuardarAlterações = new System.Windows.Forms.Button();
            this.btRegistarDocumentos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDocumento = new System.Windows.Forms.DateTimePicker();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxProcesso = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerProjeto = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btRemoverProjetos = new System.Windows.Forms.Button();
            this.btGuardarAlteracoesProjetos = new System.Windows.Forms.Button();
            this.btRegistarProjeto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTiposProjeto = new System.Windows.Forms.ComboBox();
            this.textBoxEstadoProjeto = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxDocumentos = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDePromotoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBoxProjetoAtribuido = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBoxFuncionario = new System.Windows.Forms.ComboBox();
            this.btnRemoverAtribuicao = new System.Windows.Forms.Button();
            this.btnRegistarAtribuicao = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerAtribuicao = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxProjetos
            // 
            this.listBoxProjetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxProjetos.FormattingEnabled = true;
            this.listBoxProjetos.Location = new System.Drawing.Point(3, 16);
            this.listBoxProjetos.Name = "listBoxProjetos";
            this.listBoxProjetos.Size = new System.Drawing.Size(261, 172);
            this.listBoxProjetos.TabIndex = 3;
            this.listBoxProjetos.SelectedIndexChanged += new System.EventHandler(this.listBoxProjetos_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxProjetos);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 191);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projetos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxParecer);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBoxTipoDocumento);
            this.groupBox2.Controls.Add(this.btRemover);
            this.groupBox2.Controls.Add(this.btGuardarAlterações);
            this.groupBox2.Controls.Add(this.btRegistarDocumentos);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePickerDocumento);
            this.groupBox2.Controls.Add(this.textBoxTitulo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(285, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 245);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Documento";
            // 
            // comboBoxParecer
            // 
            this.comboBoxParecer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParecer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxParecer.FormattingEnabled = true;
            this.comboBoxParecer.Location = new System.Drawing.Point(6, 151);
            this.comboBoxParecer.Name = "comboBoxParecer";
            this.comboBoxParecer.Size = new System.Drawing.Size(251, 21);
            this.comboBoxParecer.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Parecer:";
            // 
            // comboBoxTipoDocumento
            // 
            this.comboBoxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxTipoDocumento.FormattingEnabled = true;
            this.comboBoxTipoDocumento.Location = new System.Drawing.Point(6, 72);
            this.comboBoxTipoDocumento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTipoDocumento.Name = "comboBoxTipoDocumento";
            this.comboBoxTipoDocumento.Size = new System.Drawing.Size(251, 21);
            this.comboBoxTipoDocumento.TabIndex = 9;
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(182, 197);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 42);
            this.btRemover.TabIndex = 8;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            // 
            // btGuardarAlterações
            // 
            this.btGuardarAlterações.Location = new System.Drawing.Point(94, 197);
            this.btGuardarAlterações.Name = "btGuardarAlterações";
            this.btGuardarAlterações.Size = new System.Drawing.Size(75, 42);
            this.btGuardarAlterações.TabIndex = 7;
            this.btGuardarAlterações.Text = "Guardar Alterações";
            this.btGuardarAlterações.UseVisualStyleBackColor = true;
            // 
            // btRegistarDocumentos
            // 
            this.btRegistarDocumentos.Location = new System.Drawing.Point(6, 197);
            this.btRegistarDocumentos.Name = "btRegistarDocumentos";
            this.btRegistarDocumentos.Size = new System.Drawing.Size(75, 42);
            this.btRegistarDocumentos.TabIndex = 6;
            this.btRegistarDocumentos.Text = "Registar";
            this.btRegistarDocumentos.UseVisualStyleBackColor = true;
            this.btRegistarDocumentos.Click += new System.EventHandler(this.btRegistarDocumentos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de Documento:";
            // 
            // dateTimePickerDocumento
            // 
            this.dateTimePickerDocumento.Location = new System.Drawing.Point(6, 112);
            this.dateTimePickerDocumento.MinDate = new System.DateTime(2021, 5, 10, 0, 0, 0, 0);
            this.dateTimePickerDocumento.Name = "dateTimePickerDocumento";
            this.dateTimePickerDocumento.Size = new System.Drawing.Size(251, 20);
            this.dateTimePickerDocumento.TabIndex = 3;
            this.dateTimePickerDocumento.Value = new System.DateTime(2021, 5, 10, 17, 40, 15, 0);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(6, 33);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(251, 20);
            this.textBoxTitulo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Entrega:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado do Projeto:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxProcesso);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dateTimePickerProjeto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btRemoverProjetos);
            this.groupBox3.Controls.Add(this.btGuardarAlteracoesProjetos);
            this.groupBox3.Controls.Add(this.btRegistarProjeto);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBoxTiposProjeto);
            this.groupBox3.Controls.Add(this.textBoxEstadoProjeto);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 245);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Projeto";
            // 
            // comboBoxProcesso
            // 
            this.comboBoxProcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProcesso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxProcesso.FormattingEnabled = true;
            this.comboBoxProcesso.Location = new System.Drawing.Point(9, 151);
            this.comboBoxProcesso.Name = "comboBoxProcesso";
            this.comboBoxProcesso.Size = new System.Drawing.Size(251, 21);
            this.comboBoxProcesso.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Processo:";
            // 
            // dateTimePickerProjeto
            // 
            this.dateTimePickerProjeto.Location = new System.Drawing.Point(9, 112);
            this.dateTimePickerProjeto.MinDate = new System.DateTime(2021, 5, 10, 0, 0, 0, 0);
            this.dateTimePickerProjeto.Name = "dateTimePickerProjeto";
            this.dateTimePickerProjeto.Size = new System.Drawing.Size(251, 20);
            this.dateTimePickerProjeto.TabIndex = 15;
            this.dateTimePickerProjeto.Value = new System.DateTime(2021, 5, 10, 17, 40, 35, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data de Aprovação:";
            // 
            // btRemoverProjetos
            // 
            this.btRemoverProjetos.Location = new System.Drawing.Point(185, 197);
            this.btRemoverProjetos.Name = "btRemoverProjetos";
            this.btRemoverProjetos.Size = new System.Drawing.Size(75, 42);
            this.btRemoverProjetos.TabIndex = 13;
            this.btRemoverProjetos.Text = "Remover";
            this.btRemoverProjetos.UseVisualStyleBackColor = true;
            this.btRemoverProjetos.Click += new System.EventHandler(this.btRemoverProjetos_Click);
            // 
            // btGuardarAlteracoesProjetos
            // 
            this.btGuardarAlteracoesProjetos.Location = new System.Drawing.Point(97, 197);
            this.btGuardarAlteracoesProjetos.Name = "btGuardarAlteracoesProjetos";
            this.btGuardarAlteracoesProjetos.Size = new System.Drawing.Size(75, 42);
            this.btGuardarAlteracoesProjetos.TabIndex = 12;
            this.btGuardarAlteracoesProjetos.Text = "Guardar Alterações";
            this.btGuardarAlteracoesProjetos.UseVisualStyleBackColor = true;
            this.btGuardarAlteracoesProjetos.Click += new System.EventHandler(this.btGuardarAlteracoesProjetos_Click);
            // 
            // btRegistarProjeto
            // 
            this.btRegistarProjeto.Location = new System.Drawing.Point(9, 197);
            this.btRegistarProjeto.Name = "btRegistarProjeto";
            this.btRegistarProjeto.Size = new System.Drawing.Size(75, 42);
            this.btRegistarProjeto.TabIndex = 11;
            this.btRegistarProjeto.Text = "Registar";
            this.btRegistarProjeto.UseVisualStyleBackColor = true;
            this.btRegistarProjeto.Click += new System.EventHandler(this.btRegistarProjeto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de Projeto:";
            // 
            // comboBoxTiposProjeto
            // 
            this.comboBoxTiposProjeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTiposProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxTiposProjeto.FormattingEnabled = true;
            this.comboBoxTiposProjeto.Location = new System.Drawing.Point(9, 72);
            this.comboBoxTiposProjeto.Name = "comboBoxTiposProjeto";
            this.comboBoxTiposProjeto.Size = new System.Drawing.Size(251, 21);
            this.comboBoxTiposProjeto.TabIndex = 9;
            // 
            // textBoxEstadoProjeto
            // 
            this.textBoxEstadoProjeto.Location = new System.Drawing.Point(9, 33);
            this.textBoxEstadoProjeto.Name = "textBoxEstadoProjeto";
            this.textBoxEstadoProjeto.Size = new System.Drawing.Size(251, 20);
            this.textBoxEstadoProjeto.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxDocumentos);
            this.groupBox4.Location = new System.Drawing.Point(284, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 190);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Documentos";
            // 
            // listBoxDocumentos
            // 
            this.listBoxDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDocumentos.FormattingEnabled = true;
            this.listBoxDocumentos.Location = new System.Drawing.Point(3, 16);
            this.listBoxDocumentos.Name = "listBoxDocumentos";
            this.listBoxDocumentos.Size = new System.Drawing.Size(260, 171);
            this.listBoxDocumentos.TabIndex = 0;
            this.listBoxDocumentos.SelectedIndexChanged += new System.EventHandler(this.listBoxDocumentos_SelectedIndexChanged);
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
            this.menuStrip1.Size = new System.Drawing.Size(833, 24);
            this.menuStrip1.TabIndex = 10;
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
            this.gestãoDePromotoresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left)));
            this.gestãoDePromotoresToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.gestãoDePromotoresToolStripMenuItem.Text = "Voltar ao Menu";
            this.gestãoDePromotoresToolStripMenuItem.Click += new System.EventHandler(this.gestãoDePromotoresToolStripMenuItem_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBoxProjetoAtribuido);
            this.groupBox5.Location = new System.Drawing.Point(556, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(266, 190);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Funcionários atribuidos ao Projetos";
            // 
            // listBoxProjetoAtribuido
            // 
            this.listBoxProjetoAtribuido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxProjetoAtribuido.FormattingEnabled = true;
            this.listBoxProjetoAtribuido.Location = new System.Drawing.Point(3, 16);
            this.listBoxProjetoAtribuido.Name = "listBoxProjetoAtribuido";
            this.listBoxProjetoAtribuido.Size = new System.Drawing.Size(260, 171);
            this.listBoxProjetoAtribuido.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBoxFuncionario);
            this.groupBox6.Controls.Add(this.btnRemoverAtribuicao);
            this.groupBox6.Controls.Add(this.btnRegistarAtribuicao);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.dateTimePickerAtribuicao);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Location = new System.Drawing.Point(558, 230);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(262, 245);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Atribuição de Funcionários ao Projeto";
            // 
            // comboBoxFuncionario
            // 
            this.comboBoxFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxFuncionario.FormattingEnabled = true;
            this.comboBoxFuncionario.Location = new System.Drawing.Point(9, 31);
            this.comboBoxFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxFuncionario.Name = "comboBoxFuncionario";
            this.comboBoxFuncionario.Size = new System.Drawing.Size(251, 21);
            this.comboBoxFuncionario.TabIndex = 9;
            // 
            // btnRemoverAtribuicao
            // 
            this.btnRemoverAtribuicao.Location = new System.Drawing.Point(146, 197);
            this.btnRemoverAtribuicao.Name = "btnRemoverAtribuicao";
            this.btnRemoverAtribuicao.Size = new System.Drawing.Size(75, 42);
            this.btnRemoverAtribuicao.TabIndex = 8;
            this.btnRemoverAtribuicao.Text = "Remover";
            this.btnRemoverAtribuicao.UseVisualStyleBackColor = true;
            this.btnRemoverAtribuicao.Click += new System.EventHandler(this.btnRemoverAtribuicao_Click);
            // 
            // btnRegistarAtribuicao
            // 
            this.btnRegistarAtribuicao.Location = new System.Drawing.Point(49, 197);
            this.btnRegistarAtribuicao.Name = "btnRegistarAtribuicao";
            this.btnRegistarAtribuicao.Size = new System.Drawing.Size(75, 42);
            this.btnRegistarAtribuicao.TabIndex = 6;
            this.btnRegistarAtribuicao.Text = "Registar";
            this.btnRegistarAtribuicao.UseVisualStyleBackColor = true;
            this.btnRegistarAtribuicao.Click += new System.EventHandler(this.btnRegistarAtribuicao_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Funcionário:";
            // 
            // dateTimePickerAtribuicao
            // 
            this.dateTimePickerAtribuicao.Location = new System.Drawing.Point(9, 71);
            this.dateTimePickerAtribuicao.MinDate = new System.DateTime(2021, 5, 10, 0, 0, 0, 0);
            this.dateTimePickerAtribuicao.Name = "dateTimePickerAtribuicao";
            this.dateTimePickerAtribuicao.Size = new System.Drawing.Size(251, 20);
            this.dateTimePickerAtribuicao.TabIndex = 3;
            this.dateTimePickerAtribuicao.Value = new System.DateTime(2021, 5, 10, 17, 40, 15, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Data de Atribuição:";
            // 
            // GestaoProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 484);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GestaoProjetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DPM - Gestão de Projetos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestaoProjetos_FormClosing);
            this.Load += new System.EventHandler(this.GestaoProjetos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxProjetos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btGuardarAlterações;
        private System.Windows.Forms.Button btRegistarDocumentos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDocumento;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxEstadoProjeto;
        private System.Windows.Forms.Button btRemoverProjetos;
        private System.Windows.Forms.Button btGuardarAlteracoesProjetos;
        private System.Windows.Forms.Button btRegistarProjeto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTiposProjeto;
        private System.Windows.Forms.DateTimePicker dateTimePickerProjeto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxDocumentos;
        private System.Windows.Forms.ComboBox comboBoxProcesso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem gestãoDePromotoresToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxTipoDocumento;
        private System.Windows.Forms.ComboBox comboBoxParecer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBoxProjetoAtribuido;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBoxFuncionario;
        private System.Windows.Forms.Button btnRemoverAtribuicao;
        private System.Windows.Forms.Button btnRegistarAtribuicao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerAtribuicao;
        private System.Windows.Forms.Label label11;
    }
}