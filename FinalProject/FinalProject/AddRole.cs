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
    public partial class AddRole : Form
    {
        private readonly FitnessEntities fitness;
        private readonly DataGridView RoleData;
        public AddRole(FitnessEntities fitness1, DataGridView data)
        {
            InitializeComponent();
            fitness = fitness1;
            RoleData = data;
        }

        private void BtnAddRole_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            string name = txtRoleName.Text.Trim();

            role.Name = name;
            fitness.Roles.Add(role);
            fitness.SaveChangesAsync();
            MessageBox.Show("Success");
            RoleData.DataSource = fitness.Roles.ToList();
            this.Close();
        }
    }
}
