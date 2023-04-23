using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer_management_system.Models
{
    public class Opportunities
    {
        [Key]
        public string ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Organization { get; set; }
        public string Vacancies { get; set; } // number of available positions
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Relationships

        public List<Applications> MadeApplications { get; set; } 
        public Users Users { get; set; }
    }
}
