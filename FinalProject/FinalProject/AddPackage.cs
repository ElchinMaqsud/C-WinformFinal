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
    public partial class AddPackage : Form
    {
        private readonly FitnessEntities fitness;
        private readonly DataGridView PackageData;
        public AddPackage(FitnessEntities fitness1, DataGridView data)
        {
            InitializeComponent();
            fitness = fitness1;
            PackageData = data;
        }

        private void AddPackage_Load(object sender, EventArgs e)
        {
            foreach (var service in fitness.FServices)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = service.Name;
                checkBox.Tag = $"{service.Id}";
                flpServices.Controls.Add(checkBox);
            }
           
        }

        private void BtnAddPackage_Click(object sender, EventArgs e)
        {
            Packet package = new Packet();
            package.Name = txtPackageName.Text;
            package.Price = Convert.ToInt32(txtPackagePrice.Text);
            package.ActiveDays = txtPackageDays.Text;
            package.ActiveHours = txtPackageHours.Text;
            fitness.Packets.Add(package);
            fitness.SaveChanges();

            foreach (var selectedService in flpServices.Controls)
            {
                CheckBox checkBox = selectedService as CheckBox;

                PacketService packetToService = new PacketService();
                if (checkBox.Checked == true)
                {
                    packetToService.ServiceId = Convert.ToInt32(checkBox.Tag);
                    packetToService.PacketId = package.Id;
                    
                }
                fitness.PacketServices.Add(packetToService);
              

            }
            MessageBox.Show("New Package successfully Added");
            fitness.SaveChanges();
            PackageData.DataSource = fitness.PacketServices.ToList();

        }
    }
}
