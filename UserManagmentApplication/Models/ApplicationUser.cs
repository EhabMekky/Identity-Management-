using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UserManagementApplication.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, StringLength(50)]
        public string FirstName { get; set; }

        [Required, StringLength(50)]
        public string LastName { get; set; }

        private string _profilePicture;
        public string ProfilePicture
        {
            get { return _profilePicture; }
            set { _profilePicture = value ?? "default.jpg"; } // Set a default value if null is provided
        }

        [Required, StringLength(100)] 
        public string EmailConfirmed { get; set; }

        [Required, StringLength(25)]
        public string PhoneNumber { get; set; }
    }
}
