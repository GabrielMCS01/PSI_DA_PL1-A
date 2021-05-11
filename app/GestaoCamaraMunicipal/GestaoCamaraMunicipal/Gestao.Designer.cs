
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.listBoxDocumentos = new System.Windows.Forms.ListBox();
            this.btnAdicionarDocumento = new System.Windows.Forms.Button();
            this.btnRemoverDocumento = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(508, 28);
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
            this.gestãoDePromotoresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gestãoDePromotoresToolStripMenuItem.Text = "Voltar ao Menu";
            this.gestãoDePromotoresToolStripMenuItem.Click += new System.EventHandler(this.gestãoDePromotoresToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoverDocumento);
            this.groupBox1.Controls.Add(this.btnAdicionarDocumento);
            this.groupBox1.Controls.Add(this.listBoxDocumentos);
            this.groupBox1.Controls.Add(this.textBoxDocumento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 377);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documentos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo do Documento:";
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(250, 176);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(225, 22);
            this.textBoxDocumento.TabIndex = 1;
            // 
            // listBoxDocumentos
            // 
            this.listBoxDocumentos.FormattingEnabled = true;
            this.listBoxDocumentos.ItemHeight = 16;
            this.listBoxDocumentos.Location = new System.Drawing.Point(10, 33);
            this.listBoxDocumentos.Name = "listBoxDocumentos";
            this.listBoxDocumentos.Size = new System.Drawing.Size(229, 324);
            this.listBoxDocumentos.TabIndex = 2;
            // 
            // btnAdicionarDocumento
            // 
            this.btnAdicionarDocumento.Location = new System.Drawing.Point(264, 219);
            this.btnAdicionarDocumento.Name = "btnAdicionarDocumento";
            this.btnAdicionarDocumento.Size = new System.Drawing.Size(91, 34);
            this.btnAdicionarDocumento.TabIndex = 3;
            this.btnAdicionarDocumento.Text = "Adicionar";
            this.btnAdicionarDocumento.UseVisualStyleBackColor = true;
            this.btnAdicionarDocumento.Click += new System.EventHandler(this.btnAdicionarDocumento_Click);
            // 
            // btnRemoverDocumento
            // 
            this.btnRemoverDocumento.Location = new System.Drawing.Point(374, 219);
            this.btnRemoverDocumento.Name = "btnRemoverDocumento";
            this.btnRemoverDocumento.Size = new System.Drawing.Size(91, 34);
            this.btnRemoverDocumento.TabIndex = 4;
            this.btnRemoverDocumento.Text = "Remover";
            this.btnRemoverDocumento.UseVisualStyleBackColor = true;
            this.btnRemoverDocumento.Click += new System.EventHandler(this.btnRemoverDocumento_Click);
            // 
            // Gestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gestao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestao";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gestao_FormClosing);
            this.Load += new System.EventHandler(this.Gestao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem gestãoDePromotoresToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoverDocumento;
        private System.Windows.Forms.Button btnAdicionarDocumento;
        private System.Windows.Forms.ListBox listBoxDocumentos;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.Label label1;
    }
}