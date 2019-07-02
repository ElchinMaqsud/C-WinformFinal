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
    public partial class UpdatePackage : Form
    {
        private readonly FitnessEntities fitness;
        private readonly Packet package;
        private readonly DataGridView PackageData;
        public UpdatePackage(FitnessEntities fitness1, Packet package1, DataGridView data)
        {
            InitializeComponent();
            fitness = fitness1;
            package = package1;
            PackageData = data;
            foreach (var service in flpServices.Controls)
            {
                CheckBox checkBox = service as CheckBox;
                checkBox.Checked = false;
            }
        }

        private void UpdatePackage_Load(object sender, EventArgs e)
        {
            txtPackageName.Text = package.Name;
            txtPackagePrice.Text = package.Price.ToString();
            txtPackageDays.Text = package.ActiveDays;
            txtPackageHours.Text = package.ActiveHours;
            foreach (var service in fitness.FServices)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Tag = $"{service.Id}";
                checkBox.Text = service.Name;
                flpServices.Controls.Add(checkBox);
            }
            List<PacketService> packetService = fitness.PacketServices.Where(ser => ser.PacketId == package.Id).ToList();
            foreach (var service in flpServices.Controls)
            {
                CheckBox checkBox = service as CheckBox;
                foreach (var item in packetService)
                {
                    if (item.ServiceId == Convert.ToInt32(checkBox.Tag))
                    {
                        checkBox.Checked = true;
                    }
                }
            }
        }

        private void BtnAddPackage_Click(object sender, EventArgs e)
        {
             package.Name = txtPackageName.Text;
            package.Price = Convert.ToInt32(txtPackagePrice.Text);
            package.ActiveDays = txtPackageDays.Text;
            package.ActiveHours = txtPackageHours.Text;
        }

        private void BtnUpdatePackage_Click(object sender, EventArgs e)
        {
            //package.Name = txtPackageName.Text;
            //package.Price = Convert.ToInt32(txtPackagePrice.Text);
            //package.ActiveDays = txtPackageDays.Text;
            //package.ActiveHours = txtPackageHours.Text;
            //foreach (var selectedService in flpServices.Controls)
            //{
            //    CheckBox checkBox = selectedService as CheckBox;

            //    PacketServices packetToService = new PacketServices();
            //    if (checkBox.Checked == true)
            //    {
            //        packetToService.ServiceId = Convert.ToInt32(checkBox.Tag);
            //        packetToService.PacketId = package.Id;

            //    }
            //    fitness.PacketServices.Add(packetToService);

            //}
          
            //MessageBox.Show(" Package successfully Updated");
            //fitness.SaveChanges();
            //PackageData.DataSource = fitness.PacketServices.ToList();
        }
    }
}
