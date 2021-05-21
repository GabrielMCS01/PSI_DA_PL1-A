
namespace GestaoCamaraMunicipal
{
    partial class GestaoProcessos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoProcessos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDePromotoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxProcessos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerInicioProcesso = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.comboBoxPromotor = new System.Windows.Forms.ComboBox();
            this.lblPromotor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEstadoProcesso = new System.Windows.Forms.TextBox();
            this.btnCriarProcesso = new System.Windows.Forms.Button();
            this.btnRemoverProcesso = new System.Windows.Forms.Button();
            this.btnAtualizarProcesso = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(831, 28);
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
            this.gestãoDePromotoresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left)));
            this.gestãoDePromotoresToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.gestãoDePromotoresToolStripMenuItem.Text = "Voltar ao Menu";
            this.gestãoDePromotoresToolStripMenuItem.Click += new System.EventHandler(this.gestãoDePromotoresToolStripMenuItem_Click);
            // 
            // listBoxProcessos
            // 
            this.listBoxProcessos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxProcessos.FormattingEnabled = true;
            this.listBoxProcessos.ItemHeight = 16;
            this.listBoxProcessos.Location = new System.Drawing.Point(4, 19);
            this.listBoxProcessos.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxProcessos.Name = "listBoxProcessos";
            this.listBoxProcessos.Size = new System.Drawing.Size(344, 372);
            this.listBoxProcessos.TabIndex = 3;
            this.listBoxProcessos.SelectedIndexChanged += new System.EventHandler(this.listBoxProcessos_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxProcessos);
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(352, 395);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processos";
            // 
            // dateTimePickerInicioProcesso
            // 
            this.dateTimePickerInicioProcesso.Location = new System.Drawing.Point(53, 89);
            this.dateTimePickerInicioProcesso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerInicioProcesso.Name = "dateTimePickerInicioProcesso";
            this.dateTimePickerInicioProcesso.Size = new System.Drawing.Size(332, 22);
            this.dateTimePickerInicioProcesso.TabIndex = 14;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(51, 69);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(98, 17);
            this.lblData.TabIndex = 15;
            this.lblData.Text = "Data de Início:";
            // 
            // comboBoxPromotor
            // 
            this.comboBoxPromotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPromotor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxPromotor.FormattingEnabled = true;
            this.comboBoxPromotor.Location = new System.Drawing.Point(53, 160);
            this.comboBoxPromotor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPromotor.Name = "comboBoxPromotor";
            this.comboBoxPromotor.Size = new System.Drawing.Size(332, 24);
            this.comboBoxPromotor.TabIndex = 16;
            // 
            // lblPromotor
            // 
            this.lblPromotor.AutoSize = true;
            this.lblPromotor.Location = new System.Drawing.Point(51, 140);
            this.lblPromotor.Name = "lblPromotor";
            this.lblPromotor.Size = new System.Drawing.Size(70, 17);
            this.lblPromotor.TabIndex = 17;
            this.lblPromotor.Text = "Promotor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Estado do Processo:";
            // 
            // textBoxEstadoProcesso
            // 
            this.textBoxEstadoProcesso.Location = new System.Drawing.Point(53, 229);
            this.textBoxEstadoProcesso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEstadoProcesso.Name = "textBoxEstadoProcesso";
            this.textBoxEstadoProcesso.Size = new System.Drawing.Size(331, 22);
            this.textBoxEstadoProcesso.TabIndex = 19;
            // 
            // btnCriarProcesso
            // 
            this.btnCriarProcesso.Location = new System.Drawing.Point(24, 319);
            this.btnCriarProcesso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCriarProcesso.Name = "btnCriarProcesso";
            this.btnCriarProcesso.Size = new System.Drawing.Size(119, 43);
            this.btnCriarProcesso.TabIndex = 20;
            this.btnCriarProcesso.Text = "Criar Processo";
            this.btnCriarProcesso.UseVisualStyleBackColor = true;
            this.btnCriarProcesso.Click += new System.EventHandler(this.btnCriarProcesso_Click);
            // 
            // btnRemoverProcesso
            // 
            this.btnRemoverProcesso.Location = new System.Drawing.Point(160, 319);
            this.btnRemoverProcesso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoverProcesso.Name = "btnRemoverProcesso";
            this.btnRemoverProcesso.Size = new System.Drawing.Size(119, 43);
            this.btnRemoverProcesso.TabIndex = 21;
            this.btnRemoverProcesso.Text = "Remover Processo";
            this.btnRemoverProcesso.UseVisualStyleBackColor = true;
            this.btnRemoverProcesso.Click += new System.EventHandler(this.btnRemoverProcesso_Click);
            // 
            // btnAtualizarProcesso
            // 
            this.btnAtualizarProcesso.Location = new System.Drawing.Point(298, 319);
            this.btnAtualizarProcesso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtualizarProcesso.Name = "btnAtualizarProcesso";
            this.btnAtualizarProcesso.Size = new System.Drawing.Size(119, 43);
            this.btnAtualizarProcesso.TabIndex = 22;
            this.btnAtualizarProcesso.Text = "Atualizar Processo";
            this.btnAtualizarProcesso.UseVisualStyleBackColor = true;
            this.btnAtualizarProcesso.Click += new System.EventHandler(this.btnAtualizarProcesso_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAtualizarProcesso);
            this.groupBox2.Controls.Add(this.lblData);
            this.groupBox2.Controls.Add(this.btnRemoverProcesso);
            this.groupBox2.Controls.Add(this.dateTimePickerInicioProcesso);
            this.groupBox2.Controls.Add(this.btnCriarProcesso);
            this.groupBox2.Controls.Add(this.comboBoxPromotor);
            this.groupBox2.Controls.Add(this.textBoxEstadoProcesso);
            this.groupBox2.Controls.Add(this.lblPromotor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(373, 42);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(445, 395);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestão de Processos";
            // 
            // GestaoProcessos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GestaoProcessos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DPM - Gestão de Processos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestaoProcessos_FormClosing);
            this.Load += new System.EventHandler(this.GestaoProcessos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem gestãoDePromotoresToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxProcessos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicioProcesso;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox comboBoxPromotor;
        private System.Windows.Forms.Label lblPromotor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEstadoProcesso;
        private System.Windows.Forms.Button btnCriarProcesso;
        private System.Windows.Forms.Button btnRemoverProcesso;
        private System.Windows.Forms.Button btnAtualizarProcesso;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}