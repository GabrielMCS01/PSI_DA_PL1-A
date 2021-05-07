
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.dateTimePickerDocumento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxEstadoProjeto = new System.Windows.Forms.TextBox();
            this.btRegistarDocumentos = new System.Windows.Forms.Button();
            this.btGuardarAlterações = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.comboBoxFuncionario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btRemoverProjetos = new System.Windows.Forms.Button();
            this.btGuardarAlteracoesProjetos = new System.Windows.Forms.Button();
            this.btRegistarProjeto = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxDocumentos = new System.Windows.Forms.ListBox();
            this.dateTimePickerProjeto = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxDependente = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxParecer = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxProjetos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 191);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projetos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btRemover);
            this.groupBox2.Controls.Add(this.btGuardarAlterações);
            this.groupBox2.Controls.Add(this.btRegistarDocumentos);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePickerDocumento);
            this.groupBox2.Controls.Add(this.textBoxTitulo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(285, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 245);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Documento";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Entrega:";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(6, 33);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(251, 20);
            this.textBoxTitulo.TabIndex = 2;
            // 
            // dateTimePickerDocumento
            // 
            this.dateTimePickerDocumento.Location = new System.Drawing.Point(6, 72);
            this.dateTimePickerDocumento.Name = "dateTimePickerDocumento";
            this.dateTimePickerDocumento.Size = new System.Drawing.Size(251, 20);
            this.dateTimePickerDocumento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de Documento:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 20);
            this.textBox2.TabIndex = 5;
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
            this.groupBox3.Controls.Add(this.comboBoxParecer);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.checkBoxDependente);
            this.groupBox3.Controls.Add(this.dateTimePickerProjeto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btRemoverProjetos);
            this.groupBox3.Controls.Add(this.btGuardarAlteracoesProjetos);
            this.groupBox3.Controls.Add(this.btRegistarProjeto);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBoxFuncionario);
            this.groupBox3.Controls.Add(this.textBoxEstadoProjeto);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 245);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Projeto";
            // 
            // textBoxEstadoProjeto
            // 
            this.textBoxEstadoProjeto.Location = new System.Drawing.Point(9, 33);
            this.textBoxEstadoProjeto.Name = "textBoxEstadoProjeto";
            this.textBoxEstadoProjeto.Size = new System.Drawing.Size(251, 20);
            this.textBoxEstadoProjeto.TabIndex = 8;
            // 
            // btRegistarDocumentos
            // 
            this.btRegistarDocumentos.Location = new System.Drawing.Point(6, 197);
            this.btRegistarDocumentos.Name = "btRegistarDocumentos";
            this.btRegistarDocumentos.Size = new System.Drawing.Size(75, 42);
            this.btRegistarDocumentos.TabIndex = 6;
            this.btRegistarDocumentos.Text = "Registar";
            this.btRegistarDocumentos.UseVisualStyleBackColor = true;
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
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(182, 197);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 42);
            this.btRemover.TabIndex = 8;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            // 
            // comboBoxFuncionario
            // 
            this.comboBoxFuncionario.FormattingEnabled = true;
            this.comboBoxFuncionario.Location = new System.Drawing.Point(9, 72);
            this.comboBoxFuncionario.Name = "comboBoxFuncionario";
            this.comboBoxFuncionario.Size = new System.Drawing.Size(251, 21);
            this.comboBoxFuncionario.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Funcionário:";
            // 
            // btRemoverProjetos
            // 
            this.btRemoverProjetos.Location = new System.Drawing.Point(185, 197);
            this.btRemoverProjetos.Name = "btRemoverProjetos";
            this.btRemoverProjetos.Size = new System.Drawing.Size(75, 42);
            this.btRemoverProjetos.TabIndex = 13;
            this.btRemoverProjetos.Text = "Remover";
            this.btRemoverProjetos.UseVisualStyleBackColor = true;
            // 
            // btGuardarAlteracoesProjetos
            // 
            this.btGuardarAlteracoesProjetos.Location = new System.Drawing.Point(97, 197);
            this.btGuardarAlteracoesProjetos.Name = "btGuardarAlteracoesProjetos";
            this.btGuardarAlteracoesProjetos.Size = new System.Drawing.Size(75, 42);
            this.btGuardarAlteracoesProjetos.TabIndex = 12;
            this.btGuardarAlteracoesProjetos.Text = "Guardar Alterações";
            this.btGuardarAlteracoesProjetos.UseVisualStyleBackColor = true;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxDocumentos);
            this.groupBox4.Location = new System.Drawing.Point(284, 14);
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
            // 
            // dateTimePickerProjeto
            // 
            this.dateTimePickerProjeto.Location = new System.Drawing.Point(9, 112);
            this.dateTimePickerProjeto.MinDate = new System.DateTime(2021, 5, 7, 0, 0, 0, 0);
            this.dateTimePickerProjeto.Name = "dateTimePickerProjeto";
            this.dateTimePickerProjeto.Size = new System.Drawing.Size(251, 20);
            this.dateTimePickerProjeto.TabIndex = 15;
            this.dateTimePickerProjeto.Value = new System.DateTime(2021, 5, 7, 10, 33, 35, 0);
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
            // checkBoxDependente
            // 
            this.checkBoxDependente.AutoSize = true;
            this.checkBoxDependente.Location = new System.Drawing.Point(9, 178);
            this.checkBoxDependente.Name = "checkBoxDependente";
            this.checkBoxDependente.Size = new System.Drawing.Size(162, 17);
            this.checkBoxDependente.TabIndex = 16;
            this.checkBoxDependente.Text = "Dependente de outro projeto";
            this.checkBoxDependente.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Parecer:";
            // 
            // comboBoxParecer
            // 
            this.comboBoxParecer.FormattingEnabled = true;
            this.comboBoxParecer.Location = new System.Drawing.Point(9, 151);
            this.comboBoxParecer.Name = "comboBoxParecer";
            this.comboBoxParecer.Size = new System.Drawing.Size(251, 21);
            this.comboBoxParecer.TabIndex = 18;
            // 
            // GestaoProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 466);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestaoProjetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Projetos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestaoProjetos_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxProjetos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btGuardarAlterações;
        private System.Windows.Forms.Button btRegistarDocumentos;
        private System.Windows.Forms.TextBox textBox2;
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
        private System.Windows.Forms.ComboBox comboBoxFuncionario;
        private System.Windows.Forms.DateTimePicker dateTimePickerProjeto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxDocumentos;
        private System.Windows.Forms.ComboBox comboBoxParecer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxDependente;
    }
}