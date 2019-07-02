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
    public partial class UpdateService : Form
    {
        private readonly FitnessEntities fitness;
        private readonly FService service;
        private readonly DataGridView ServiceData;
        public UpdateService(FitnessEntities fitness1, FService service1, DataGridView data)
        {
            InitializeComponent();
            fitness = fitness1;
            service = service1;
            ServiceData = data;
        }

        private void UpdateService_Load(object sender, EventArgs e)
        {
            txtName.Text = service.Name;
            txtPrice.Text = service.Price.ToString();
        }

        private void BtnUpdateService_Click(object sender, EventArgs e)
        {
            service.Name = txtName.Text;
            service.Price = Convert.ToInt32(txtPrice.Text);
            MessageBox.Show("Success");
            ServiceData.DataSource = fitness.FServices.ToList();
            this.Close();
        }
    }
}
