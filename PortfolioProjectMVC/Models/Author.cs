using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioProjectMVC.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}