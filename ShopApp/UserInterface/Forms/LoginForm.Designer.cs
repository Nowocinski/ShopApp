namespace UserInterface.Forms
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
            this.signupButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(423, 350);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(148, 50);
            this.signupButton.TabIndex = 0;
            this.signupButton.Text = "Nie masz konta? Zarejestruj się";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(630, 361);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(94, 29);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Powrót";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(198, 79);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(198, 27);
            this.emailTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(201, 148);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(195, 27);
            this.passwordTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(487, 251);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(94, 29);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Zaloguj";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(94, 87);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(52, 20);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "E-mail";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(99, 148);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(47, 20);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Hasło";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.signupButton);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button signupButton;
        private Button backButton;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Label emailLabel;
        private Label passwordLabel;
    }
}