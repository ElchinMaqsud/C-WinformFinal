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
    public partial class OrderDetailss : Form
    {
        private readonly FitnessEntities fitness;
        private readonly Packet selectedPackage;
        private readonly FService selectedService;
        private readonly Order order;
        private readonly int price;
        public OrderDetailss(FitnessEntities fitness1, Order order1, Packet package1, FService service1,int price1)
        {
            InitializeComponent();
            fitness = fitness1;
            order = order1;
            selectedPackage = package1;
            selectedService = service1;
            price = price1;

        }

        private void OrderDetailss_Load(object sender, EventArgs e)
        {
            OrderDetail orderDetail = new OrderDetail();
            cmbEmployee.Items.Add(order.Employee);
            cmbCustomer.Items.Add(order.Customer);
            cmbEmployee.SelectedIndex = 0;
            cmbCustomer.SelectedIndex = 0;
            dtOrderDate.Value = order.OrderDate.Value;
            txtPrice.Text = price.ToString();

            if (selectedPackage != null)
            {

                cmbPackages.Items.Add(selectedPackage);
                cmbPackages.SelectedIndex = 0;
                orderDetail.PacketId = selectedPackage.Id;
            }

           if(selectedService != null)
            {
                 cmbServices.Items.Add(selectedService);
                cmbServices.SelectedIndex = 0;
                orderDetail.ServiceId = selectedService.Id;
            }
           

          
           
            orderDetail.OrderId = order.Id;
            fitness.OrderDetails.Add(orderDetail);
            fitness.SaveChanges();
            MessageBox.Show("Order accepted");
            
        }
    }
}
