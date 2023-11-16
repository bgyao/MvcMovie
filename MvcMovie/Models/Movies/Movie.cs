using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models.Movies;

public class Movie
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter the movie title.")] //not covered by the tutorial. self-study
    public string? Title { get; set; }

    [Display(Name ="Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Required(ErrorMessage = "Please enter the genre of the movie.")] //not covered by the tutorial. self-study
    public string? Genre { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

}
