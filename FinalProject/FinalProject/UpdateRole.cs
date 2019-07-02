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
    public partial class UpdateRole : Form
    {
        private readonly FitnessEntities fitness;
        private readonly DataGridView data;
        private readonly Role role;
        public UpdateRole(FitnessEntities fitness1,DataGridView data1, Role role1)
        {
            InitializeComponent();
            fitness = fitness1;
            data = data1;
            role = role1;
        }

        private void UpdateRole_Load(object sender, EventArgs e)
        {
            txtRoleName.Text = role.Name;
        }

        private async void BtnUpdateRole_Click(object sender, EventArgs e)
        {
            role.Name = txtRoleName.Text;
            await fitness.SaveChangesAsync();
            MessageBox.Show("Selected Role succesfully Updated");
            data.DataSource = fitness.Roles.ToList();
            this.Close();
        }
    }
}
