using System;
using System.Windows.Forms;
using Integration.Service.Abstraction;

namespace TestTaskWinForm
{
    public partial class TaxRateView : Form
    {
        private readonly ITaxRateService _taxRateService;

        public TaxRateView(ITaxRateService taxRateService)
        {
            InitializeComponent();
            _taxRateService = taxRateService;
        }

        private async void btnGetTaxRate_Click(object sender, EventArgs e)
        {
            string zipCode = txtZipCode.Text;
            try
            {
                decimal taxRate = await _taxRateService.GetTaxRateByZipCodeAsync(zipCode);
                lblTaxRate.Text = $"Tax Rate: {taxRate}%";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
