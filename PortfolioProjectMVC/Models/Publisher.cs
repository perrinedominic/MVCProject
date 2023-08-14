using System.ComponentModel.DataAnnotations;

namespace PortfolioProjectMVC.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}