using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividadeds
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frmprodutos p = new Frmprodutos();
            p.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmclientes c = new frmclientes();
            c.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmcategorias n = new Frmcategorias();
            n.ShowDialog();
        }
    }
}
