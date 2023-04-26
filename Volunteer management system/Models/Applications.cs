using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer_management_system.Models
{
    public class Applications
    { 
        [Key]
        public int ID { get; set; }
        public string ApplicantFullName { get; set; }
        public string ApplicantEmail { get; set; }
        public string OpportunityID { get; set; }
        [ForeignKey("OpportunityID")]
        public string Note { get; set; }
        public string Status { get; set; }
        public DateTime CreateDate { get; set; }

        // Relationships
        public Opportunities Opportunity { get; set; }
    }
}
