using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atitividade
{
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double media = (Convert.ToDouble(txtNota1.Text)+Convert.ToDouble(txtNota2.Text)
                + Convert.ToDouble(txtNota3.Text)+Convert.ToDouble(txtNota4.Text))/4;
            MessageBox.Show(Convert.ToString(media));
        }
    }
}
