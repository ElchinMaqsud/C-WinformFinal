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
    public partial class DeleteEmployee : Form
    {
        private readonly FitnessEntities fitness;
        private readonly DataGridView data;
        
        public DeleteEmployee(FitnessEntities fitness2,DataGridView data2)
        {
            InitializeComponent();
            fitness = fitness2;
            data = data2;
        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {
            cmbDeleteEmp.Items.AddRange(fitness.Employees.ToArray());
        }

        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            Employee selectedEmployee = cmbDeleteEmp.SelectedItem as Employee;
            Employee employee = fitness.Employees.FirstOrDefault(emp => emp.Id == selectedEmployee.Id);
            fitness.Employees.Remove(employee);
            fitness.SaveChanges();
            MessageBox.Show("Employee successfully Removed");
            data.DataSource = fitness.Employees.Select(delegate (Employee employe)
            {

                return new
                {
                    Id = employe.Id,
                    name = employe.Name,
                    surname = employe.Surname,
                    username = employe.Username,
                    EmpRole = employe.Role
                };
            }).ToList();
            this.Close();
        }
    }
}
