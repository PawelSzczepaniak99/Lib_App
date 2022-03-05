using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibApp.Models
{
    public class Book
    {
        public int Id { get; set; }
		[Required(ErrorMessage = "Tell me this NAME!")]
		[StringLength(255)]
		public string Name { get; set; }
		[Required(ErrorMessage = "Who wrote it?")]
		public string AuthorName { get; set; }
		[Required(ErrorMessage = "Genre is required")]
		public Genre Genre { get; set; }
		public byte GenreId { get; set; }
        public DateTime DateAdded { get; set; }
        [Required(ErrorMessage = "Release Date is required")]
		public DateTime ReleaseDate { get; set; }
		[Required(ErrorMessage = "How many we HAVE?")]
		[Range(1,20,ErrorMessage = "Number is out of range")]
		public int NumberInStock { get; set; }
		[Required(ErrorMessage = "How many numbers are available?")]
		public int NumberAvailable { get; set; }
	}
      
}
