using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeLivros
{
    public class Book
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string BookTitle { get; set; }
        public string BookAutor {  get; set; }

        public int BookYear { get; set; }


        public static void AddBook(List<Book> list, Book books)
        {
            list.Add(books);
        }
    }
}
