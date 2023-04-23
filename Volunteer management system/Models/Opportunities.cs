using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer_management_system.Models
{
    public class Opportunities
    {
        [Key]
        public string ID { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Organization")]
        public string Organization { get; set; }

        [Display(Name = "Vacancies")]
        public int Vacancies { get; set; } // number of available positions
        public int UserId { get; set; }
        [ForeignKey("UserId")]

        [Display(Name = "StartAt")]
        public DateTime StartDate { get; set; }

        [Display(Name = "EndAt")]
        public DateTime EndDate { get; set; }

        // Relationships

        public List<Applications> MadeApplications { get; set; } 
        public Users User { get; set; }
    }
}
