using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_06_Data_exchange_between_forms
{
    public class Product
    {
        internal string name;
        internal string weight;
        internal string kind;
        internal string price;


        public Product(string name, string weight, string kind, string price)
        {
            this.name = name;
            this.weight = weight;
            this.kind = kind;
            this.price = price;
        }
        public override string ToString()
        {
            return $"{name}";
        }
        public string AllInfo()
        {
            return $"Назва {name} | Вага {weight} |  Вид {kind} | Ціна {price}";
        }
    }
}
