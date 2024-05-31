using System.ComponentModel.DataAnnotations;

namespace veeb.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        [Range(0, 10)]
        public double AverageRating { get; set; }
    }
}
