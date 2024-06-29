using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST.Context;
using TEST.Entity;

namespace TEST.Service;

public class CustomerService
{
    private readonly MyDbContext _context;

    public CustomerService()
    {
        _context = new MyDbContext();
    }

    // Consultar: Get all customers
    public List<Customer> Consultar()
    {
        return _context.Customers.ToList();
    }

    // Crear: Add a new customer
    public void Crear(Customer customer)
    {
        _context.Customers.Add(customer);
        _context.SaveChanges();
    }

    // Modificar: Update an existing customer
    public void Modificar(Customer customer)
    {
        var existingCustomer = _context.Customers.Find(customer.Id);
        if (existingCustomer != null)
        {
            existingCustomer.Name = customer.Name;
            existingCustomer.LastName = customer.LastName;
            _context.SaveChanges();
        }
        else
        {
            throw new Exception("Customer not found");
        }
    }

    // Eliminar: Delete a customer
    public void Eliminar(int? customerId)
    {
        var customer = _context.Customers.Find(customerId);
        if (customer != null)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
        else
        {
            throw new Exception("Customer not found");
        }
    }
}
