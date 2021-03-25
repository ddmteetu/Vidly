using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumberInStock { get; set; }
        //Associate `Movie` Class with `Genre` with the help of a navigational property, `Genre`
        public Genre Genre { get; set; }
        //`Foreign Key` to the `Genre` Table
        public byte GenreId { get; set; }
    }
}