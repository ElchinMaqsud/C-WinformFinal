using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalProject.Hash;

namespace FinalProject
{
    public partial class AddEmployee : Form
    {
        private readonly FitnessEntities fitness;
        private readonly DataGridView data;
        public AddEmployee(FitnessEntities fitness1, DataGridView data1)
        {
            InitializeComponent();
            fitness = fitness1;
            data = data1;
        }

        private async void BtnEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            string Name = txtName.Text.Trim();
            string Surname = txtSurname.Text.Trim();
            string Username = txtSurname.Text.Trim();
            string Password = GetHash(txtPassword.Text);
            Role role = cmbRole.SelectedItem as Role;

            employee.Name = Name;
            employee.Surname = Surname;
            employee.Username = Username;
            employee.Password = Password;
            employee.Role = role;
            employee.HasVerify = false;
            fitness.Employees.Add(employee);
            
            
           await fitness.SaveChangesAsync();
            MessageBox.Show("Success");
            data.DataSource = fitness.Employees.ToList();
            this.Close();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            List<Role> role = fitness.Roles.Where(f => f.Id > 1).ToList();
            cmbRole.Items.AddRange(role.ToArray());
        }
    }
}
