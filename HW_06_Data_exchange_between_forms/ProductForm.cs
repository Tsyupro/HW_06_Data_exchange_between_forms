using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_06_Data_exchange_between_forms
{
    public partial class ProductForm : Form
    {
        public Product? product = null;
        public ProductForm()
        {
            InitializeComponent();
        }
        public ProductForm(Product _product)
        {
            InitializeComponent();
            
            NameBox.Text = _product.name;
            WeightBox.Text = _product.weight;
            KindBox.Text = _product.kind;
            PriceBox.Text = _product.price;
            
            product = _product;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameBox.Text != "" && WeightBox.Text != "" && KindBox.Text != "" && PriceBox.Text != "")
            {            
                if(product!= null)
                {
                    product.Update(NameBox.Text, WeightBox.Text, KindBox.Text, PriceBox.Text);
                }
                else
                {
                    product = new Product(NameBox.Text, WeightBox.Text, KindBox.Text, PriceBox.Text);
                }
            }
            else
            {
                MessageBox.Show(" Element empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           this.Close();
        }
    }
}
