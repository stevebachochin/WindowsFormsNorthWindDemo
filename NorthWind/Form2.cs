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
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Form1.selectedCutomer.customerID.ToString() + " --- " + Form1.selectedCutomer.companyName.ToString());
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 newMDIChild = new Form1();
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = ActiveForm;
            // Display the new form.  
            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
        }
    }
}
