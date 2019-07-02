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
    public partial class Admin : Form
    {
        private readonly FitnessEntities fitness1;
        private Employee employe1;
        private Employee Employee;
        private Role role1;
        private Role role;
        private  FService service1;
        private  FService service2;
        private Packet package;
        private Packet package2;
        public Admin(FitnessEntities fitness2, Employee employee2)
        {
            InitializeComponent();
            fitness1 = fitness2;
            employe1 = employee2;
            
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            dgwEmployees.DataSource = fitness1.Employees.Select(delegate (Employee employe)
               {

                   return new
                   {
                       Id= employe.Id,
                       name = employe.Name,
                       surname = employe.Surname,
                       username= employe.Username,
                       EmpRole = employe.Role
               };
               }).ToList();
            dgwEmployees.Columns[0].Visible = false;


            dgwCustomers.DataSource = fitness1.Customers.Select(delegate (Customer customer)
            {
                return new
                {   
                    name = customer.Name,
                    surname = customer.Surname,
                    AccesCard = customer.AccessCard
                };
            }).ToList();

         

            dgwRoles.DataSource = fitness1.Roles.Select(delegate (Role role)
            {
                return new
                {
                   Id= role.Id,
                    Name=role.Name
                };
            }).ToList();
            dgwRoles.Columns[0].Visible = false;

            dgwServices.DataSource = fitness1.FServices.Select(delegate (FService service)
            {

                return new
                {
                    Id = service.Id,
                    Service = service.Name,
                    Price = service.Price
                    
                };
            }).ToList();
            dgwServices.Columns[0].Visible = false;
            fitness1.SaveChanges();

            dgwPackage.DataSource = fitness1.Packets.Select(delegate (Packet package)
            {

                return new
                {
                    Id = package.Id,
                   Name= package.Name,
                   Price = package.Price,
                   ActiveDays= package.ActiveDays,
                   ActiveHours= package.ActiveHours


                };
            }).ToList();
            dgwPackage.Columns[0].Visible = false;

            dgwOrderDetails.DataSource = fitness1.OrderDetails.Select(delegate (OrderDetail orderDetail)
            {

                return new
                {
                    Id = orderDetail.Id,
                    packetName = orderDetail.Packet,
                    employeName = orderDetail.Order.Employee,
                    customerName = orderDetail.Order.Customer,
                    OrderDate = orderDetail.Order.OrderDate
                    
                   

                    


                };
            }).ToList();
            dgwOrderDetails.Columns[0].Visible = false;

            fitness1.SaveChanges();

        }
        
         

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee(fitness1, dgwEmployees);
            addEmployee.Show();
        }

        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            DeleteEmployee deleteEmployee = new DeleteEmployee(fitness1, dgwEmployees);
            deleteEmployee.Show();
        }

        private void BtnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (dgwEmployees.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgwEmployees.SelectedCells[0].RowIndex;


                DataGridViewRow selectedRow = dgwEmployees.Rows[selectedrowindex];

                  Employee = fitness1.Employees.Find(selectedRow.Cells["Id"].Value);
            }
            employe1 = Employee;
            
            UpdateEmployee updateEmployee = new UpdateEmployee(fitness1, employe1,dgwEmployees);
            updateEmployee.Show();
            
        }


        private void BtnAddRole_Click(object sender, EventArgs e)
        {
            AddRole addRole = new AddRole(fitness1, dgwRoles);
            addRole.Show();
        }

        private void BtnDeleteRole_Click(object sender, EventArgs e)
        {
            DeleteRole deleteRole = new DeleteRole(fitness1,dgwRoles);
            deleteRole.Show();
        }

        private void BtnUpdateRole_Click(object sender, EventArgs e)
        {
            if (dgwRoles.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgwRoles.SelectedCells[0].RowIndex;


                DataGridViewRow selectedRow = dgwRoles.Rows[selectedrowindex];

                role = fitness1.Roles.Find(selectedRow.Cells["Id"].Value);
            }
            role1 = role;
            UpdateRole updateRole = new UpdateRole(fitness1,dgwRoles,role1);
            updateRole.Show();
        }

        private void BtnAddService_Click(object sender, EventArgs e)
        {
            AddService addService = new AddService(fitness1,dgwServices);
            addService.Show();
        }

        private void BtnDeleteService_Click(object sender, EventArgs e)
        {
            DeleteService deleteService = new DeleteService(fitness1,dgwServices);
            deleteService.Show();
        }

        private void BtnUpdateService_Click(object sender, EventArgs e)
        {
            if (dgwServices.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgwServices.SelectedCells[0].RowIndex;


                DataGridViewRow selectedRow = dgwServices.Rows[selectedrowindex];

                service1 = fitness1.FServices.Find(selectedRow.Cells["Id"].Value);
            }
            service2 = service1;
            UpdateService updateService = new UpdateService(fitness1,service2,dgwServices);
            updateService.Show();
        }

        private void BtnAddPackage_Click(object sender, EventArgs e)
        {
            AddPackage addPackage = new AddPackage(fitness1, dgwPackage);
            addPackage.Show();
        }

        private void BtnUpdatePackage_Click(object sender, EventArgs e)
        {
            if (dgwPackage.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgwPackage.SelectedCells[0].RowIndex;


                DataGridViewRow selectedRow = dgwPackage.Rows[selectedrowindex];

                package = fitness1.Packets.Find(selectedRow.Cells["Id"].Value);
            }
            package2 = package;
            UpdatePackage updatePackage = new UpdatePackage(fitness1,package2,dgwPackage);
            updatePackage.Show();
        }
    }
}
