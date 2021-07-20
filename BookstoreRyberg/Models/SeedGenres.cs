using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreRyberg.Models
{
    public class SeedGenres : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> entity)
        {
            entity.HasData(
                new Genre { GenreId = "act", Name = "Action"},
                new Genre { GenreId = "rom", Name = "Romance" },
                new Genre { GenreId = "mys", Name = "Mystery" }
                );
        }
    }
}
