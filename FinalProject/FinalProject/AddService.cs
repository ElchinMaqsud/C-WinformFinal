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
    public partial class AddService : Form
    {
        private readonly FitnessEntities fitness;
        private readonly DataGridView ServiceData;
        public AddService(FitnessEntities fitness1, DataGridView data)
        {
            InitializeComponent();
            fitness = fitness1;
            ServiceData = data;
        }

        private  void BtnAddService_Click(object sender, EventArgs e)
        {
            FService service = new FService();
            string name = txtName.Text;
            int price = Convert.ToInt32(txtPrice.Text);
            service.Name = name;
            service.Price = price;
            fitness.FServices.Add(service);
             fitness.SaveChanges();
            MessageBox.Show(" New Service succesfully Added");
            ServiceData.DataSource = fitness.FServices.ToList();
            this.Close();
        }
    }
}
