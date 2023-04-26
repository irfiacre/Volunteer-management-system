using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteer_management_system.Models
{
    public class Opportunities
    {
        [Key]
        public string ID { get; set; }

        [Display(Name = "CoverURL")]
        [Required(ErrorMessage = "CoverURL is required")]
        public string CoverURL { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage ="Title is required")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Organization")]
        [Required(ErrorMessage = "Organization is required")]
        public string Organization { get; set; }

        [Display(Name = "Vacancies")]
        [Required(ErrorMessage = "Vacancies is required")]
        public int Vacancies { get; set; } // number of available positions
        public int UserId { get; set; }
        [ForeignKey("UserId")]

        [Display(Name = "StartAt")]
        [Required(ErrorMessage = "Start Date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "EndAt")]
        [Required(ErrorMessage = "End Date is required")]
        public DateTime EndDate { get; set; }

        // Relationships

        public List<Applications> MadeApplications { get; set; } 
        public Users User { get; set; }
    }
}
