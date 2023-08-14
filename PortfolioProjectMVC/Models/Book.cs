using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace PortfolioProjectMVC.Models
{
    public class Book
    {
        // Book Details //
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public int TotalPages { get; set; }

        // Author Details //
        [Required]
        [ForeignKey(nameof(Title))]
        public int AuthorId { get; set; }

        // Publisher Details //
        [Required]
        [ForeignKey(nameof(AuthorId))]
        public int PublisherId { get; set; }
        
        [Required]
        [ForeignKey(nameof(PublisherId))]
        public int GenreId { get; set; }
    }
}
