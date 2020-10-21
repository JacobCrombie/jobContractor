using System.ComponentModel.DataAnnotations;

namespace jobContractor.Models
{
    public class Bid
    {
        public int Id { get; set; }
        [Required]
        public int JobId { get; set; }
        [Required]
        public int ContractorId { get; set; }
        [Required]
        public double BidValue { get; set; }
    }
}