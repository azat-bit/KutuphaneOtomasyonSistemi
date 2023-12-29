using KutuphaneOtomasyonSistemi;
using System;

class Program
{
    static void Main()
    {   Book book = new Book();  
        Library library = new Library();
        Library library1 = new Library();
        Library library2 = new Library();
        Library library3 = new Library();

        library.add("1azat", "sdfa", "asd", false, 0);
        library1.add("2azat", "sdfa", "asd1", false, 0);
        library2.add("3azat", "sdfa", "asd2", false, 0);
        library3.add("4azat", "sdfa", "asd3", false, 0);
        library.show();
        library1.show();
        library2.show();
        library3.show();

    }
}
