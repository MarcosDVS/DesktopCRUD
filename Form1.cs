using TEST.Context;
using TEST.Entity;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace TEST
{
    public partial class Form1 : Form
    {
        public int? id;
        Customer customerRequest = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void Clean()
        {
            txtName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            id = null;
        }

        private void LoadData()
        {
            using (var ctx = new MyDbContext())
            {
                var customers = ctx.Customers.ToList();
                dgCustomer.DataSource = customers;
                // Enable auto-generate columns if not set in the designer
                dgCustomer.AutoGenerateColumns = true;
            }
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dgCustomer.Rows[dgCustomer.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        public void ButtonChange()
        {
            if(id!=null)
            {
                btnAdd.Text = "EDIT";
                btnAdd.BackColor = Color.DarkOrange;
            }
            else
            {
                btnAdd.Text = "ADD";
                btnAdd.BackColor = Color.DarkGreen;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var ctx = new MyDbContext())
            {
                if (txtName.Text != string.Empty && txtLastName.Text != string.Empty)
                {
                    if (id == null)
                        customerRequest = new Customer();
                    else
                        customerRequest = ctx.Customers.Find(id);

                    customerRequest.Name = txtName.Text;
                    customerRequest.LastName = txtLastName.Text;

                    if (id == null)
                        ctx.Customers.Add(customerRequest);
                    else
                        ctx.Entry(customerRequest).State = EntityState.Modified;

                    ctx.SaveChanges();
                    Clean();
                    LoadData();
                    ButtonChange();
                    customerRequest = null; // Reset the customerRequest after saving
                }
                else
                {
                    MessageBox.Show("No pueden haber campos vacíos");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgCustomer.SelectedRows.Count > 0)
            {
                id = GetId();
                if (id != null)
                {
                    using (var ctx = new MyDbContext())
                    {
                        var customer = ctx.Customers.SingleOrDefault(c => c.Id == id);
                        if (customer != null)
                        {
                            customerRequest = customer;
                            txtName.Text = customer.Name;
                            txtLastName.Text = customer.LastName;
                        }
                    }
                    ButtonChange();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para editar");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgCustomer.SelectedRows.Count > 0)
            {
                int? customerId = GetId();
                if (customerId != null)
                {
                    using (var ctx = new MyDbContext())
                    {
                        var customer = ctx.Customers.SingleOrDefault(c => c.Id == customerId);
                        if (customer != null)
                        {
                            ctx.Customers.Remove(customer);
                            ctx.SaveChanges();
                            Clean();
                            LoadData();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar");
            }
        }

        private void dgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

