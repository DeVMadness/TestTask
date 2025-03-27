using System;
using System.Windows.Forms;
using Manager.Services.Abstraction;
using System.Collections.Generic;
using Model.Models;

namespace TestTaskWinForm
{
    public partial class Form1 : Form
    {
        private readonly IProductService _productService;
        private int _selectedProductId = -1;

        public Form1(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = _productService.GetProducts();
            dataGridViewProducts.DataSource = new BindingSource { DataSource = products };
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            decimal price;

            if (decimal.TryParse(textBoxPrice.Text, out price))
            {
                if (_selectedProductId == -1)
                {
                    _productService.CreateProduct(name, price);
                    MessageBox.Show("Product created successfully!");
                }
                else
                {
                    _productService.UpdateProduct(_selectedProductId, name, price);
                    MessageBox.Show("Product updated successfully!");
                }
                LoadProducts();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Invalid price value.");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedProductId != -1)
            {
                string name = textBoxName.Text;
                decimal price;

                if (decimal.TryParse(textBoxPrice.Text, out price))
                {
                    _productService.UpdateProduct(_selectedProductId, name, price);
                    MessageBox.Show("Product updated successfully!");
                    LoadProducts();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Invalid price value.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product to update.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_selectedProductId != -1)
            {
                _productService.DeleteProduct(_selectedProductId);
                MessageBox.Show("Product deleted successfully!");
                LoadProducts();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewProducts.SelectedRows[0];
                _selectedProductId = (int)selectedRow.Cells["ProductId"].Value;
                textBoxName.Text = selectedRow.Cells["Name"].Value.ToString();
                textBoxPrice.Text = selectedRow.Cells["Price"].Value.ToString();
            }
        }

        private void ClearForm()
        {
            _selectedProductId = -1;
            textBoxName.Clear();
            textBoxPrice.Clear();
        }
    }
}
