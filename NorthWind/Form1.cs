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
    public partial class Form1 : Form
    {
        NorthwindEntities we;
        //public static Models.SelectedCustomer selectedCutomer = new Models.SelectedCustomer();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

             we = new NorthwindEntities();

             dataGridView1.DataSource = we.Customers.ToList();
            //string columnName = dataGridView1.CurrentCell.OwningColumn.Name;
            dataGridView1.Columns[3].Visible = false;
    
        }

        private double createAPIGravity(int temperature, double obvGravity)
        {
            //double obvGravity = gravity; //38.7;
            int tChange = temperature-60;
            double hyc;
            double rho;
            double rhot;
            double alfa;
            double vcf;
            double rh60 = 0;
            double api;

            hyc = 1 - (0.00001278 * tChange) - (0.0000000062 * tChange * tChange);
            rho = 141.5 * 999.012 / (131.5 + obvGravity);
            rhot = hyc * rho;

            for (int i = 0; i < 9; i++)
            {
                alfa = i == 0 ? 341.0957 / rhot / rhot : 341.0957 / rh60 / rh60;
                vcf = Math.Exp(-alfa * tChange - 0.8 * alfa * alfa * tChange * tChange);
                rh60 = rhot / vcf;
            }

            api = Math.Round(141.5 * 999.012 / rh60 - 131.5, 2);

            return api;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer();

            newCustomer.City = "Jacksonville";

            //.ShipAddress = lastOrder.ShipAddress;
            using (NorthwindEntities db = new NorthwindEntities())
            { 
                Customer cust = db.Customers.Where((x) => x.Address == "123456789").FirstOrDefault();
                MessageBox.Show(cust.Address.ToString() + " - ");

            }
            //db.Orders.InsertOnSubmit(ord);


        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Classes.Common.selectedCutomer.customerID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Classes.Common.selectedCutomer.companyName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Classes.Common.selectedCutomer.customerID.ToString());
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void buttonNewPage_Click(object sender, EventArgs e)
        {

            this.Close();
            Form2 newMDIChild = new Form2();
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = ActiveForm;
            // Display the new form.  
            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
        }

        private void buttonGetAPIGravity_Click(object sender, EventArgs e)
        {
            int temperature;
            double gravity;

            temperature = Int32.Parse(txtTemperature.Text);
            gravity = double.Parse(txtGravity.Text);

            txtAPIGavity.Text = createAPIGravity(temperature, gravity).ToString();
        }
    }
}
