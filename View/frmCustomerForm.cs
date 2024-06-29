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

public partial class frmCustomerForm : Form
{
    CustomerService _customerService;
    frmCustomer _parentForm;
    public frmCustomerForm(frmCustomer parentForm)
    {
        InitializeComponent();
        _customerService = new CustomerService();
        _parentForm = parentForm;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        // Gather customer details from the form controls
        string name = txtName.Text;
        string lastName = txtLastName.Text;

        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastName))
        {
            MessageBox.Show("Please enter both Name and Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Create a new customer object
        Customer newCustomer = new Customer
        {
            Name = name,
            LastName = lastName
        };
        this.Close();

        try
        {
            // Call the Crear method to save the new customer
            _customerService.Crear(newCustomer);
            MessageBox.Show("Customer saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optionally, clear the form fields after saving
            txtName.Clear();
            txtLastName.Clear();

            // Refresh the data grid in the parent form
            _parentForm.CargarCustomers();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error saving customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
