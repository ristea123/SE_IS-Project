namespace SEProject
{
    partial class LoginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.adminUserLoginBox = new System.Windows.Forms.TextBox();
            this.passAdminBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adminLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // adminUserLoginBox
            // 
            this.adminUserLoginBox.Location = new System.Drawing.Point(294, 133);
            this.adminUserLoginBox.Name = "adminUserLoginBox";
            this.adminUserLoginBox.Size = new System.Drawing.Size(156, 22);
            this.adminUserLoginBox.TabIndex = 2;
            this.adminUserLoginBox.TextChanged += new System.EventHandler(this.adminUserLoginBox_TextChanged);
            // 
            // passAdminBox
            // 
            this.passAdminBox.Location = new System.Drawing.Point(294, 193);
            this.passAdminBox.Name = "passAdminBox";
            this.passAdminBox.PasswordChar = '*';
            this.passAdminBox.Size = new System.Drawing.Size(156, 22);
            this.passAdminBox.TabIndex = 3;
            this.passAdminBox.TextChanged += new System.EventHandler(this.passAdminBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Admin login";
            // 
            // adminLoginButton
            // 
            this.adminLoginButton.Location = new System.Drawing.Point(214, 255);
            this.adminLoginButton.Name = "adminLoginButton";
            this.adminLoginButton.Size = new System.Drawing.Size(75, 23);
            this.adminLoginButton.TabIndex = 5;
            this.adminLoginButton.Text = "Login";
            this.adminLoginButton.UseVisualStyleBackColor = true;
            this.adminLoginButton.Click += new System.EventHandler(this.adminLoginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 375);
            this.Controls.Add(this.adminLoginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passAdminBox);
            this.Controls.Add(this.adminUserLoginBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminUserLoginBox;
        private System.Windows.Forms.TextBox passAdminBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button adminLoginButton;
    }
}