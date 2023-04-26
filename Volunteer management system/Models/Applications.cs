using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer_management_system.Models
{
    public class Applications
    { 
        [Key]
        public int ID { get; set; }

        [Required]
        public string ApplicantFullName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string ApplicantEmail { get; set; }

        [ForeignKey("OpportunityID")]
        public string OpportunityID { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 100)]
        public string Note { get; set; }
        public string Status { get; set; }
        public DateTime CreateDate { get; set; }

        // Relationships
        public Opportunities Opportunity { get; set; }
    }
}
