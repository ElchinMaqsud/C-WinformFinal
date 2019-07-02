namespace FinalProject
{
    partial class DeleteEmployee
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
            this.cmbDeleteEmp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDeleteEmp
            // 
            this.cmbDeleteEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeleteEmp.FormattingEnabled = true;
            this.cmbDeleteEmp.Location = new System.Drawing.Point(122, 101);
            this.cmbDeleteEmp.Name = "cmbDeleteEmp";
            this.cmbDeleteEmp.Size = new System.Drawing.Size(342, 40);
            this.cmbDeleteEmp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employees";
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.Location = new System.Drawing.Point(185, 177);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(206, 64);
            this.btnDeleteEmployee.TabIndex = 2;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.BtnDeleteEmployee_Click);
            // 
            // DeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 357);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDeleteEmp);
            this.Name = "DeleteEmployee";
            this.Text = "DeleteEmployee";
            this.Load += new System.EventHandler(this.DeleteEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDeleteEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteEmployee;
    }
}