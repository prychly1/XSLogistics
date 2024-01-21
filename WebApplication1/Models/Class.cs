using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Class
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Category { get; set; }

        public DateTime DateOfCreate { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
