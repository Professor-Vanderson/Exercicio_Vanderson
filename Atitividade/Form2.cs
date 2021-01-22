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
    public partial class frmParImpar : Form
    {
        public frmParImpar()
        {
            InitializeComponent();
        }

        private void btnVerficar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNum.Text);
            if (numero % 2 == 0 )
            {
                MessageBox.Show("O número é Par.");
            }
            else
            {
                MessageBox.Show("O número é Impar.");
            }
        }
    }
}
