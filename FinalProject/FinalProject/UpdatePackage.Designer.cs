namespace FinalProject
{
    partial class UpdatePackage
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
            this.btnUpdatePackage = new System.Windows.Forms.Button();
            this.flpServices = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPackageHours = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPackageDays = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPackagePrice = new System.Windows.Forms.TextBox();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdatePackage
            // 
            this.btnUpdatePackage.Location = new System.Drawing.Point(155, 315);
            this.btnUpdatePackage.Name = "btnUpdatePackage";
            this.btnUpdatePackage.Size = new System.Drawing.Size(251, 77);
            this.btnUpdatePackage.TabIndex = 17;
            this.btnUpdatePackage.Text = "Update";
            this.btnUpdatePackage.UseVisualStyleBackColor = true;
            this.btnUpdatePackage.Click += new System.EventHandler(this.BtnUpdatePackage_Click);
            // 
            // flpServices
            // 
            this.flpServices.Location = new System.Drawing.Point(640, 58);
            this.flpServices.Name = "flpServices";
            this.flpServices.Size = new System.Drawing.Size(290, 323);
            this.flpServices.TabIndex = 16;
            // 
            // txtPackageHours
            // 
            this.txtPackageHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageHours.Location = new System.Drawing.Point(301, 226);
            this.txtPackageHours.Name = "txtPackageHours";
            this.txtPackageHours.Size = new System.Drawing.Size(235, 35);
            this.txtPackageHours.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Package ActiveHours";
            // 
            // txtPackageDays
            // 
            this.txtPackageDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageDays.Location = new System.Drawing.Point(18, 226);
            this.txtPackageDays.Name = "txtPackageDays";
            this.txtPackageDays.Size = new System.Drawing.Size(235, 35);
            this.txtPackageDays.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Package ActiveDays";
            // 
            // txtPackagePrice
            // 
            this.txtPackagePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackagePrice.Location = new System.Drawing.Point(301, 91);
            this.txtPackagePrice.Name = "txtPackagePrice";
            this.txtPackagePrice.Size = new System.Drawing.Size(235, 35);
            this.txtPackagePrice.TabIndex = 11;
            // 
            // txtPackageName
            // 
            this.txtPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageName.Location = new System.Drawing.Point(18, 91);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(235, 35);
            this.txtPackageName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Package Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Package Price";
            // 
            // UpdatePackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 457);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdatePackage);
            this.Controls.Add(this.flpServices);
            this.Controls.Add(this.txtPackageHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPackageDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPackagePrice);
            this.Controls.Add(this.txtPackageName);
            this.Name = "UpdatePackage";
            this.Text = "UpdatePackage";
            this.Load += new System.EventHandler(this.UpdatePackage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdatePackage;
        private System.Windows.Forms.FlowLayoutPanel flpServices;
        private System.Windows.Forms.TextBox txtPackageHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPackageDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPackagePrice;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}