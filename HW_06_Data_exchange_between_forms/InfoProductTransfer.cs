using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_06_Data_exchange_between_forms
{
    static class InfoProductTransfer
    {
        static public string? nameInfo;
        static public string? weightInfo;
        static public string? kindInfo;
        static public string? priceInfo;
        static public bool error=false;

       public static Product TransferProduct()
        {
            if (nameInfo != null && weightInfo != null && kindInfo != null && priceInfo != null)
            {
                return new Product(nameInfo, weightInfo, kindInfo, priceInfo);
            }
            else
            {
                MessageBox.Show(" Element empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductForm add = new ProductForm();
                add.ShowDialog();
                return TransferProduct();
            }
        }


    }
}
