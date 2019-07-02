namespace FinalProject
{
    partial class DeleteRole
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
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDeleteRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRole.Location = new System.Drawing.Point(292, 259);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(206, 64);
            this.btnDeleteRole.TabIndex = 5;
            this.btnDeleteRole.Text = "Delete";
            this.btnDeleteRole.UseVisualStyleBackColor = true;
            this.btnDeleteRole.Click += new System.EventHandler(this.BtnDeleteRole_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Roles";
            // 
            // cmbDeleteRole
            // 
            this.cmbDeleteRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeleteRole.FormattingEnabled = true;
            this.cmbDeleteRole.Location = new System.Drawing.Point(229, 183);
            this.cmbDeleteRole.Name = "cmbDeleteRole";
            this.cmbDeleteRole.Size = new System.Drawing.Size(342, 40);
            this.cmbDeleteRole.TabIndex = 3;
            // 
            // DeleteRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDeleteRole);
            this.Name = "DeleteRole";
            this.Text = "DeleteRole";
            this.Load += new System.EventHandler(this.DeleteRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDeleteRole;
    }
}