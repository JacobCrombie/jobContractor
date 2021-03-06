using System.ComponentModel.DataAnnotations;

namespace jobContractor.Models
{
  public class Job
  {
    public int Id { get; set; }
    [Required]
    public string Location { get; set; }
    [Required]
    public string Contact { get; set; }
    public string Description { get; set; }
    public string StartDate {get; set;}
  }
  public class JobBidViewModel : Job
  {
    public int BidId { get; set; }
    public double BidRate { get; set; }
  }
}