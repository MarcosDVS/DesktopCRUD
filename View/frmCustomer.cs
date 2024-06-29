using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEST.Entity;
using TEST.Service;

namespace TEST.View;

public partial class frmCustomer : Form
{
    public int? id;
    private CustomerService _customerService;
    public frmCustomer()
    {
        InitializeComponent();
        _customerService = new CustomerService();
    }
    private void frmCustomer_Load(object sender, EventArgs e)
    {
        CargarCustomers();
    }

    public void CargarCustomers()
    {
        var customers = _customerService.Consultar();
        dgCustomer.DataSource = customers;
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

    private void btnAdd_Click(object sender, EventArgs e)
    {
        frmCustomerForm CustomerForm = new(this);
        CustomerForm.ShowDialog();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {

    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgCustomer.SelectedRows.Count > 0)
        {
            int? customerId = GetId();

            try
            {
                _customerService.Eliminar(customerId);
                MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCustomers(); // Refresh the data grid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Please select a customer to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void dgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

}
