namespace FinalProject
{
    partial class UpdateRole
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
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.btnUpdateRole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Role Name";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoleName.Location = new System.Drawing.Point(154, 163);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(303, 35);
            this.txtRoleName.TabIndex = 1;
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRole.Location = new System.Drawing.Point(241, 226);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(139, 63);
            this.btnUpdateRole.TabIndex = 2;
            this.btnUpdateRole.Text = "Update";
            this.btnUpdateRole.UseVisualStyleBackColor = true;
            this.btnUpdateRole.Click += new System.EventHandler(this.BtnUpdateRole_Click);
            // 
            // UpdateRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 430);
            this.Controls.Add(this.btnUpdateRole);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.label1);
            this.Name = "UpdateRole";
            this.Text = "UpdateRole";
            this.Load += new System.EventHandler(this.UpdateRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Button btnUpdateRole;
    }
}