using Microsoft.AspNetCore.Identity;

namespace WebApplication2.Models
{
    public class InformationUser :IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
