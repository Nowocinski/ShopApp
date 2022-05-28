namespace UserInterface.Forms
{
    partial class ProductListForm
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
            this.prooductsDataGridView = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.prooductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(303, 67);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(115, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Lista produktów";
            // 
            // prooductsDataGridView
            // 
            this.prooductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prooductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Price});
            this.prooductsDataGridView.Location = new System.Drawing.Point(48, 108);
            this.prooductsDataGridView.Name = "prooductsDataGridView";
            this.prooductsDataGridView.RowHeadersWidth = 51;
            this.prooductsDataGridView.RowTemplate.Height = 29;
            this.prooductsDataGridView.Size = new System.Drawing.Size(498, 211);
            this.prooductsDataGridView.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.HeaderText = "Nazwa";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Cena";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prooductsDataGridView);
            this.Controls.Add(this.titleLabel);
            this.Name.Name = "ProductListForm"; // TODO: samo this.Name nie działało
            this.Text = "ProductListForm";
            this.Load += new System.EventHandler(this.ProductListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prooductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel;
        private DataGridView prooductsDataGridView;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Price;
    }
}