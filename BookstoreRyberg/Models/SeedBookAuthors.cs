using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreRyberg.Models
{
    public class SeedBookAuthors : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> entity)
        {
            entity.HasData(
                new BookAuthor { AuthorId = 1, BookId = 2},
                new BookAuthor { AuthorId = 2, BookId = 3},
                new BookAuthor { AuthorId = 3, BookId = 1 }
                );
        }
    }
}
