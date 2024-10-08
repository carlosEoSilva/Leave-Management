using Microsoft.AspNetCore.Identity;

namespace LeaveManagementSystem.Data
{
    //note-15
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
    }
}
