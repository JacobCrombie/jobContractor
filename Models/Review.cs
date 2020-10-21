using System.ComponentModel.DataAnnotations;

namespace jobContractor.Models
{
    public class Review
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        public string Rating { get; set; }
        public string Date { get; set; }
        [Required]
        public int ContractorId { get; set; }
    }
}