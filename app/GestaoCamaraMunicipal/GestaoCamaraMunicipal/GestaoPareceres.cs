using System;
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
    public partial class GestaoPareceres : Form
    {
        Form1 formprincipal = new Form1();
        public GestaoPareceres()
        {
            InitializeComponent();
        }

        private void gestãoDePromotoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formprincipal.Show();
            this.Hide();
        }

        private void GestaoPareceres_FormClosing(object sender, FormClosingEventArgs e)
        {
            formprincipal.Sair(e);
        }
    }
}
