using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vectores
{
    public partial class frmCheques : Form
    {
        public frmCheques()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            UTILS.numerosficheros.testUnidades();
            int num = Int32.Parse(this.txtNum.Text);
            this.txtResultado.Text = UTILS.numerosficheros.getDecenas(num);
        }
    }
}
