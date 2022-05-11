namespace UserInterface.Forms
{
    partial class RegistrationForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.signupButton = new System.Windows.Forms.Button();
            this.backBatton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(314, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(81, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Rejestracja";
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(443, 353);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(94, 29);
            this.signupButton.TabIndex = 1;
            this.signupButton.Text = "Zarejestruj";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // backBatton
            // 
            this.backBatton.Location = new System.Drawing.Point(600, 353);
            this.backBatton.Name = "backBatton";
            this.backBatton.Size = new System.Drawing.Size(94, 29);
            this.backBatton.TabIndex = 2;
            this.backBatton.Text = "Powrót";
            this.backBatton.UseVisualStyleBackColor = true;
            this.backBatton.Click += new System.EventHandler(this.backBatton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBatton);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel;
        private Button signupButton;
        private Button backBatton;
    }
}