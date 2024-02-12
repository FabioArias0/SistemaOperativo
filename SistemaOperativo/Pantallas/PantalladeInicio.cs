using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOperativo
{
    public partial class PantalladeInicio : Form
    {
        

        public PantalladeInicio()
        {
            InitializeComponent();
          
        }

        private void internetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallas.WindowsInternetExplorer frm = new Pantallas.WindowsInternetExplorer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mediaPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallas.WindowsMediaPlayer frm2 = new Pantallas.WindowsMediaPlayer();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallas.WindowsNotepad frm3 = new Pantallas.WindowsNotepad();
            frm3.Show();
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallas.WindowsTaskManager frm4 = new Pantallas.WindowsTaskManager();
            frm4.MdiParent = this;
            frm4.Show();
        }

        private void recyckeBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallas.WindowsRecycleBin frm5 = new Pantallas.WindowsRecycleBin();
            frm5.MdiParent = this;
            frm5.Show();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {

        }

        private void turnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea apagar?", "Confirmar apagado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
