namespace Storage_Management
{
    partial class Form1
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
            this.Reg = new System.Windows.Forms.Button();
            this.RegFirstName = new System.Windows.Forms.TextBox();
            this.RegLastName = new System.Windows.Forms.TextBox();
            this.entityConnection1 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            this.label1 = new System.Windows.Forms.Label();
            this.RegEmail = new System.Windows.Forms.TextBox();
            this.RegUsername = new System.Windows.Forms.TextBox();
            this.RegPass = new System.Windows.Forms.TextBox();
            this.RegStorageId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Reg
            // 
            this.Reg.Location = new System.Drawing.Point(118, 127);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(75, 23);
            this.Reg.TabIndex = 0;
            this.Reg.Text = "Register";
            this.Reg.UseVisualStyleBackColor = true;
            this.Reg.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegFirstName
            // 
            this.RegFirstName.Location = new System.Drawing.Point(12, 27);
            this.RegFirstName.Name = "RegFirstName";
            this.RegFirstName.Size = new System.Drawing.Size(100, 20);
            this.RegFirstName.TabIndex = 1;
            this.RegFirstName.Text = "firstname";
            // 
            // RegLastName
            // 
            this.RegLastName.Location = new System.Drawing.Point(12, 53);
            this.RegLastName.Name = "RegLastName";
            this.RegLastName.Size = new System.Drawing.Size(100, 20);
            this.RegLastName.TabIndex = 2;
            this.RegLastName.Text = "lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // RegEmail
            // 
            this.RegEmail.Location = new System.Drawing.Point(118, 27);
            this.RegEmail.Name = "RegEmail";
            this.RegEmail.Size = new System.Drawing.Size(100, 20);
            this.RegEmail.TabIndex = 4;
            this.RegEmail.Text = "email";
            // 
            // RegUsername
            // 
            this.RegUsername.Location = new System.Drawing.Point(118, 53);
            this.RegUsername.Name = "RegUsername";
            this.RegUsername.Size = new System.Drawing.Size(100, 20);
            this.RegUsername.TabIndex = 5;
            this.RegUsername.Text = "username";
            // 
            // RegPass
            // 
            this.RegPass.Location = new System.Drawing.Point(224, 27);
            this.RegPass.Name = "RegPass";
            this.RegPass.Size = new System.Drawing.Size(100, 20);
            this.RegPass.TabIndex = 6;
            this.RegPass.Text = "pass";
            // 
            // RegStorageId
            // 
            this.RegStorageId.Location = new System.Drawing.Point(225, 53);
            this.RegStorageId.Name = "RegStorageId";
            this.RegStorageId.Size = new System.Drawing.Size(100, 20);
            this.RegStorageId.TabIndex = 7;
            this.RegStorageId.Text = "storage";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(446, 296);
            this.Controls.Add(this.RegStorageId);
            this.Controls.Add(this.RegPass);
            this.Controls.Add(this.RegUsername);
            this.Controls.Add(this.RegEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegLastName);
            this.Controls.Add(this.RegFirstName);
            this.Controls.Add(this.Reg);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Reg;
        private System.Windows.Forms.TextBox RegFirstName;
        private System.Windows.Forms.TextBox RegLastName;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegEmail;
        private System.Windows.Forms.TextBox RegUsername;
        private System.Windows.Forms.TextBox RegPass;
        private System.Windows.Forms.TextBox RegStorageId;
    }
}

