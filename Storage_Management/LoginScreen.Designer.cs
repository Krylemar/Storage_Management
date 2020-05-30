namespace Storage_Management
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.UsernameField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.AlphaLabel = new System.Windows.Forms.Label();
            this.ErrorMsgLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameField
            // 
            this.UsernameField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameField.BackColor = System.Drawing.SystemColors.HighlightText;
            this.UsernameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameField.Location = new System.Drawing.Point(98, 156);
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.Size = new System.Drawing.Size(441, 50);
            this.UsernameField.TabIndex = 0;
            this.UsernameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsernameField.TextChanged += new System.EventHandler(this.UsernameField_TextChanged);
            // 
            // PasswordField
            // 
            this.PasswordField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordField.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordField.Location = new System.Drawing.Point(98, 245);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(441, 50);
            this.PasswordField.TabIndex = 1;
            this.PasswordField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordField.TextChanged += new System.EventHandler(this.PasswordField_TextChanged);
            this.PasswordField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordField_KeyDown);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.BackColor = System.Drawing.Color.LimeGreen;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(329, 320);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(196, 52);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Влез";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RegisterButton.BackColor = System.Drawing.Color.DarkGreen;
            this.RegisterButton.Location = new System.Drawing.Point(117, 320);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(196, 52);
            this.RegisterButton.TabIndex = 3;
            this.RegisterButton.Text = "Регистрирай се";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AppNameLabel.AutoSize = true;
            this.AppNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.AppNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AppNameLabel.Location = new System.Drawing.Point(58, 28);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(526, 82);
            this.AppNameLabel.TabIndex = 4;
            this.AppNameLabel.Text = "Storage Master";
            // 
            // AlphaLabel
            // 
            this.AlphaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AlphaLabel.AutoSize = true;
            this.AlphaLabel.BackColor = System.Drawing.Color.Transparent;
            this.AlphaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AlphaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AlphaLabel.Location = new System.Drawing.Point(12, 469);
            this.AlphaLabel.Name = "AlphaLabel";
            this.AlphaLabel.Size = new System.Drawing.Size(152, 32);
            this.AlphaLabel.TabIndex = 5;
            this.AlphaLabel.Text = "Alpha 0.01";
            // 
            // ErrorMsgLabel
            // 
            this.ErrorMsgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ErrorMsgLabel.AutoSize = true;
            this.ErrorMsgLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorMsgLabel.Location = new System.Drawing.Point(128, 298);
            this.ErrorMsgLabel.Name = "ErrorMsgLabel";
            this.ErrorMsgLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorMsgLabel.TabIndex = 7;
            this.ErrorMsgLabel.Click += new System.EventHandler(this.ErrorMsgLabel_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(648, 504);
            this.Controls.Add(this.ErrorMsgLabel);
            this.Controls.Add(this.AlphaLabel);
            this.Controls.Add(this.AppNameLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.UsernameField);
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.Label AlphaLabel;
        private System.Windows.Forms.Label ErrorMsgLabel;
    }
}