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

        public ProductForm()
        {
            InitializeComponent();
        }
        public ProductForm(Product product)
        {
            InitializeComponent();
            textBox1.Text = product.name;
            textBox2.Text = product.weight;
            textBox3.Text = product.kind;
            textBox4.Text = product.price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                InfoProductTransfer.error = false;
                InfoProductTransfer.nameInfo = textBox1.Text;
                InfoProductTransfer.weightInfo = textBox2.Text;
                InfoProductTransfer.kindInfo = textBox3.Text;
                InfoProductTransfer.priceInfo = textBox4.Text;
            }
            else
            {
                MessageBox.Show(" Element empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InfoProductTransfer.error = true;
            }

           this.Close();
        }
    }
}
