namespace UserInterface.Forms
{
    partial class HomeForm
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
            this.loggingButton = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loggingButton
            // 
            this.loggingButton.Location = new System.Drawing.Point(182, 255);
            this.loggingButton.Name = "loggingButton";
            this.loggingButton.Size = new System.Drawing.Size(94, 29);
            this.loggingButton.TabIndex = 0;
            this.loggingButton.Text = "Zaloguj";
            this.loggingButton.UseVisualStyleBackColor = true;
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(383, 255);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(94, 29);
            this.signupButton.TabIndex = 1;
            this.signupButton.Text = "Zarejestruj";
            this.signupButton.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.loggingButton);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button loggingButton;
        private Button signupButton;
    }
}