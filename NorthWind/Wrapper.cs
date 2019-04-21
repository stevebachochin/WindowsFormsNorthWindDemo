using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind
{
    public partial class FormWrapper : Form
    {
        public FormWrapper()
        {
            InitializeComponent();
            Form1 frm1 = new Form1();

            frm1.Dock = DockStyle.Fill;
            frm1.Show();
            frm1.MdiParent = this;
        }
    }
}
