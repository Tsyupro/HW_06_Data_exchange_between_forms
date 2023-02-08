namespace HW_06_Data_exchange_between_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
            if (productForm.product!=null)
            {
                listBox1.Items.Add(productForm.product);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Product? item = listBox1.SelectedItem as Product;
            if (item != null)
            {
                MessageBox.Show(item.AllInfo());
            }
            else
            {
                MessageBox.Show(" Element empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show(" Select an item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Product? item = listBox1.SelectedItem as Product;
            if (item != null)
            {
                int index = listBox1.SelectedIndex;
                ProductForm productForm = new ProductForm(item);
                productForm.ShowDialog();
                if (productForm.product != null)     
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    listBox1.Items.Insert(index,productForm.product);
                }
            }
            else
            {
                MessageBox.Show(" Select an item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button? button = sender as Button;
            button.BackColor = Color.Silver;
            button.ForeColor = Color.Black;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button? button = sender as Button;
            button.BackColor = Color.DimGray;
            button.ForeColor = Color.White;
        }
    }
}