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
    public partial class DeleteRole : Form
    {
        private readonly FitnessEntities fitness;
        private readonly DataGridView Roledata;
        public DeleteRole(FitnessEntities fitness1, DataGridView data)
        {
            InitializeComponent();
            fitness = fitness1;
            Roledata = data;
        }

        private void DeleteRole_Load(object sender, EventArgs e)
        {
            cmbDeleteRole.Items.AddRange(fitness.Roles.ToArray());
        }

        private void BtnDeleteRole_Click(object sender, EventArgs e)
        {
            Role selectedRole = cmbDeleteRole.SelectedItem as Role;
            Role role = fitness.Roles.FirstOrDefault(r => r.Id == selectedRole.Id);
            fitness.Roles.Remove(role);
            fitness.SaveChanges();
            MessageBox.Show("Role successfully Removed");
            Roledata.DataSource = fitness.Roles.Select(delegate (Role role1)
            {

                return new
                {
                   Name=role1.Name
                };
            }).ToList();
            this.Close();
        }
    }
}
