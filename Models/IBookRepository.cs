using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dependecy_Injection.Models
{
    public interface IBookRepository
    {
        void Add(Book Entry);
        void Delete(Book Entry);
        Book Get(int Id);
        List<Book> GetAll();
      
    }
}