﻿
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
            this.btRemoverProjetos = new System.Windows.Forms.Button();
            this.btGuardarAlteracoesProjetos = new System.Windows.Forms.Button();
            this.btRegistarProjeto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxFuncionario = new System.Windows.Forms.ComboBox();
            this.textBoxTextoParecer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxPareceres = new System.Windows.Forms.ListBox();
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
            this.toolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(291, 24);
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
            this.gestãoDePromotoresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left)));
            this.gestãoDePromotoresToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.gestãoDePromotoresToolStripMenuItem.Text = "Voltar ao Menu";
            this.gestãoDePromotoresToolStripMenuItem.Click += new System.EventHandler(this.gestãoDePromotoresToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxProjeto);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dateTimePickerProjeto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btRemoverProjetos);
            this.groupBox3.Controls.Add(this.btGuardarAlteracoesProjetos);
            this.groupBox3.Controls.Add(this.btRegistarProjeto);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBoxFuncionario);
            this.groupBox3.Controls.Add(this.textBoxTextoParecer);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 252);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parecer";
            // 
            // comboBoxProjeto
            // 
            this.comboBoxProjeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxProjeto.FormattingEnabled = true;
            this.comboBoxProjeto.Location = new System.Drawing.Point(6, 116);
            this.comboBoxProjeto.Name = "comboBoxProjeto";
            this.comboBoxProjeto.Size = new System.Drawing.Size(251, 21);
            this.comboBoxProjeto.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Projeto";
            // 
            // dateTimePickerProjeto
            // 
            this.dateTimePickerProjeto.Location = new System.Drawing.Point(6, 72);
            this.dateTimePickerProjeto.MinDate = new System.DateTime(2021, 5, 7, 0, 0, 0, 0);
            this.dateTimePickerProjeto.Name = "dateTimePickerProjeto";
            this.dateTimePickerProjeto.Size = new System.Drawing.Size(251, 20);
            this.dateTimePickerProjeto.TabIndex = 15;
            this.dateTimePickerProjeto.Value = new System.DateTime(2021, 5, 7, 10, 33, 35, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Funcionario:";
            // 
            // btRemoverProjetos
            // 
            this.btRemoverProjetos.Location = new System.Drawing.Point(182, 202);
            this.btRemoverProjetos.Name = "btRemoverProjetos";
            this.btRemoverProjetos.Size = new System.Drawing.Size(75, 42);
            this.btRemoverProjetos.TabIndex = 13;
            this.btRemoverProjetos.Text = "Remover";
            this.btRemoverProjetos.UseVisualStyleBackColor = true;
            this.btRemoverProjetos.Click += new System.EventHandler(this.btRemoverProjetos_Click);
            // 
            // btGuardarAlteracoesProjetos
            // 
            this.btGuardarAlteracoesProjetos.Location = new System.Drawing.Point(94, 202);
            this.btGuardarAlteracoesProjetos.Name = "btGuardarAlteracoesProjetos";
            this.btGuardarAlteracoesProjetos.Size = new System.Drawing.Size(75, 42);
            this.btGuardarAlteracoesProjetos.TabIndex = 12;
            this.btGuardarAlteracoesProjetos.Text = "Guardar Alterações";
            this.btGuardarAlteracoesProjetos.UseVisualStyleBackColor = true;
            this.btGuardarAlteracoesProjetos.Click += new System.EventHandler(this.btGuardarAlteracoesProjetos_Click);
            // 
            // btRegistarProjeto
            // 
            this.btRegistarProjeto.Location = new System.Drawing.Point(6, 202);
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
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Parecer";
            // 
            // comboBoxFuncionario
            // 
            this.comboBoxFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxFuncionario.FormattingEnabled = true;
            this.comboBoxFuncionario.Location = new System.Drawing.Point(6, 165);
            this.comboBoxFuncionario.Name = "comboBoxFuncionario";
            this.comboBoxFuncionario.Size = new System.Drawing.Size(251, 21);
            this.comboBoxFuncionario.TabIndex = 9;
            // 
            // textBoxTextoParecer
            // 
            this.textBoxTextoParecer.Location = new System.Drawing.Point(6, 33);
            this.textBoxTextoParecer.Name = "textBoxTextoParecer";
            this.textBoxTextoParecer.Size = new System.Drawing.Size(251, 20);
            this.textBoxTextoParecer.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Texto Parecer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxPareceres);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 191);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pareceres";
            // 
            // listBoxPareceres
            // 
            this.listBoxPareceres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPareceres.FormattingEnabled = true;
            this.listBoxPareceres.Location = new System.Drawing.Point(3, 16);
            this.listBoxPareceres.Name = "listBoxPareceres";
            this.listBoxPareceres.Size = new System.Drawing.Size(261, 172);
            this.listBoxPareceres.TabIndex = 3;
            this.listBoxPareceres.SelectedIndexChanged += new System.EventHandler(this.listBoxPareceres_SelectedIndexChanged);
            // 
            // GestaoPareceres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestaoPareceres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Pareceres";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestaoPareceres_FormClosing);
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
        private System.Windows.Forms.Button btRemoverProjetos;
        private System.Windows.Forms.Button btGuardarAlteracoesProjetos;
        private System.Windows.Forms.Button btRegistarProjeto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxFuncionario;
        private System.Windows.Forms.TextBox textBoxTextoParecer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxPareceres;
    }
}