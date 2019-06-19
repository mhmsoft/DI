using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dependecy_Injection.Models
{
    public class Book
    {
        public int bookId { get; set; }
        public string bookName { get; set; }
        public string Author { get; set; }
        public string BookType { get; set; }
        public DateTime? releasedDate { get; set; }
    }
}