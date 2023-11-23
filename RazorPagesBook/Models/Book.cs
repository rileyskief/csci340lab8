using System.ComponentModel.DataAnnotations;

namespace RazorPagesBook.Models;

public class Book
{
    public int Id { get; set; }
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public decimal Price { get; set; }
    public string? Author { get; set; }
}