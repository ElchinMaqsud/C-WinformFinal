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
    public partial class DeleteService : Form
    {
        private readonly FitnessEntities fitness;
        private readonly DataGridView ServiceData;
        public DeleteService(FitnessEntities fitness1, DataGridView data)
        {
            InitializeComponent();
            fitness = fitness1;
            ServiceData = data;
        }

        private void DeleteService_Load(object sender, EventArgs e)
        {
            cmbDeleteService.Items.AddRange(fitness.FServices.ToArray());
        }

        private void BtnDeleteService_Click(object sender, EventArgs e)
        {
            FService selectedService = cmbDeleteService.SelectedItem as FService;
            FService service = fitness.FServices.FirstOrDefault(ser => ser.Id == selectedService.Id);
            fitness.FServices.Remove(service);
            fitness.SaveChanges();
            MessageBox.Show("Service successfully Removed");
            ServiceData.DataSource = fitness.FServices.Select(delegate (FService service1)
            {

                return new
                {
                    Id = service1.Id,
                    name = service1.Name,
                    price = service1.Price
                    
                };
            }).ToList();
            this.Close();
        }
    }
}
