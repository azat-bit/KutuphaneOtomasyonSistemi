using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonSistemi
{

    internal class Library : Book
    {
        List<Book> books = new List<Book>();

        Book book = new Book();
        public void add(string name, string author, string iSBN, bool state, int price)
        {
            book.Name = name;
            book.Author = author;
            book.ISBN = iSBN;
            book.Price = price;
            book.State = state;

            books.Add(book);
            Console.WriteLine($"{book.Name} kitap eklenmiştir,ISBN numarası =  {book.ISBN}");
        }
        public void delete(string isnb)
        {
            foreach (Book book in books)
            {
                if (book.ISBN == isnb)
                {
                    Console.WriteLine($"abi istediğin kitap silindi:{book.ISBN}");
                    books.Remove(book);
                }
          }
        }
        public void show()
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"Kitap Adı: {books[i].Name}, Yazar: {books[i].Author}, ISBN: {books[i].ISBN}, Durum: {books[i].State}, Fiyat: {books[i].Price}");
            }

        }
    }
}
