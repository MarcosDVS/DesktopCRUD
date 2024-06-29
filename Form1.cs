using TEST.Context;
using TEST.Entity;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TEST
{
    public partial class Form1 : Form
    {
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var ctx = new MyDbContext())
            {
                if (txtName.Text != string.Empty && txtLastName.Text != string.Empty)
                {
                    Customer customer = new Customer()
                    {
                        Name = txtName.Text,
                        LastName = txtLastName.Text

                    };
                    ctx.Customers.Add(customer);
                    ctx.SaveChanges();
                    Clean();
                    LoadData();
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
                using (var ctx = new MyDbContext())
                {
                    int customerId = Convert.ToInt32(dgCustomer.SelectedRows[0].Cells["Id"].Value);
                    var customer = ctx.Customers.SingleOrDefault(c => c.Id == customerId);
                    if (customer != null)
                    {
                        customer.Name = txtName.Text;
                        customer.LastName = txtLastName.Text;
                        ctx.SaveChanges();
                        Clean();
                        LoadData();
                    }
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
                using (var ctx = new MyDbContext())
                {
                    int customerId = Convert.ToInt32(dgCustomer.SelectedRows[0].Cells["Id"].Value);
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
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar");
            }
        }

        private void dgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgCustomer.Rows[e.RowIndex];
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
            }
        }
    }
}
