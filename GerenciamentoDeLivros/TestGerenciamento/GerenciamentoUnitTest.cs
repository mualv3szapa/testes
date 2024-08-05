using GerenciamentoDeLivros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGerenciamento
{
    public class GerenciamentoUnitTest
    {
        [Fact]

        public void TestForAddBooksInAList()
        {
            List<Book> bookList = new List<Book>();

            Book book = new Book()
            {
                BookTitle = "Survival logbook",
                BookAutor = "Scott Cawthon",
                BookYear = 2018
            };

            Book.AddBook(bookList, book);

            Assert.True(bookList.Contains(book));
        }
    }
}
