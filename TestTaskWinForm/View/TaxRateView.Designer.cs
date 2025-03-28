namespace TestTaskWinForm
{
    partial class TaxRateView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Button btnGetTaxRate;
        private System.Windows.Forms.Label lblTaxRate;

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
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.btnGetTaxRate = new System.Windows.Forms.Button();
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.SuspendLayout();

         
            this.txtZipCode.Location = new System.Drawing.Point(12, 12);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(150, 25);
            this.txtZipCode.TabIndex = 0;

           
            this.btnGetTaxRate.Location = new System.Drawing.Point(170, 10);
            this.btnGetTaxRate.Name = "btnGetTaxRate";
            this.btnGetTaxRate.Size = new System.Drawing.Size(120, 30);
            this.btnGetTaxRate.TabIndex = 1;
            this.btnGetTaxRate.Text = "Get Tax Rate";
            this.btnGetTaxRate.UseVisualStyleBackColor = true;
            this.btnGetTaxRate.Click += new System.EventHandler(this.btnGetTaxRate_Click);

           
            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Location = new System.Drawing.Point(12, 50);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(100, 20);
            this.lblTaxRate.TabIndex = 2;
            this.lblTaxRate.Text = "Tax Rate: N/A";

          
            this.ClientSize = new System.Drawing.Size(320, 100);
            this.Controls.Add(this.lblTaxRate);
            this.Controls.Add(this.btnGetTaxRate);
            this.Controls.Add(this.txtZipCode);
            this.Name = "TaxRate";
            this.Text = "Tax Rate Lookup";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}