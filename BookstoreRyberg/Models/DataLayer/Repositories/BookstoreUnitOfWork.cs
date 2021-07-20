using BasketballTeamRyberg.Models.DataLayer.Repositories;
using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreRyberg.Models.DataLayer.Repositories
{
    public class BookstoreUnitOfWork
    {
        private BookstoreContext context { get; set; }

        public BookstoreUnitOfWork(BookstoreContext ctx) => context = ctx;

        private Repository<Book> bookData;
        public Repository<Book> Books
        {
            get
            {
                if (bookData == null)
                {
                    bookData = new Repository<Book>(context);
                }
            }
        }

        internal void DeleteCurrentTeamPlayers(object players)
        {
            throw new NotImplementedException();
        }

        public void DeleteCurrentBookAuthors(Book book)
        {
            var currentAuthors = BookAuthors.List(new QueryOptions<BookAuthor> {
                Where = ba => ba.BookId == book.BookId
            });

            foreach (BookAuthor ba in currentAuthors)
            {
                BookAuthors.Delete(ba);
            }
        }
    }
}
