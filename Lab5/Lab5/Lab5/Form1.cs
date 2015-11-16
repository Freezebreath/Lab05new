using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class frmLab05 : Form
    {
        public frmLab05()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtAge.Text) > 16)
            {
                MessageBox.Show("Alcohol in Germany");
            }
        }
    }
}
