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
        public static Models.SelectedCustomer selectedCutomer = new Models.SelectedCustomer();

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
            selectedCutomer.customerID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            selectedCutomer.companyName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(selectedCutomer.customerID.ToString());
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
    }
}
