namespace FinalProject
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgwEmployees = new System.Windows.Forms.DataGridView();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgwCustomers = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dgwServices = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgwRoles = new System.Windows.Forms.DataGridView();
            this.btnUpdateRole = new System.Windows.Forms.Button();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgwPackage = new System.Windows.Forms.DataGridView();
            this.btnUpdatePackage = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dgwOrderDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Admin";
            // 
            // dgwEmployees
            // 
            this.dgwEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwEmployees.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEmployees.Location = new System.Drawing.Point(18, 107);
            this.dgwEmployees.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgwEmployees.Name = "dgwEmployees";
            this.dgwEmployees.RowHeadersWidth = 62;
            this.dgwEmployees.RowTemplate.Height = 28;
            this.dgwEmployees.Size = new System.Drawing.Size(455, 165);
            this.dgwEmployees.TabIndex = 1;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddEmployee.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(526, 116);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(256, 39);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.Location = new System.Drawing.Point(526, 174);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(269, 39);
            this.btnDeleteEmployee.TabIndex = 3;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.BtnDeleteEmployee_Click);
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.BackColor = System.Drawing.Color.Chartreuse;
            this.btnUpdateEmp.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmp.Location = new System.Drawing.Point(526, 233);
            this.btnUpdateEmp.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(271, 39);
            this.btnUpdateEmp.TabIndex = 4;
            this.btnUpdateEmp.Text = "Update Employee";
            this.btnUpdateEmp.UseVisualStyleBackColor = false;
            this.btnUpdateEmp.Click += new System.EventHandler(this.BtnUpdateEmp_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "Employees";
            // 
            // dgwCustomers
            // 
            this.dgwCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCustomers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomers.Location = new System.Drawing.Point(902, 107);
            this.dgwCustomers.Name = "dgwCustomers";
            this.dgwCustomers.RowHeadersWidth = 62;
            this.dgwCustomers.RowTemplate.Height = 28;
            this.dgwCustomers.Size = new System.Drawing.Size(303, 150);
            this.dgwCustomers.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(979, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "Customers";
            // 
            // dgwServices
            // 
            this.dgwServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwServices.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwServices.Location = new System.Drawing.Point(18, 333);
            this.dgwServices.Name = "dgwServices";
            this.dgwServices.RowHeadersWidth = 62;
            this.dgwServices.RowTemplate.Height = 28;
            this.dgwServices.Size = new System.Drawing.Size(455, 150);
            this.dgwServices.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Services";
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.BackColor = System.Drawing.Color.Chartreuse;
            this.btnUpdateService.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateService.Location = new System.Drawing.Point(526, 444);
            this.btnUpdateService.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(271, 39);
            this.btnUpdateService.TabIndex = 17;
            this.btnUpdateService.Text = "Update Service";
            this.btnUpdateService.UseVisualStyleBackColor = false;
            this.btnUpdateService.Click += new System.EventHandler(this.BtnUpdateService_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteService.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteService.Location = new System.Drawing.Point(526, 391);
            this.btnDeleteService.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(269, 39);
            this.btnDeleteService.TabIndex = 16;
            this.btnDeleteService.Text = "Delete Service";
            this.btnDeleteService.UseVisualStyleBackColor = false;
            this.btnDeleteService.Click += new System.EventHandler(this.BtnDeleteService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddService.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.Location = new System.Drawing.Point(526, 333);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(256, 39);
            this.btnAddService.TabIndex = 15;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.BtnAddService_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Roles";
            // 
            // dgwRoles
            // 
            this.dgwRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRoles.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRoles.Location = new System.Drawing.Point(18, 547);
            this.dgwRoles.Name = "dgwRoles";
            this.dgwRoles.RowHeadersWidth = 62;
            this.dgwRoles.RowTemplate.Height = 28;
            this.dgwRoles.Size = new System.Drawing.Size(455, 153);
            this.dgwRoles.TabIndex = 19;
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.BackColor = System.Drawing.Color.Chartreuse;
            this.btnUpdateRole.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRole.Location = new System.Drawing.Point(526, 658);
            this.btnUpdateRole.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(271, 39);
            this.btnUpdateRole.TabIndex = 22;
            this.btnUpdateRole.Text = "Update Role";
            this.btnUpdateRole.UseVisualStyleBackColor = false;
            this.btnUpdateRole.Click += new System.EventHandler(this.BtnUpdateRole_Click);
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteRole.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRole.Location = new System.Drawing.Point(526, 605);
            this.btnDeleteRole.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(269, 39);
            this.btnDeleteRole.TabIndex = 21;
            this.btnDeleteRole.Text = "Delete Role";
            this.btnDeleteRole.UseVisualStyleBackColor = false;
            this.btnDeleteRole.Click += new System.EventHandler(this.BtnDeleteRole_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddRole.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRole.Location = new System.Drawing.Point(526, 547);
            this.btnAddRole.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(256, 39);
            this.btnAddRole.TabIndex = 20;
            this.btnAddRole.Text = "Add Role";
            this.btnAddRole.UseVisualStyleBackColor = false;
            this.btnAddRole.Click += new System.EventHandler(this.BtnAddRole_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(998, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "Package";
            // 
            // dgwPackage
            // 
            this.dgwPackage.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwPackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPackage.Location = new System.Drawing.Point(902, 333);
            this.dgwPackage.Name = "dgwPackage";
            this.dgwPackage.RowHeadersWidth = 62;
            this.dgwPackage.RowTemplate.Height = 28;
            this.dgwPackage.Size = new System.Drawing.Size(303, 194);
            this.dgwPackage.TabIndex = 24;
            // 
            // btnUpdatePackage
            // 
            this.btnUpdatePackage.BackColor = System.Drawing.Color.Chartreuse;
            this.btnUpdatePackage.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePackage.Location = new System.Drawing.Point(1241, 444);
            this.btnUpdatePackage.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnUpdatePackage.Name = "btnUpdatePackage";
            this.btnUpdatePackage.Size = new System.Drawing.Size(271, 39);
            this.btnUpdatePackage.TabIndex = 27;
            this.btnUpdatePackage.Text = "Update Package";
            this.btnUpdatePackage.UseVisualStyleBackColor = false;
            this.btnUpdatePackage.Click += new System.EventHandler(this.BtnUpdatePackage_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddPackage.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPackage.Location = new System.Drawing.Point(1241, 382);
            this.btnAddPackage.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(256, 39);
            this.btnAddPackage.TabIndex = 25;
            this.btnAddPackage.Text = "Add Package";
            this.btnAddPackage.UseVisualStyleBackColor = false;
            this.btnAddPackage.Click += new System.EventHandler(this.BtnAddPackage_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(998, 552);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 28);
            this.label9.TabIndex = 28;
            this.label9.Text = "Order Details";
            // 
            // dgwOrderDetails
            // 
            this.dgwOrderDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrderDetails.Location = new System.Drawing.Point(902, 605);
            this.dgwOrderDetails.Name = "dgwOrderDetails";
            this.dgwOrderDetails.RowHeadersWidth = 62;
            this.dgwOrderDetails.RowTemplate.Height = 28;
            this.dgwOrderDetails.Size = new System.Drawing.Size(409, 209);
            this.dgwOrderDetails.TabIndex = 29;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1528, 898);
            this.Controls.Add(this.dgwOrderDetails);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnUpdatePackage);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.dgwPackage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdateRole);
            this.Controls.Add(this.btnDeleteRole);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.dgwRoles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdateService);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgwServices);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgwCustomers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUpdateEmp);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.dgwEmployees);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Admin";
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwEmployees;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgwCustomers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgwServices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgwRoles;
        private System.Windows.Forms.Button btnUpdateRole;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgwPackage;
        private System.Windows.Forms.Button btnUpdatePackage;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgwOrderDetails;
    }
}