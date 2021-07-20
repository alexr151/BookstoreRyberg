using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookstoreRyberg.Models
{
    public class Genre
    {
        [StringLength(10)]
        [Required(ErrorMessage ="Please enter genre id")]
        [Remote("CheckGenre", "Validation", "")]
        public string GenreId { get; set; }

        [StringLength(25)]
        [Required(ErrorMessage = "Please enter genre")]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}