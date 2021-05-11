﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoCamaraMunicipal
{
    public partial class Gestao : Form
    {
        Form1 formprincipal = new Form1();
        private GestaoCamaraMunicipalContainer camaraMunicipal;
          
        public Gestao()
        {
            InitializeComponent();
        }
        private void Gestao_Load(object sender, EventArgs e)
        {
            camaraMunicipal = new GestaoCamaraMunicipalContainer();
            lerDados();
        }

        private void lerDados()
        {
            listBoxDocumentos.DataSource = camaraMunicipal.TipoDocumentoSet.ToList<TipoDocumento>();
        }

        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formprincipal.Show();
            this.Hide();
        }

        private void btnAdicionarDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDocumento.Text != "")
                {
                    camaraMunicipal.TipoDocumentoSet.Add(new TipoDocumento(textBoxDocumento.Text));
                    camaraMunicipal.SaveChanges();
                    lerDados();
                }
                else
                {
                    MessageBox.Show("Tem de Preencher todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoverDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxDocumentos.SelectedIndex != -1)
                {
                    TipoDocumento tipoDocumento = new TipoDocumento();
                    tipoDocumento = (TipoDocumento)listBoxDocumentos.SelectedItem;
                    camaraMunicipal.TipoDocumentoSet.Remove(tipoDocumento);
                    camaraMunicipal.SaveChanges();
                    lerDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Gestao_FormClosing(object sender, FormClosingEventArgs e)
        {
            formprincipal.Sair(e);
        }
    }
}
