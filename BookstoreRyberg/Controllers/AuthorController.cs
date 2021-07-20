using BasketballTeamRyberg.Models.DataLayer.Repositories;
using Bookstore.Models;
using BookstoreRyberg.Models;
using BookstoreRyberg.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreRyberg.Controllers
{
    public class AuthorController : Controller
    {
        private Repository<Author> data { get; set; }

        public AuthorController(BookstoreContext ctx) => data = new Repository<Author>(ctx);

        public ViewResult Index()
        {
            var authors = data.List(new QueryOptions<Author>
            {
                OrderBy = a => a.FirstName
            });

            return View(authors);
        }
    }
}
