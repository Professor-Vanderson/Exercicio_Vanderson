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
    public partial class frmValidaIdade : Form
    {
        public frmValidaIdade()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txtIdade.Text);
            if (idade > 18)
            {
                MessageBox.Show("Idade maior que 18.");
            }
            else
            {
                MessageBox.Show("Idade menor que 18.");
            }
        }
    }
}
