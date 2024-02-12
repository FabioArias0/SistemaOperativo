using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOperativo.Pantallas
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lblProductName.Text = string.Format("Product name: {0}", Application.ProductName);
            lblProductVersion.Text = string.Format("Product version: {0}", Application.ProductVersion);
            lblCopyright.Text = "Copyright ©  2024 by Carlos Arias";
        }
    }
}
