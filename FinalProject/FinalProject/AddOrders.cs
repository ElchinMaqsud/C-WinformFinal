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
    public partial class AddOrders : Form
    {
        private readonly FitnessEntities fitness;
        private readonly Employee employee;
        private readonly Customer customer;
        public AddOrders(FitnessEntities fitness1,Employee employee1, Customer customer1)
        {
            InitializeComponent();
            fitness = fitness1;
            employee = employee1;
            customer = customer1;

        }

        private void AddOrders_Load(object sender, EventArgs e)
        {
            cmbEmployee.Items.Add(employee);
            cmbCustomer.Items.Add(customer);
            cmbEmployee.SelectedIndex = 0;
            cmbCustomer.SelectedIndex = 0;
            cmbPackages.Items.AddRange(fitness.Packets.ToArray());
            cmbServices.Items.AddRange(fitness.FServices.ToArray());



        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            Packet selectedPackage = cmbPackages.SelectedItem as Packet;
            FService selectedService = cmbServices.SelectedItem as FService;
            Order order = new Order();
            order.EmployeeId = employee.Id;
            order.CustomerId = customer.Id;
            order.OrderDate = dtOrderDate.Value;
            int price = Convert.ToInt32(txtPrice.Text);
            fitness.Orders.Add(order);
             await fitness.SaveChangesAsync();

            if(cmbPackages.SelectedIndex>=0 && cmbServices.SelectedIndex == -1)
            {
                cmbServices.Visible = false;
                selectedService = null;
            }
            if(cmbServices.SelectedIndex>=0 && cmbPackages.SelectedIndex == -1)
            {
                cmbPackages.Visible = false;
                selectedPackage = null;
            }
            
            this.Close();
            OrderDetailss orderDetails = new OrderDetailss(fitness, order, selectedPackage, selectedService,price);
            orderDetails.ShowDialog();
            
            

        }

        
    }
}
