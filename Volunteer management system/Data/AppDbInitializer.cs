using System.ComponentModel.DataAnnotations.Schema;
using Volunteer_management_system.Models;

namespace Volunteer_management_system.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) {
            var context = serviceScope.ServiceProvider.GetService<AppDBContext>();
            context.Database.EnsureCreated();
                if (!context.Users.Any())
                {
                    context.Users.AddRange(new List<Users>()
                    {
                        new Users()
                        {
                            FirstName="Test",
                            LastName= "User 01",
                            Email="test@user.xxx",
                            Password="1q2w3e",
                            Role="coordinator",
                            Organization="Test Organization",
                            CreateDate= DateTime.Now.AddDays(-30),
                        }
                });

                    context.SaveChanges();
                }

                if (!context.Opportunities.Any())
                {
                    context.Opportunities.AddRange(new List<Opportunities>()
                    {
                        new Opportunities()
                        {
                            ID="org01-some-opp-name-293000",
                             Title= "Test Opportunity 01",
                             Description=  "Pellentesque venenatis justo metus, a egestas velit vehicula nec. Vestibulum feugiat lacus sed lacus malesuada, eu imperdiet ex sagittis. Morbi eu feugiat tellus, vitae semper mi. Phasellus vulputate tellus nibh. Maecenas venenatis sagittis blandit. Vestibulum quis arcu nec risus commodo ultricies. Sed finibus, ante a faucibus rhoncus, tortor magna placerat metus, eu laoreet nulla risus vel risus. Ut sit amet risus non dui feugiat hendrerit. Suspendisse at felis vehicula, sagittis libero in, fermentum libero. Suspendisse eget hendrerit nunc. Vivamus consequat pulvinar tellus commodo tempor. Pellentesque at ligula at augue rhoncus cursus convallis eu odio. Nulla enim erat, porttitor sed laoreet vel, tincidunt at ante. Phasellus viverra, odio non luctus accumsan, urna arcu congue ipsum, sed facilisis orci turpis vel justo. Vestibulum id leo facilisis, maximus elit quis, volutpat quam. Morbi tincidunt ut lorem a molestie.",
                              Organization="Test Organization", 
                              Vacancies = 20,
                              UserId = 1,
                              StartDate= DateTime.Now.AddDays(20),
                            EndDate=DateTime.Now.AddMonths(6),
                        },
                    new Opportunities()
                        {
                            ID="org01-some-opp-name-313091",
                             Title= "Test Opportunity 01",
                             Description=  "Pellentesque venenatis justo metus, a egestas velit vehicula nec. Vestibulum feugiat lacus sed lacus malesuada, eu imperdiet ex sagittis. Morbi eu feugiat tellus, vitae semper mi. Phasellus vulputate tellus nibh. Maecenas venenatis sagittis blandit. Vestibulum quis arcu nec risus commodo ultricies. Sed finibus, ante a faucibus rhoncus, tortor magna placerat metus, eu laoreet nulla risus vel risus. Ut sit amet risus non dui feugiat hendrerit. Suspendisse at felis vehicula, sagittis libero in, fermentum libero. Suspendisse eget hendrerit nunc. Vivamus consequat pulvinar tellus commodo tempor. Pellentesque at ligula at augue rhoncus cursus convallis eu odio. Nulla enim erat, porttitor sed laoreet vel, tincidunt at ante. Phasellus viverra, odio non luctus accumsan, urna arcu congue ipsum, sed facilisis orci turpis vel justo. Vestibulum id leo facilisis, maximus elit quis, volutpat quam. Morbi tincidunt ut lorem a molestie.",
                              Organization="Test Organization",
                              Vacancies = 20,
                              UserId = 1,
                              StartDate= DateTime.Now.AddDays(25),
                            EndDate=DateTime.Now.AddMonths(5),
                        },
                    new Opportunities()
                        {
                            ID="org01-some-opp-name-87302",
                             Title= "Test Opportunity 01",
                             Description=  "Pellentesque venenatis justo metus, a egestas velit vehicula nec. Vestibulum feugiat lacus sed lacus malesuada, eu imperdiet ex sagittis. Morbi eu feugiat tellus, vitae semper mi. Phasellus vulputate tellus nibh. Maecenas venenatis sagittis blandit. Vestibulum quis arcu nec risus commodo ultricies. Sed finibus, ante a faucibus rhoncus, tortor magna placerat metus, eu laoreet nulla risus vel risus. Ut sit amet risus non dui feugiat hendrerit. Suspendisse at felis vehicula, sagittis libero in, fermentum libero. Suspendisse eget hendrerit nunc. Vivamus consequat pulvinar tellus commodo tempor. Pellentesque at ligula at augue rhoncus cursus convallis eu odio. Nulla enim erat, porttitor sed laoreet vel, tincidunt at ante. Phasellus viverra, odio non luctus accumsan, urna arcu congue ipsum, sed facilisis orci turpis vel justo. Vestibulum id leo facilisis, maximus elit quis, volutpat quam. Morbi tincidunt ut lorem a molestie.",
                              Organization="Test Organization",
                              Vacancies = 20,
                              UserId = 1,
                              StartDate= DateTime.Now.AddDays(15),
                            EndDate=DateTime.Now.AddMonths(10),
                        }
                    });
                    
                    context.SaveChanges();
                }

                if (!context.Applications.Any())
                {
                    context.Applications.AddRange(new List<Applications>()
                    {
                        new Applications()
                        {
                            ApplicantFullName= "Test Applicant 01",
                            ApplicantEmail="test@applicant.xxx",
                            OpportunityID="org01-some-opp-name-293000",
                            Note=  "Pellentesque venenatis justo metus, a egestas velit vehicula nec. Vestibulum feugiat lacus sed lacus malesuada, eu imperdiet ex sagittis. Morbi eu feugiat tellus, vitae semper mi. Phasellus vulputate tellus nibh. Maecenas venenatis sagittis blandit. Vestibulum quis arcu nec risus commodo ultricies. Sed finibus, ante a faucibus rhoncus, tortor magna placerat metus, eu laoreet nulla risus vel risus. Ut sit amet risus non dui feugiat hendrerit. Suspendisse at felis vehicula, sagittis libero in, fermentum libero. Suspendisse eget hendrerit nunc. Vivamus consequat pulvinar tellus commodo tempor. Pellentesque at ligula at augue rhoncus cursus convallis eu odio. Nulla enim erat, porttitor sed laoreet vel, tincidunt at ante. Phasellus viverra, odio non luctus accumsan, urna arcu congue ipsum, sed facilisis orci turpis vel justo. Vestibulum id leo facilisis, maximus elit quis, volutpat quam. Morbi tincidunt ut lorem a molestie.",
                            Status="Pending",
                            CreateDate= DateTime.Now.AddDays(1),
    }
                });

                    context.SaveChanges();
                }
            }
        }
    }
}
