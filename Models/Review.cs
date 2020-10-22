using System.ComponentModel.DataAnnotations;

namespace jobContractor.Models
{
  public class Review
  {
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Body { get; set; }
    public string Rating { get; set; }
    public string Date { get; set; }
    [Required]
    public string ContractorId { get; set; }
  }
}