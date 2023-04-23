using System.ComponentModel.DataAnnotations;

namespace Volunteer_management_system.Models
{
    public class Users
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Organization { get; set; }
        public DateTime CreateDate { get; set; }

        //Relationship 
        public List<Opportunities> CreatedOpportunities { get; set; }
    }
}
