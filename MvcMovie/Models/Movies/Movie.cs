using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models.Movies;

public class Movie
{
    public int Id { get; set; }

    [StringLength(60)] //removed MinimumLength = 3 since there is a movie titled "It".
    [Required(ErrorMessage = "Please enter the movie title.")] //not covered by the tutorial. self-study
    public string? Title { get; set; }

    //[Required] not needed, as datatypes int, decimal, float, and DateTime are inherently required
    [Display(Name ="Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")] // use letters only, first letter must be capitalized.
    [Required(ErrorMessage = "Please enter the genre of the movie.")] //not covered by the tutorial. self-study
    public string? Genre { get; set; }

    //[Required] not needed, as datatypes int, decimal, float, and DateTime are inherently required
    [Range(1,100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")] // accept alphanumeric and special characters. PG-13 for example
    [StringLength(5)]
    [Required(ErrorMessage = "This field is required.")]
    public string? Rating { get; set; }
}
