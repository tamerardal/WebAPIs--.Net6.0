using System.ComponentModel.DataAnnotations.Schema;

public class Movie
{
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; set; }
	public string Name { get; set; }
	public DateTime ReleaseDate { get; set; }
	public int GenreId { get; set; }
	public Genre Genre { get; set; }
	public int DirectorId { get; set; }
	public Director Director { get; set; }
	public string Performers { get; set; }
	public double Price { get; set; }
}