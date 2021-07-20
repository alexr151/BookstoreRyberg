using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreRyberg.Models
{
    public class SeedAuthors : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> entity)
        {
            entity.HasData(
                new Author { AuthorId = 1, FirstName = "Alex", LastName = "Ryberg"},
                new Author { AuthorId = 2, FirstName = "Ashley", LastName = "Green" },
                new Author { AuthorId = 3, FirstName = "Olive", LastName = "Green" }
                );
        }
    }
}
