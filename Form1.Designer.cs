namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passwordLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // userLabel
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(150, 20); // позиция по центру
            this.userLabel.Name = "userLabel";
            this.userLabel.Text = "Ім'я користувача:";

            // passwordLabel
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(150, 65); // позиция по центру
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Text = "Пароль:";

            // userNameTextBox
            this.userNameTextBox.Location = new System.Drawing.Point(150, 40);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(150, 20);

            // passwordTextBox
            this.passwordTextBox.Location = new System.Drawing.Point(150, 80);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(150, 20);

            // loginButton
            this.loginButton.Location = new System.Drawing.Point(150, 120); // позиция по центру
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(750, 400);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginButton);
            this.Name = "Form1";
            this.Text = "CRM Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
    }
