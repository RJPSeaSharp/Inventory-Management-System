using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMSv4
{
    public partial class Form1 : Form
    {
        CRUD crud;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            crud = new CRUD();
            dataGridView1.DataSource = crud.GetAll();
            btnSubmitNew.Enabled = false;
            btnUpdateItem.Enabled = false;
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtStockNumber.Clear();
            txtQuantity.Clear();
            txtDescription.Clear();
            txtUnitPrice.Clear();
            txtdept.Clear();
            btnSubmitNew.Enabled = true;
        }

        private void btnSubmitNew_Click(object sender, EventArgs e)
        {
            if (txtStockNumber.Text != null)
            {
                var newItem = new Inventory();
                newItem.Stock_Number = txtStockNumber.Text;
                newItem.Item_Name = txtName.Text;
                newItem.Quantity = int.Parse(txtQuantity.Text);
                newItem.Description = txtDescription.Text;
                newItem.Quantity = int.Parse(txtQuantity.Text);
                newItem.Unit_Price = decimal.Parse(txtUnitPrice.Text);
                newItem.Department = txtdept.Text;

            }
        }

        private void cmboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtdept_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectToUpdate_Click(object sender, EventArgs e)
        {
            var id = dataGridView1.CurrentRow.Cells[1].Value;
            var itemtoupdate = crud.FindStockNumber((int)id);
            txtStockNumber.Text = itemtoupdate.Stock_Number.ToString();
            txtName.Text = itemtoupdate.Item_Name.ToString();
            txtDescription.Text = itemtoupdate.Description.ToString();
            txtQuantity.Text = itemtoupdate.Quantity.ToString();
            txtUnitPrice.Text = itemtoupdate.Unit_Price.ToString();
            txtdept.Text = itemtoupdate.Department.ToString();
            btnUpdateItem.Enabled = true;
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtStockNumber.Text);
            var itemtoupdate = crud.FindStockNumber((int)id);
            itemtoupdate.Unit_Price = decimal.Parse(txtUnitPrice.Text);
            itemtoupdate.Quantity = int.Parse(txtQuantity.Text);
            itemtoupdate.Description = txtDescription.Text;
            itemtoupdate.Department = txtdept.Text;
            crud.UpdateItem(id, itemtoupdate);
            MessageBox.Show("Item Updated");
            Clear();
            btnUpdateItem.Enabled = false;
            dataGridView1.DataSource = crud.GetAll();
        }

        private void Clear()
        {
            txtStockNumber.Clear();
            txtQuantity.Clear();
            txtDescription.Clear();
            txtUnitPrice.Clear();
            txtName.Clear();
            txtdept.Clear();
        }

        private void btnRefreshRecord_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = crud.GetAll();
        }
    }
}
 