using System.ComponentModel.DataAnnotations;

namespace MovieNest.Models
{
    public class Movie 
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required(ErrorMessage = "Movie name is required")]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Release date is required")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [StringLength(500)]
        public string? Casting { get; set; }

        [StringLength(100)]
        public string? Director { get; set; }

        [StringLength(100)]
        public string? Producer { get; set; }

    }

}
