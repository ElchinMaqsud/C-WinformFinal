namespace FinalProject
{
    partial class DeleteService
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
            this.cmbDeleteService = new System.Windows.Forms.ComboBox();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Services";
            // 
            // cmbDeleteService
            // 
            this.cmbDeleteService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeleteService.FormattingEnabled = true;
            this.cmbDeleteService.Location = new System.Drawing.Point(274, 153);
            this.cmbDeleteService.Name = "cmbDeleteService";
            this.cmbDeleteService.Size = new System.Drawing.Size(228, 37);
            this.cmbDeleteService.TabIndex = 1;
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(274, 244);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(228, 46);
            this.btnDeleteService.TabIndex = 2;
            this.btnDeleteService.Text = "Delete";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.BtnDeleteService_Click);
            // 
            // DeleteService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.cmbDeleteService);
            this.Controls.Add(this.label1);
            this.Name = "DeleteService";
            this.Text = "DeleteService";
            this.Load += new System.EventHandler(this.DeleteService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDeleteService;
        private System.Windows.Forms.Button btnDeleteService;
    }
}