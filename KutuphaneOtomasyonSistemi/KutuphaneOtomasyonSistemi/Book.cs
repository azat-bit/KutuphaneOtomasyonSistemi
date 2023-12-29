using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonSistemi
{
    internal class Book
    {
       private string name;
        string author;
        string iSBN;
        bool state;
        int price =0;
        DateTime time;
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool State { get; set; }
        public int Price { get; set; }


        public int oduncAldi(int price)
        {
            this.price = price;
            price -= price;
            return price;
        }
        public int iadeEtti(int price)
        {
            this.price = price;
            price += price;
            return price;
        }



    }
}
