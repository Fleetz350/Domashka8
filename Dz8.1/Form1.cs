using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbRes.Text = "0";

        }
        private void numeric1_ValueChanged(object sender, EventArgs e)
        {
            tbRes.Text = numeric1.Value.ToString();
        }
    }
}
