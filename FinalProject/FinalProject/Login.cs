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
    public partial class Login : Form
    {
        private readonly FitnessEntities fitness = new FitnessEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                Employee employee = fitness.Employees.Where(f => f.Username == username).FirstOrDefault();

                if (employee == null)
                {
                    MessageBox.Show("Invalid username or password");
                    return;
                }
                if (!checkedHashCode(employee.Password, password))
                {
                    MessageBox.Show("Invalid username or password");
                    return;
                }
                if (employee.HasVerify == false)
                {
                    VerifyPass verifyPass = new VerifyPass(employee, fitness);
                    verifyPass.Show();
                    return;
                }
                if (employee.RoleId == 1)
                {
                    Admin admin = new Admin(fitness,employee);
                    admin.Show();
                }
                else
                {
                    EmployeeForm employeeForm = new EmployeeForm(fitness, employee);
                    employeeForm.Show();
                }
                if (employee == null)
                {
                    MessageBox.Show("Invalid username or password");
                    return;
                }
                if (!checkedHashCode(employee.Password, password))
                {
                    MessageBox.Show("Invalid username or password");
                    return;
                }
                if (employee.HasVerify == false)
                {
                    VerifyPass verifyPass = new VerifyPass(employee, fitness);
                    verifyPass.Show();
                    return;
                }

            }
            else
            {
                MessageBox.Show("Username or password invalid");
            }
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

}
    
}
