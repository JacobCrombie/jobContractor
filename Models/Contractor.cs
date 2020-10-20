using System.ComponentModel.DataAnnotations;

namespace jobContractor.Models
{
    public class Contractor
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        [Required]
        public int Contact { get; set; }
        public string Skills { get; set; }
    }
}