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
    public partial class UpdateEmployee : Form
    {
        private readonly FitnessEntities fitness;
        private readonly Employee employee;
        private readonly DataGridView data;
        public UpdateEmployee(FitnessEntities fitness1, Employee employee1,DataGridView data1)
        {
            InitializeComponent();
            fitness = fitness1;
            employee = employee1;
            data = data1;
        }

        private  void UpdateEmployee_Load(object sender, EventArgs e)
        {
            txtUpdateName.Text = employee.Name;
            txtUpdateSurname.Text = employee.Surname;
            txtUpdateUserName.Text = employee.Username;
            cmbRole.DataSource = fitness.Roles.ToList();
            cmbRole.SelectedItem = employee.Role.Name;
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            employee.Name = txtUpdateName.Text;
            employee.Surname = txtUpdateSurname.Text;
            employee.Username = txtUpdateUserName.Text;
            employee.Role = cmbRole.SelectedItem as Role;
          await  fitness.SaveChangesAsync();
            MessageBox.Show("Success");
            data.DataSource = fitness.Employees.ToList();
            this.Close();

        }
    }
}
