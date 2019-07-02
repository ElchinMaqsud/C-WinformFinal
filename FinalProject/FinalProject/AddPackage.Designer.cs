namespace FinalProject
{
    partial class AddPackage
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
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.txtPackagePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPackageDays = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPackageHours = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flpServices = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Package Name";
            // 
            // txtPackageName
            // 
            this.txtPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageName.Location = new System.Drawing.Point(12, 81);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(235, 35);
            this.txtPackageName.TabIndex = 1;
            // 
            // txtPackagePrice
            // 
            this.txtPackagePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackagePrice.Location = new System.Drawing.Point(295, 81);
            this.txtPackagePrice.Name = "txtPackagePrice";
            this.txtPackagePrice.Size = new System.Drawing.Size(235, 35);
            this.txtPackagePrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Package Price";
            // 
            // txtPackageDays
            // 
            this.txtPackageDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageDays.Location = new System.Drawing.Point(12, 249);
            this.txtPackageDays.Name = "txtPackageDays";
            this.txtPackageDays.Size = new System.Drawing.Size(235, 35);
            this.txtPackageDays.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Package ActiveDays";
            // 
            // txtPackageHours
            // 
            this.txtPackageHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageHours.Location = new System.Drawing.Point(295, 249);
            this.txtPackageHours.Name = "txtPackageHours";
            this.txtPackageHours.Size = new System.Drawing.Size(235, 35);
            this.txtPackageHours.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Package ActiveHours";
            // 
            // flpServices
            // 
            this.flpServices.Location = new System.Drawing.Point(596, 81);
            this.flpServices.Name = "flpServices";
            this.flpServices.Size = new System.Drawing.Size(290, 323);
            this.flpServices.TabIndex = 8;
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(149, 338);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(251, 77);
            this.btnAddPackage.TabIndex = 9;
            this.btnAddPackage.Text = "Add";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.BtnAddPackage_Click);
            // 
            // AddPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.flpServices);
            this.Controls.Add(this.txtPackageHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPackageDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPackagePrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPackageName);
            this.Controls.Add(this.label1);
            this.Name = "AddPackage";
            this.Text = "AddPackage";
            this.Load += new System.EventHandler(this.AddPackage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.TextBox txtPackagePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPackageDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPackageHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flpServices;
        private System.Windows.Forms.Button btnAddPackage;
    }
}