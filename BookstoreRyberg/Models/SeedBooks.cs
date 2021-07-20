using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreRyberg.Models
{
    public class SeedBooks : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> entity)
        {
            entity.HasData(
                new Book { BookId = 1, Title = "Casey's Here For Good", Price = 29.99, GenreId = "act"},
                new Book { BookId = 2, Title = "Knots and Thoughts", Price = 229.99, GenreId = "rom" },
                new Book { BookId = 3, Title = "How to Tap a Keg", Price = 1.99, GenreId = "mys" }
                );
        }
    }
}
