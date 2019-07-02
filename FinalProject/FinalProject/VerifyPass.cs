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
    public partial class VerifyPass : Form
    {
        private readonly FitnessEntities fitness;
        private Employee employeeA;
        private Employee employee;

        public VerifyPass(Employee employee, FitnessEntities fitness2)
        {
            InitializeComponent();
            employeeA = employee;
            fitness = fitness2;
        }

        

        private async void BtnUpdatePass_Click(object sender, EventArgs e)
        {
            if (txtCurrentPassword.Text != string.Empty)
            {
                if (employeeA.Password == GetHash(txtCurrentPassword.Text))
                {
                    if (txtPassword.Text != string.Empty && txtConfirmPass.Text != string.Empty)
                    {
                        if (txtPassword.Text == txtConfirmPass.Text)
                        {
                            employeeA.Password = GetHash(txtPassword.Text);
                            MessageBox.Show("Success");
                            employeeA.HasVerify = true;
                            await fitness.SaveChangesAsync();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Please insert valid true current Password");
                }
            }

        }
    }
}
