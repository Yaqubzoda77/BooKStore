using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int NumberOfPages { get; set; }
    [MaxLength(50)]
    public string Author { get; set; }  
}