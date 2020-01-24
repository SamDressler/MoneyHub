namespace MoneyHub
{
    partial class Login
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
            this.loginBasePanel = new System.Windows.Forms.Panel();
            this.loginFrame = new System.Windows.Forms.Panel();
            this.createAccountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.createAccountPrecursorLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.newAccountLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginBasePanel.SuspendLayout();
            this.loginFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBasePanel
            // 
            this.loginBasePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBasePanel.BackColor = System.Drawing.Color.Bisque;
            this.loginBasePanel.Controls.Add(this.panel1);
            this.loginBasePanel.Controls.Add(this.loginFrame);
            this.loginBasePanel.Controls.Add(this.welcomeLabel);
            this.loginBasePanel.Location = new System.Drawing.Point(3, 0);
            this.loginBasePanel.Name = "loginBasePanel";
            this.loginBasePanel.Size = new System.Drawing.Size(568, 310);
            this.loginBasePanel.TabIndex = 0;
            // 
            // loginFrame
            // 
            this.loginFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginFrame.Controls.Add(this.createAccountLinkLabel);
            this.loginFrame.Controls.Add(this.createAccountPrecursorLabel);
            this.loginFrame.Controls.Add(this.usernameLabel);
            this.loginFrame.Controls.Add(this.passwordLabel);
            this.loginFrame.Controls.Add(this.newAccountLabel);
            this.loginFrame.Controls.Add(this.passwordText);
            this.loginFrame.Controls.Add(this.usernameText);
            this.loginFrame.Controls.Add(this.loginButton);
            this.loginFrame.Location = new System.Drawing.Point(31, 51);
            this.loginFrame.Name = "loginFrame";
            this.loginFrame.Size = new System.Drawing.Size(216, 248);
            this.loginFrame.TabIndex = 8;
            // 
            // createAccountLinkLabel
            // 
            this.createAccountLinkLabel.AutoSize = true;
            this.createAccountLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLinkLabel.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.createAccountLinkLabel.Location = new System.Drawing.Point(112, 168);
            this.createAccountLinkLabel.Name = "createAccountLinkLabel";
            this.createAccountLinkLabel.Size = new System.Drawing.Size(35, 16);
            this.createAccountLinkLabel.TabIndex = 10;
            this.createAccountLinkLabel.TabStop = true;
            this.createAccountLinkLabel.Text = "here";
            this.createAccountLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccountLinkLabel_LinkClicked);
            // 
            // createAccountPrecursorLabel
            // 
            this.createAccountPrecursorLabel.AutoSize = true;
            this.createAccountPrecursorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountPrecursorLabel.Location = new System.Drawing.Point(42, 168);
            this.createAccountPrecursorLabel.Name = "createAccountPrecursorLabel";
            this.createAccountPrecursorLabel.Size = new System.Drawing.Size(74, 16);
            this.createAccountPrecursorLabel.TabIndex = 11;
            this.createAccountPrecursorLabel.Text = "Create one";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(6, 22);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(70, 15);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "User Name";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(9, 52);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(61, 15);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // newAccountLabel
            // 
            this.newAccountLabel.AutoSize = true;
            this.newAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccountLabel.Location = new System.Drawing.Point(9, 139);
            this.newAccountLabel.Name = "newAccountLabel";
            this.newAccountLabel.Size = new System.Drawing.Size(196, 16);
            this.newAccountLabel.TabIndex = 9;
            this.newAccountLabel.Text = "Don\'t already have an account?";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(82, 52);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(100, 20);
            this.passwordText.TabIndex = 2;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(82, 21);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(100, 20);
            this.usernameText.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.LightGray;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(82, 87);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.welcomeLabel.Location = new System.Drawing.Point(21, 16);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(242, 23);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to MoneyHub!";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(285, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 283);
            this.panel1.TabIndex = 9;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 310);
            this.Controls.Add(this.loginBasePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyHub Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.loginBasePanel.ResumeLayout(false);
            this.loginBasePanel.PerformLayout();
            this.loginFrame.ResumeLayout(false);
            this.loginFrame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginBasePanel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Panel loginFrame;
        private System.Windows.Forms.Label newAccountLabel;
        private System.Windows.Forms.LinkLabel createAccountLinkLabel;
        private System.Windows.Forms.Label createAccountPrecursorLabel;
        private System.Windows.Forms.Panel panel1;
    }
}