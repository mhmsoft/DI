using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dependecy_Injection.Models
{
    public class BookRepository : IBookRepository
    {
        private  static List<Book> Books = new List<Book>();
        private int BookId = 1;
        public BookRepository()
        {
            /*Add(new Book { bookName = "Beyaz Diş", BookType = "Roman", Author = "Jack London",
                releasedDate = Convert.ToDateTime("2000.12.12") });
            Add(new Book { bookName = "Çalıkuşu", BookType = "Roman", Author = "Reşat Nuri Güntekin",
                releasedDate = Convert.ToDateTime("1967.01.22") });
            Add(new Book { bookName = "Romantika", BookType = "Edebiyat/Roman", Author = "Turgut Özakman",
                releasedDate = Convert.ToDateTime("2018.02.25") });
            Add(new Book { bookName = "Büyük Dönüşüm", BookType = "Sosyoloji/Tarih", Author = "Karen Armstrong",
                    releasedDate = Convert.ToDateTime("2019.05.22") });
    */    
    }
        public void Add(Book Entry)
        {
            if (Entry != null)
            {
                Entry.bookId = BookId++;
                Books.Add(Entry);
            }
        }

        public void Delete(Book Entry)
        {
            if (Entry!=null)
            {
                Books.RemoveAll(b=>b.bookId==Entry.bookId);
            }
        }

        public Book Get(int Id)
        {
            return Books.FirstOrDefault(b=>b.bookId==Id);
        }

        public List<Book> GetAll()
        {
            return Books;
        }
    }
}