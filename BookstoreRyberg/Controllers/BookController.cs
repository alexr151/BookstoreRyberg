using Bookstore.Models;
using BookstoreRyberg.Models;
using BookstoreRyberg.Models.DataLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreRyberg.Controllers
{
    public class PlayerController : Controller
    {
        private BookstoreUnitOfWork data { get; set; }
        public PlayerController(BookstoreContext ctx) =>
            data = new BookstoreUnitOfWork(ctx);

        [HttpPost]
        public IActionResult Edit(BookViewModel lvm)
        {
            if (ModelState.IsValid)
            {
                data.DeleteCurrentBookAuthors(lvm.Books);
                data.AddNewTeamPlayers(lvm.Players, lvm.SelectedPlayers);
                data.Players.Update(lvm.Players);
                data.Save();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
