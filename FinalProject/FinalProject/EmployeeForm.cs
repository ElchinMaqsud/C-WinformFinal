using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class EmployeeForm : Form
    {
        private readonly FitnessEntities fitness;
        private Employee employeeA;
        public EmployeeForm(FitnessEntities fitnessA,Employee employee)
        {
            InitializeComponent();
            fitness = fitnessA;
            employeeA = employee;
            
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            txtWelcome.Text = $"Welcome {employeeA.Name}";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Name = txtCustomerName.Text;
            customer.Surname = txtCustomerSurname.Text;
            customer.AccessCard = Convert.ToInt32(txtAccesCard.Text);
            fitness.Customers.Add(customer);
            fitness.SaveChanges();
            MessageBox.Show("New Customer Successfully Added");
            txtAccesCard.Text = "";
            txtCustomerName.Text = "";
            txtCustomerSurname.Text = "";

            AddOrders addOrder = new AddOrders(fitness,employeeA, customer);
            addOrder.Show();
            
        }
    }
}
