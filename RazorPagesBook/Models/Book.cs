using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesBook.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;

    [Display(Name = "Date Published")]
    [DataType(DataType.Date)]
    public DateTime PublishedDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    public string Author { get; set; } = string.Empty;
}